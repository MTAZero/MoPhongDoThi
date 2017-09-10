using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.Model
{
    public static class Kruskal
    {
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int[] lab = new int[maxn];
        private static bool[] kt;

        // ket qua
        private static List<DoThi> ans = new List<DoThi>();

        #region Kruskal
        private static int Findset(int u)
        {
            if (lab[u] <= 0) return u;
            int ans = Findset(lab[u]);
            lab[u] = ans;
            return ans;
        }

        private static void Uni(int r, int s)
        {
            if (lab[r] < lab[s]) lab[s] = r;
            else
            {
                if (lab[r] == lab[s]) lab[s]--;
                lab[r] = s;
            }
        }
        #endregion

        #region Hàm chức năng

        private static void SaveGraph(int mod)
        {
            DoThi z = dothi.Clone();

            for (int i = 1; i <= z.dsCanh.Count; i++ )
            {
                Canh canh = z.dsCanh[i - 1];
                if (kt[i] == true)
                {
                    canh.mau = Color.Green;
                    continue;
                }

                if (i == mod)
                    canh.mau = Color.OrangeRed;
                else
                    canh.mau = Color.LightGray;
            }

            ans.Add(z);
        }

        private static void Init_Kruskal()
        {
            // Mảng đánh dấu cạnh nào thuộc cây khung
            kt = new bool[dothi.dsCanh.Count + 1];
            for (int i = 1; i <= dothi.dsCanh.Count; i++)
                kt[i] = false;

            // Chuẩn bị mảng lab cho disjoin set Forest
            for (int i = 1; i <= dothi.dsDinh.Count; i++)
                lab[i] = 0;
        }

        private static void KruskalMain()
        {
            dothi.dsCanh.Sort();
            Init_Kruskal();
            SaveGraph(-1);

            for (int i = 1; i <= dothi.dsCanh.Count; i++)
            {
                Canh canh = dothi.dsCanh[i - 1];
                SaveGraph(i);
                int u = IndexOf(canh.IDXP);
                int v = IndexOf(canh.IDKT);
                int r = Findset(u);
                int s = Findset(v);
                if (r != s)
                {
                    Uni(r, s);
                    kt[i] = true;
                }
                
            }
        }

        private static void InitGraph()
        { 
            KruskalMain();
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
                if (dothi.dsDinh[mid].ID == ID) return mid + 1;
                if (dothi.dsDinh[mid].ID > ID) high = mid - 1;
                else low = mid + 1;
            }
            return high + 1;
        }
        public static List<DoThi> Run(DoThi a)
        {
            ans = new List<DoThi>();
            dothi = a.Clone();
            InitGraph();
            return ans;
        }
        #endregion
    }
}
