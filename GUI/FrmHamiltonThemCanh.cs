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
    public partial class FrmHamiltonThemCanh : Form
    {
        #region Constructor
        public FrmHamiltonThemCanh()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm
        private void LoadInitControl()
        {
            List<Dinh> xp = Data.Data.graph_Hamilton.dsDinh.ToList();
            // cbx Dinh Xuat Phat
            cbxDinhXP.DataSource = xp;
            cbxDinhXP.DisplayMember = "Ten";
            cbxDinhXP.ValueMember = "ID";

            List<Dinh> kt = Data.Data.graph_Hamilton.dsDinh.ToList();
            // cbx Dinh Ket Thuc
            cbxDinhKT.DataSource = kt;
            cbxDinhKT.DisplayMember = "Ten";
            cbxDinhKT.ValueMember = "ID";

            cbxLoaiCanh.SelectedIndex = 0;
        }
        private void FrmHamiltonThemCanh_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            if (Data.Data.graph_Hamilton.dsDinh.Count == 0)
            {
                MessageBox.Show("Danh sách đỉnh đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((int) cbxDinhKT.SelectedValue == (int) cbxDinhXP.SelectedValue)
            {
                MessageBox.Show("Đình xuất phát không được trùng đỉnh kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ok;
            try
            {
                int ts = Int32.Parse(txtTrongSo.Text);
                if (ts > 0) ok = true; else ok = false;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Trọng số của cạnh phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region sự kiện
        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Canh canh = new Canh();

                int cnt = Data.Data.graph_Hamilton.dsCanh.Count ;
                if (cnt == 0) canh.ID = 1;
                else canh.ID = Data.Data.graph_Hamilton.dsCanh[cnt - 1].ID + 1;

                canh.IDXP = (int) cbxDinhXP.SelectedValue;
                canh.IDKT = (int) cbxDinhKT.SelectedValue;
                canh.x1 = Data.Data.graph_Hamilton.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().x;
                canh.y1 = Data.Data.graph_Hamilton.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().y;
                canh.x2 = Data.Data.graph_Hamilton.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().x;
                canh.y2 = Data.Data.graph_Hamilton.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().y;
                canh.TrongSo = Int32.Parse(txtTrongSo.Text);
                canh.mau = Color.Black;
                canh.LoaiCanh = cbxLoaiCanh.SelectedIndex;

                Data.Data.graph_Hamilton.dsCanh.Add(canh);
                MessageBox.Show("Thêm cạnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
