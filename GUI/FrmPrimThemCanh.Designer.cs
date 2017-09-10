namespace MoPhongDoThi.GUI
{
    partial class FrmPrimThemCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrimThemCanh));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbxLoaiCanh = new System.Windows.Forms.ComboBox();
            this.cbxDinhKT = new System.Windows.Forms.ComboBox();
            this.cbxDinhXP = new System.Windows.Forms.ComboBox();
            this.txtTrongSo = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCanh = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelControl1.Controls.Add(this.cbxLoaiCanh);
            this.panelControl1.Controls.Add(this.cbxDinhKT);
            this.panelControl1.Controls.Add(this.cbxDinhXP);
            this.panelControl1.Controls.Add(this.txtTrongSo);
            this.panelControl1.Controls.Add(this.btnHuy);
            this.panelControl1.Controls.Add(this.btnThemCanh);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(757, 242);
            this.panelControl1.TabIndex = 1;
            // 
            // cbxLoaiCanh
            // 
            this.cbxLoaiCanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoaiCanh.Enabled = false;
            this.cbxLoaiCanh.FormattingEnabled = true;
            this.cbxLoaiCanh.Items.AddRange(new object[] {
            "Cạnh 2 chiều",
            "Cạnh 1 chiều"});
            this.cbxLoaiCanh.Location = new System.Drawing.Point(183, 175);
            this.cbxLoaiCanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLoaiCanh.Name = "cbxLoaiCanh";
            this.cbxLoaiCanh.Size = new System.Drawing.Size(315, 24);
            this.cbxLoaiCanh.TabIndex = 6;
            // 
            // cbxDinhKT
            // 
            this.cbxDinhKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhKT.FormattingEnabled = true;
            this.cbxDinhKT.Location = new System.Drawing.Point(183, 71);
            this.cbxDinhKT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDinhKT.Name = "cbxDinhKT";
            this.cbxDinhKT.Size = new System.Drawing.Size(315, 24);
            this.cbxDinhKT.TabIndex = 6;
            // 
            // cbxDinhXP
            // 
            this.cbxDinhXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDinhXP.FormattingEnabled = true;
            this.cbxDinhXP.Location = new System.Drawing.Point(183, 20);
            this.cbxDinhXP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDinhXP.Name = "cbxDinhXP";
            this.cbxDinhXP.Size = new System.Drawing.Size(315, 24);
            this.cbxDinhXP.TabIndex = 6;
            // 
            // txtTrongSo
            // 
            this.txtTrongSo.Location = new System.Drawing.Point(183, 123);
            this.txtTrongSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTrongSo.Name = "txtTrongSo";
            this.txtTrongSo.Size = new System.Drawing.Size(315, 23);
            this.txtTrongSo.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(524, 71);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(201, 41);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemCanh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCanh.Image")));
            this.btnThemCanh.Location = new System.Drawing.Point(524, 20);
            this.btnThemCanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Size = new System.Drawing.Size(201, 41);
            this.btnThemCanh.TabIndex = 4;
            this.btnThemCanh.Text = "Thêm cạnh";
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại cạnh : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trọng số : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đỉnh kết thúc : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đỉnh xuất phát : ";
            // 
            // FrmPrimThemCanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 242);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrimThemCanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm cạnh";
            this.Load += new System.EventHandler(this.FrmPrimThemCanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtTrongSo;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThemCanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLoaiCanh;
        private System.Windows.Forms.ComboBox cbxDinhKT;
        private System.Windows.Forms.ComboBox cbxDinhXP;
        private System.Windows.Forms.Label label4;
    }
}