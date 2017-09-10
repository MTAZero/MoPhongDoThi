using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public class p : IComparable
    {
        public int w;
        public int v;
        public int ID;

        public int CompareTo(object bz)
        {
            if (bz == null) return 1;
            p b = bz as p;
            if (w < b.w) return -1;
            if (w == b.w) return 0;
            return 1;
        }
    }

    public static class Dijkstra
    {
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static int T = 0; // đỉnh kết thúc
        private static int[] d = new int[maxn]; // Lưu trọng số của các đỉnh
        private static List<p>[] listCanh = new List<p>[maxn]; // danh sách cạnh
        private static bool[] kt = new bool[maxn]; // Đỉnh đó đã được lấy ra chưa
        private static int[] trace = new int[maxn]; // truy vết

        // data struct
        private static C5.IntervalHeap<p> Heap = new C5.IntervalHeap<p>();

        // ket qua
        private static List<DoThi> ans = new List<DoThi>();

        #region Test
        public static List<DoThi> Test(DoThi a, int IDs, int IDt)
        {
            List<DoThi> ans = new List<DoThi>();

            DoThi tg = a.Clone();
            foreach (Dinh dinh in tg.dsDinh)
            {
                dinh.mau = Color.Aqua;
                if (dinh.ID != IDs)
                {
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
                }
                else
                {
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = 0";
                }

            }

            ans.Add(tg);
            foreach (Dinh dinh in a.dsDinh)
            {
                DoThi z = tg.Clone();
                z.dsDinh.Where(p => p.ID == dinh.ID).FirstOrDefault().mau = Color.Orange;
                tg = z;
                ans.Add(z);
            }

            return ans;
        }
        #endregion

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

        private static void KhoiTaoKhoangCach()
        {
            for (int index = 0; index < dothi.dsDinh.Count; index++)
            {
                int cs = IndexOf(dothi.dsDinh[index].ID);
                if (cs != S) d[index] = oo; else d[index] = 0;
                kt[index] = true;
                trace[index] = -1;
            }

            /// thêm đỉnh đầu tiên vào Heap
            p z = new p();
            z.v = S;
            z.w = 0;
            Heap.Add(z);
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
                if (d[index] != oo)
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = " + d[index];
                else
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
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

        private static void DijkstraMain()
        {
            while (Heap.Count > 0)
            {
                p z = Heap.FindMin();
                int u = z.v;
                int du = z.w;
                Heap.DeleteMin();

                if (!kt[u]) continue;
                kt[u] = false;
                SaveGraph(u);
                if (u == T) return;

                foreach (p canh in listCanh[u])
                {
                    int v = canh.v;
                    int w = canh.w;

                    if (d[v] > d[u] + w)
                    {
                        d[v] = d[u] + w;
                        trace[v] = u;
                        p xx = new p();
                        xx.v = v;
                        xx.w = d[v];
                        Heap.Add(xx);
                    }
                }
            }
        }

        private static void InitGraph()
        {
            KhoiTaoDanhSachCanh();
            KhoiTaoKhoangCach();
            SaveGraph(-1);
            DijkstraMain();
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
