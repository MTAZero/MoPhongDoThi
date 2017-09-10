using MoPhongDoThi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi.GUI
{
    public partial class FrmBFSDieuKhienChay : Form
    {
        private List<DoThi> listDoThi = new List<DoThi>();
        private bool BatDauTuDong = false;
        private int index = 0;

        #region constructor
        public FrmBFSDieuKhienChay()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadInitControl()
        {
            ///  cbx Xuat Phat
            cbxDinhXuatPhat.DataSource = Data.Data.graph_BFS.dsDinh.ToList();
            cbxDinhXuatPhat.DisplayMember = "Ten";
            cbxDinhXuatPhat.ValueMember = "ID";

            // cbx ket thuc
            cbxDinhKetThuc.DataSource = Data.Data.graph_BFS.dsDinh.ToList();
            cbxDinhKetThuc.DisplayMember = "Ten";
            cbxDinhKetThuc.ValueMember = "ID";

            // chạy tự động
            btnTamDung.Enabled = false;
            btnKetThuc.Enabled = false;

            // chạy từng bước
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;

        }
        private void FrmBFSDieuKhienChay_Load(object sender, EventArgs e)
        {
            LoadInitControl();

            index = 0;
        }
        #endregion

        #region Hàm chức năng
        private void HienThiDoThi()
        {
            try
            {
                DoThi dt = listDoThi[index];
                panelMain.Controls.Clear();
                FrmVeDoThi ve = new FrmVeDoThi(dt);
                ve.TopLevel = false;
                ve.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ve);
                ve.Show();
                //if (index == listDoThi.Count - 1) timer.Stop();
            }
            catch
            {

            }
        }

        private bool Check()
        {
            if (Data.Data.graph_BFS.dsDinh.Count == 0)
            {
                MessageBox.Show("Đồ thị chưa có đỉnh nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int S = (int) cbxDinhXuatPhat.SelectedValue;
                int T = (int)cbxDinhKetThuc.SelectedValue;

                if (S==T)
                {
                    MessageBox.Show("Đỉnh kết thúc không được trùng với đỉnh bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch {
                MessageBox.Show("Chưa có đỉnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region sự kiện Chạy tự động
        private void btnChayTuDong_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                // kiểm tra time delay
                int timeDelay = 0;
                try
                {
                    timeDelay = Int32.Parse(txtDelay.Text);
                    if (timeDelay < 0)
                    {
                        MessageBox.Show("Time delay phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Time delay phải là số nguyên dương","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                btnTamDung.Enabled = true;
                btnKetThuc.Enabled = true;
                btnBatDauChayTungBuoc.Enabled = false;
                groupSetting.Enabled = false;

                listDoThi = BFS.Run(Data.Data.graph_BFS, (int)cbxDinhXuatPhat.SelectedValue, (int) cbxDinhKetThuc.SelectedValue);
                index = 0;
                timer.Enabled = true;
                timer.Interval = timeDelay;
                timer.Start();
                return;
            }
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            if (btnTamDung.Text == "Tạm dừng")
            {
                btnTamDung.Text = "Tiếp tục";
                timer.Stop();
                return;
            }

            if (btnTamDung.Text == "Tiếp tục")
            {
                btnTamDung.Text = "Tạm dừng";
                timer.Start();
                return;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            index = listDoThi.Count - 1;
            HienThiDoThi();
            timer.Stop();

            btnBatDauChayTungBuoc.Enabled = true;
            btnKetThuc.Enabled = false;
            btnTamDung.Enabled = false;
            groupSetting.Enabled = true;
        }
        #endregion

        #region Chạy từng bước
        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            
            HienThiDoThi();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index = (index - 1 + listDoThi.Count) % listDoThi.Count;
                HienThiDoThi();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index != listDoThi.Count)
            {
                index = (index + 1) % listDoThi.Count;
                HienThiDoThi();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            index = listDoThi.Count - 1;
            HienThiDoThi();
        }

        private void btnBatDauChayTungBuoc_Click(object sender, EventArgs e)
        {
            if (btnBatDauChayTungBuoc.Text == "Bắt đầu chạy từng bước")
            {
                if (Check())
                {
                    listDoThi = BFS.Run(Data.Data.graph_BFS, (int)cbxDinhXuatPhat.SelectedValue, (int)cbxDinhKetThuc.SelectedValue);
                    index = 0;
                    HienThiDoThi();

                    btnChayTuDong.Enabled = false;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnStart.Enabled = true;
                    btnEnd.Enabled = true;
                    groupSetting.Enabled = false;
                    btnBatDauChayTungBuoc.Text = "Kết thúc chạy từng bước";
                }
                return;
            }

            if (btnBatDauChayTungBuoc.Text == "Kết thúc chạy từng bước")
            {
                btnBatDauChayTungBuoc.Text = "Bắt đầu chạy từng bước";
                btnChayTuDong.Enabled = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnStart.Enabled = false;
                btnEnd.Enabled = false;
                groupSetting.Enabled = true;
                return;
            }
        }
        #endregion

        #region sự kiện ngầm
        private void timer_Tick(object sender, EventArgs e)
        {
            if (listDoThi.Count > 0)
            {
                index = (index + 1) % listDoThi.Count;
                HienThiDoThi();
                if (index == listDoThi.Count - 1) timer.Stop();
                return;
            }
        }
        #endregion

        

    }
}
