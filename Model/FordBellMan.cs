using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public static class FordBellman
    {
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static int T = 0; // đỉnh kết thúc
        private static int[] d = new int[maxn]; // Lưu trọng số của các đỉnh
        private static int[] trace = new int[maxn]; // truy vết
        private static bool[] kt = new bool[maxn * maxn];

        // ket qua
        private static List<DoThi> ans = new List<DoThi>();

        #region Hàm chức năng

        private static void KhoiTaoKhoangCach()
        {
            for (int index = 0; index < dothi.dsDinh.Count; index++)
            {
                int cs = IndexOf(dothi.dsDinh[index].ID);
                if (cs != S) d[index] = oo; else d[index] = 0;
                trace[index] = -1;
            }

        }

        private static void SaveGraph(int mod)
        {
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];

                if (d[index] != oo)
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = " + d[index];
                else
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
            }

            for (int index = 0; index < z.dsCanh.Count; index++)
            {
                Canh canh = z.dsCanh[index];
               
                canh.mau = Color.LightGray;
                if (kt[index]) canh.mau = Color.Green;
                if (index == mod) canh.mau = Color.OrangeRed;
            }

            if (mod == -2 && d[T] != oo)
            {
                // in đường đi cuối cùng
                int u = T;
                while (u != S)
                {
                    int x = trace[u];

                    // tô màu đỏ cạnh nối từ x đến u
                    int IDu = dothi.dsDinh[u].ID;
                    int IDx = dothi.dsDinh[x].ID;

                    // tìm cạnh 2 chiều
                    Canh canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 0 && p.TrongSo == d[u] - d[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu) || (p.IDXP == IDu && p.IDKT == IDx))
                               .FirstOrDefault();
                    if (canh != null)
                        canh.mau = Color.Red;
                    else
                    {
                        // tìm canhk 1 chiều
                        canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 1 && p.TrongSo == d[u] - d[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu))
                               .FirstOrDefault();
                        if (canh != null) canh.mau = Color.Red;
                    }

                    u = trace[u];
                }
            }

            ans.Add(z);
        }

        private static void FordBellmanMain()
        {
            int m = dothi.dsCanh.Count;
            for (int index = 1; index <= dothi.dsDinh.Count; index++)
            {
                int cnt = dothi.dsCanh.Count;

                for (int i = 0; i < dothi.dsCanh.Count; i++)
                    kt[i] = false;
                SaveGraph(-1);

                for (int i = 0; i < dothi.dsCanh.Count; i++)
                {
                    Canh canh = dothi.dsCanh[i];

                    bool ok = false;

                    int u = IndexOf(canh.IDXP);
                    int v = IndexOf(canh.IDKT);

                    
                    SaveGraph(i);


                    if (d[v] > d[u] + canh.TrongSo)
                    {
                        d[v] = d[u] + canh.TrongSo;
                        trace[v] = u;
                        ok = true;
                        kt[i] = true;
                    }

                    if (canh.LoaiCanh == 0 && d[u] > d[v] + canh.TrongSo)
                    {
                        d[u] = d[v] + canh.TrongSo;
                        trace[u] = v;
                        ok = true;
                        kt[i] = true;
                    }

                    if (ok) cnt--;
                }

                if (cnt == m) return;
            }
        }

        private static void InitGraph()
        {
            KhoiTaoKhoangCach();

            FordBellmanMain();
            SaveGraph(-2);
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
        public static List<DoThi> Run(DoThi a, int IDs, int IDt)
        {
            ans = new List<DoThi>();
            dothi = a.Clone();
            S = IndexOf(IDs);
            T = IndexOf(IDt);
            InitGraph();
            return ans;
        }
        #endregion
    }
}
