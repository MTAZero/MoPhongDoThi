using MoPhongDoThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.GUI
{
    public partial class FrmKruskalThemDinh : Form
    {
        private int x, y;

        #region constructor
        public FrmKruskalThemDinh()
        {
            InitializeComponent();
            x = -1;
            y = -1;
        }

        public FrmKruskalThemDinh(int _x, int _y)
        {
            InitializeComponent();
            x = _x;
            y = _y;
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            if (txtTenDinh.Text == "")
            {
                MessageBox.Show("Tên đỉnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ok;

            try
            {
                int ts = Int32.Parse(txtX.Text);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Tọa độ của X phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int ts = Int32.Parse(txtY.Text);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Tọa độ của Y phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void ThemDinh()
        {
            if (Check())
            {
                Dinh dinh = new Dinh();
                dinh.mau = Color.Green;
                dinh.Ten = txtTenDinh.Text;
                dinh.x = Int32.Parse(txtX.Text);
                dinh.y = Int32.Parse(txtY.Text);
                //dinh.ThongTinThem = "D[" + dinh.Ten + "]=0";

                int count = Data.Data.graph_Kruskal.dsDinh.Count;
                if (count == 0) dinh.ID = 1; else dinh.ID = Data.Data.graph_Kruskal.dsDinh[count - 1].ID + 1;
                Data.Data.graph_Kruskal.AddDinh(dinh);

                MessageBox.Show("Thêm đỉnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemDinh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LoadForm
        private void FrmKruskalThemDinh_Load(object sender, EventArgs e)
        {
            if (this.x == -1 && this.y == -1)
            {
                Random rand = new Random();
                txtX.Text = rand.Next(1, 900).ToString();
                txtY.Text = rand.Next(1, 500).ToString();
                return;
            }

            txtX.Text = this.x.ToString();
            txtY.Text = this.y.ToString();
        }
        #endregion

        #region Key Press
        private void txtTenDinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemDinh();
            }
        }
        #endregion

        

    }
}
