using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public static class DFS
    {
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static int T = 0; // đỉnh kết thúc
        private static List<p>[] listCanh = new List<p>[maxn]; // danh sách cạnh
        private static bool[] kt = new bool[maxn]; // Đỉnh đó đã được lấy ra chưa
        private static int[] trace = new int[maxn]; // truy vết

        // ket qua
        private static List<DoThi> ans = new List<DoThi>();

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

                p xt = new p();
                xt.v = v;
                xt.w = canh.TrongSo;

                listCanh[u].Add(xt);
                if (canh.LoaiCanh == 0)
                {
                    // nếu là cạnh 2 chiều
                    p qp = new p();
                    qp.v = u;
                    qp.w = canh.TrongSo;
                    listCanh[v].Add(qp);
                }
            }
        }

        private static void SaveGraph(int mod)
        {
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];

                if (kt[index])
                    dinh.mau = Color.LightGray;
                else
                    dinh.mau = Color.Green;

                if (mod == index) dinh.mau = Color.OrangeRed;
            }

            if (mod == -2 && kt[T] == false)
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
                               .Where(p => p.LoaiCanh == 0)
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu) || (p.IDXP == IDu && p.IDKT == IDx))
                               .FirstOrDefault();
                    if (canh != null)
                        canh.mau = Color.Red;
                    else
                    {
                        // tìm canhk 1 chiều
                        canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 1)
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu))
                               .FirstOrDefault();
                        if (canh != null) canh.mau = Color.Red;
                    }

                    u = trace[u];
                }
            }

            ans.Add(z);
        }

        private static void InitDFS()
        {
            foreach (Dinh dinh in dothi.dsDinh)
            {
                int index = IndexOf(dinh.ID);
                kt[index] = true;
                trace[index] = -1;
            }
        }

        private static void Visit(int u){
            kt[u]=false;
            SaveGraph(u);

            foreach (p canh in listCanh[u])
            {
                int v = canh.v;
                if (kt[v])
                {
                    trace[v] = u;
                    Visit(v);
                }
            }
        }

        private static void DFSMain()
        {
            InitDFS();
            Visit(S);
        }

        private static void InitGraph()
        {
            KhoiTaoDanhSachCanh();
            SaveGraph(-1);
            DFSMain();
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
