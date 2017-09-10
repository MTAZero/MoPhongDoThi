using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public static class Prim
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
        private static int[] trace = new int[maxn]; // truy vết cạnh
        private static bool[] flag = new bool[maxn]; //  lưu xem cạnh đã được thêm vào cây khung chưa

        // data struct
        private static C5.IntervalHeap<p> Heap = new C5.IntervalHeap<p>();

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
                xt.ID = index;

                listCanh[u].Add(xt);
                if (canh.LoaiCanh == 0)
                {
                    // nếu là cạnh 2 chiều
                    p qp = new p();
                    qp.v = u;
                    qp.w = canh.TrongSo;
                    qp.ID = index;
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

            for (int i = 0; i < dothi.dsCanh.Count; i++ ) 
                flag[i] = false;

            /// thêm đỉnh đầu tiên vào Heap
            p z = new p();
            z.v = S;
            z.w = 0;
            Heap.Add(z);
        }

        private static void SaveGraph(int IDcanh)
        {
            DoThi z = dothi.Clone();

            if (IDcanh >= 0) flag[IDcanh] = true;

            for (int index = 0; index < dothi.dsCanh.Count; index++)
            {
                Canh canh = z.dsCanh[index];
                if (flag[index])
                    canh.mau = Color.Green;
                else
                    canh.mau = Color.LightGray;

                if (index == IDcanh) canh.mau = Color.OrangeRed;
            }

            for (int i = 0; i < dothi.dsDinh.Count; i++)
            {
                Dinh dinh = z.dsDinh[i];
                if (d[i] == oo)
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
                else
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = " + d[i];

                if (kt[i] == false)
                    dinh.mau = Color.Green;
                else
                    dinh.mau = Color.LightGray;
            }

            ans.Add(z);
        }

        private static void PrimMain()
        {
            while (Heap.Count > 0)
            {
                p z = Heap.FindMin();
                int u = z.v;
                int du = z.w;
                Heap.DeleteMin();

                if (!kt[u]) continue;
                kt[u] = false;

                d[u] = 0;
                if (u != S) SaveGraph(trace[u]);
                

                foreach (p canh in listCanh[u])
                {
                    int v = canh.v;
                    int w = canh.w;

                    if (d[v] > d[u] + w)
                    {
                        d[v] = d[u] + w;
                        trace[v] = canh.ID;
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
            PrimMain();
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
        public static List<DoThi> Run(DoThi a)
        {
            ans = new List<DoThi>();
            S = 0;
            dothi = a.Clone();
            InitGraph();
            return ans;
        }
        #endregion
    }
}
