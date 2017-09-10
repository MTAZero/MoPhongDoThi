namespace MoPhongDoThi.GUI
{
    partial class FrmDijkstraDieuKhienChay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDijkstraDieuKhienChay));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBatDauChayTungBuoc = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKetThuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnTamDung = new DevExpress.XtraEditors.SimpleButton();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChayTuDong = new DevExpress.XtraEditors.SimpleButton();
            this.groupSetting = new DevExpress.XtraEditors.PanelControl();
            this.cbxDinhKetThuc = new System.Windows.Forms.ComboBox();
            this.cbxDinhXuatPhat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSetting)).BeginInit();
            this.groupSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(400, 788);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.groupSetting);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(396, 784);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Điều khiển";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.btnEnd);
            this.panelControl3.Controls.Add(this.btnStart);
            this.panelControl3.Controls.Add(this.btnPrev);
            this.panelControl3.Controls.Add(this.btnNext);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.btnBatDauChayTungBuoc);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 335);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(392, 121);
            this.panelControl3.TabIndex = 6;
            // 
            // btnEnd
            // 
            this.btnEnd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnEnd.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.Image")));
            this.btnEnd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEnd.Location = new System.Drawing.Point(295, 70);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(88, 39);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStart.Location = new System.Drawing.Point(7, 70);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 39);
            this.btnStart.TabIndex = 6;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(103, 70);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(88, 39);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(199, 70);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 39);
            this.btnNext.TabIndex = 4;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chạy từng bước";
            // 
            // btnBatDauChayTungBuoc
            // 
            this.btnBatDauChayTungBuoc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnBatDauChayTungBuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDauChayTungBuoc.Image")));
            this.btnBatDauChayTungBuoc.Location = new System.Drawing.Point(7, 23);
            this.btnBatDauChayTungBuoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnBatDauChayTungBuoc.Name = "btnBatDauChayTungBuoc";
            this.btnBatDauChayTungBuoc.Size = new System.Drawing.Size(376, 39);
            this.btnBatDauChayTungBuoc.TabIndex = 1;
            this.btnBatDauChayTungBuoc.Text = "Bắt đầu chạy từng bước";
            this.btnBatDauChayTungBuoc.Click += new System.EventHandler(this.btnBatDauChayTungBuoc_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.btnKetThuc);
            this.panelControl2.Controls.Add(this.btnTamDung);
            this.panelControl2.Controls.Add(this.txtDelay);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.btnChayTuDong);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 149);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(392, 186);
            this.panelControl2.TabIndex = 5;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnKetThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.Image")));
            this.btnKetThuc.Location = new System.Drawing.Point(7, 139);
            this.btnKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(376, 39);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTamDung.Image = ((System.Drawing.Image)(resources.GetObject("btnTamDung.Image")));
            this.btnTamDung.Location = new System.Drawing.Point(192, 92);
            this.btnTamDung.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(189, 39);
            this.btnTamDung.TabIndex = 4;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(149, 39);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(212, 23);
            this.txtDelay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thời gian delay : ";
            // 
            // btnChayTuDong
            // 
            this.btnChayTuDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnChayTuDong.Image = ((System.Drawing.Image)(resources.GetObject("btnChayTuDong.Image")));
            this.btnChayTuDong.Location = new System.Drawing.Point(7, 92);
            this.btnChayTuDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnChayTuDong.Name = "btnChayTuDong";
            this.btnChayTuDong.Size = new System.Drawing.Size(179, 39);
            this.btnChayTuDong.TabIndex = 1;
            this.btnChayTuDong.Text = "Bắt đầu chạy tự động";
            this.btnChayTuDong.Click += new System.EventHandler(this.btnChayTuDong_Click);
            // 
            // groupSetting
            // 
            this.groupSetting.Appearance.BackColor = System.Drawing.Color.White;
            this.groupSetting.Appearance.Options.UseBackColor = true;
            this.groupSetting.Controls.Add(this.cbxDinhKetThuc);
            this.groupSetting.Controls.Add(this.cbxDinhXuatPhat);
            this.groupSetting.Controls.Add(this.label4);
            this.groupSetting.Controls.Add(this.label3);
            this.groupSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupSetting.Location = new System.Drawing.Point(2, 26);
            this.groupSetting.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.groupSetting.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupSetting.Margin = new System.Windows.Forms.Padding(4);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(392, 123);
            this.groupSetting.TabIndex = 4;
            // 
            // cbxDinhKetThuc
            // 
            this.cbxDinhKetThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhKetThuc.FormattingEnabled = true;
            this.cbxDinhKetThuc.Location = new System.Drawing.Point(149, 73);
            this.cbxDinhKetThuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDinhKetThuc.Name = "cbxDinhKetThuc";
            this.cbxDinhKetThuc.Size = new System.Drawing.Size(212, 24);
            this.cbxDinhKetThuc.TabIndex = 1;
            // 
            // cbxDinhXuatPhat
            // 
            this.cbxDinhXuatPhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhXuatPhat.FormattingEnabled = true;
            this.cbxDinhXuatPhat.Location = new System.Drawing.Point(149, 23);
            this.cbxDinhXuatPhat.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDinhXuatPhat.Name = "cbxDinhXuatPhat";
            this.cbxDinhXuatPhat.Size = new System.Drawing.Size(212, 24);
            this.cbxDinhXuatPhat.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đỉnh kết thúc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đỉnh xuất phát : ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelMain);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(400, 0);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1247, 788);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "Đồ thị";
            // 
            // panelMain
            // 
            this.panelMain.Appearance.BackColor = System.Drawing.Color.White;
            this.panelMain.Appearance.Options.UseBackColor = true;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 26);
            this.panelMain.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1243, 760);
            this.panelMain.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmDijkstraDieuKhienChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 788);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDijkstraDieuKhienChay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều khiển chạy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDijkstraDieuKhienChay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSetting)).EndInit();
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl groupSetting;
        private System.Windows.Forms.ComboBox cbxDinhKetThuc;
        private System.Windows.Forms.ComboBox cbxDinhXuatPhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnBatDauChayTungBuoc;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKetThuc;
        private DevExpress.XtraEditors.SimpleButton btnTamDung;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnChayTuDong;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private System.Windows.Forms.Timer timer;
    }
}