using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public static class Hamilton
    {
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static List<p>[] listCanh = new List<p>[maxn]; // danh sách cạnh
        private static bool[] kt = new bool[maxn];
        private static int[] LuaChon = new int[maxn];

        private static bool isFound = false;

        // ket qua
        private static List<DoThi> ans = new List<DoThi>();
        private static DoThi dothiz = new DoThi();

        #region Hàm chức năng
        private static void KhoiTaoDanhSachCanh()
        {
            for (int index = 0; index < maxn; index++)
                listCanh[index] = new List<p>();

            for (int index = 0; index < dothi.dsCanh.Count; index++)
            {
                Canh canh = dothi.dsCanh[index];
                int u = IndexOf(canh.IDXP);
                int v = IndexOf(canh.IDKT);
                canh.mau = Color.LightGray;

                p xt = new p();
                xt.v = v;
                xt.w = canh.TrongSo;
                xt.ID = canh.ID;

                listCanh[u].Add(xt);
                if (canh.LoaiCanh == 0)
                {
                    // nếu là cạnh 2 chiều
                    p qp = new p();
                    qp.v = u;
                    qp.w = canh.TrongSo;
                    qp.ID = canh.ID;

                    listCanh[v].Add(qp);
                }
            }
        }

        private static void SaveGraph(int Di)
        {
            if (Di == -2)
            {
                if (!isFound) return;
                ans.Add(dothiz);
                return;
            }
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];
                if (!kt[index] || index == S)
                    dinh.mau = Color.Green;
                else
                    dinh.mau = Color.LightGray;

                if (Di == index) dinh.mau = Color.OrangeRed;
            }

            ans.Add(z);
        }

        private static void GhiKetQua()
        {
            isFound = true;
        }

        private static void Find(int k)
        {
            int n = dothi.dsDinh.Count;
            if (k == n + 2 && LuaChon[n + 1] == S)
            {
                SaveGraph(LuaChon[k - 1]);
                GhiKetQua();
                return;
            }

            if (isFound) return;
            SaveGraph(LuaChon[k - 1]);
            int u = LuaChon[k - 1];
            foreach (p canh in listCanh[u])
            {
                if (isFound) return;

                int v = canh.v;
                if (kt[v] == true)
                {
                    if (k != n+1  && v == S) continue;
                    kt[v] = false;
                    Canh cz = dothi.dsCanh.Where(p => p.ID == canh.ID).FirstOrDefault();
                    cz.mau = Color.Red;
                    LuaChon[k] = v;
                    Find(k + 1);
                    cz.mau = Color.LightGray;
                    kt[v] = true;
                }
            }

        }

        private static void HamiltonMain()
        {
            isFound = false;
            for (int index = 0; index < dothi.dsDinh.Count; index++)
                kt[index] = true;

            LuaChon[1] = S;
            Find(2);
        }

        private static void InitGraph()
        {
            KhoiTaoDanhSachCanh();
            SaveGraph(-1);
            HamiltonMain();
        }
        #endregion

        #region Main
        /// <summary>
        /// Trả về index của 1 đỉnh có ID là ID
        /// </summary>
        /// <param name="ID">ID của đỉnh cần tìm index</param>
        /// <returns></returns>
        private static int IndexOf(int ID)
        {
            int low = 0, high = dothi.dsDinh.Count - 1;
            while (high >= low)
            {
                int mid = (high + low) / 2;
                if (dothi.dsDinh[mid].ID == ID) return mid;
                if (dothi.dsDinh[mid].ID > ID) high = mid - 1;
                else low = mid + 1;
            }
            return high;
        }
        public static List<DoThi> Run(DoThi a, int IDs)
        {
            ans = new List<DoThi>();
            dothi = a.Clone();
            S = IndexOf(IDs);
            InitGraph();
            return ans;
        }
        #endregion
    }
}
