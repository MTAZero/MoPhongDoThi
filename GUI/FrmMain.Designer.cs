namespace MoPhongDoThi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDijkstra = new DevExpress.XtraBars.BarButtonItem();
            this.barBFS = new DevExpress.XtraBars.BarButtonItem();
            this.barDFS = new DevExpress.XtraBars.BarButtonItem();
            this.barFordBellman = new DevExpress.XtraBars.BarButtonItem();
            this.barHamilton = new DevExpress.XtraBars.BarButtonItem();
            this.barPrim = new DevExpress.XtraBars.BarButtonItem();
            this.barKruskal = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barDijkstra,
            this.barBFS,
            this.barDFS,
            this.barFordBellman,
            this.barHamilton,
            this.barPrim,
            this.barKruskal});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(1732, 146);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barDijkstra
            // 
            this.barDijkstra.Caption = "Thuật toán dijkstra";
            this.barDijkstra.Glyph = ((System.Drawing.Image)(resources.GetObject("barDijkstra.Glyph")));
            this.barDijkstra.Id = 1;
            this.barDijkstra.Name = "barDijkstra";
            this.barDijkstra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDijkstra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDijkstra_ItemClick);
            // 
            // barBFS
            // 
            this.barBFS.Caption = "Thuật toán BFS";
            this.barBFS.Glyph = ((System.Drawing.Image)(resources.GetObject("barBFS.Glyph")));
            this.barBFS.Id = 2;
            this.barBFS.Name = "barBFS";
            this.barBFS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBFS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBFS_ItemClick);
            // 
            // barDFS
            // 
            this.barDFS.Caption = "Thuật toán DFS";
            this.barDFS.Glyph = ((System.Drawing.Image)(resources.GetObject("barDFS.Glyph")));
            this.barDFS.Id = 3;
            this.barDFS.Name = "barDFS";
            this.barDFS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDFS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDFS_ItemClick);
            // 
            // barFordBellman
            // 
            this.barFordBellman.Caption = "Thuật toán Ford-Bellman";
            this.barFordBellman.Glyph = ((System.Drawing.Image)(resources.GetObject("barFordBellman.Glyph")));
            this.barFordBellman.Id = 4;
            this.barFordBellman.Name = "barFordBellman";
            this.barFordBellman.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barFordBellman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFordBellman_ItemClick);
            // 
            // barHamilton
            // 
            this.barHamilton.Caption = "Thuật toán Hamilton";
            this.barHamilton.Glyph = ((System.Drawing.Image)(resources.GetObject("barHamilton.Glyph")));
            this.barHamilton.Id = 5;
            this.barHamilton.Name = "barHamilton";
            this.barHamilton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barHamilton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHamilton_ItemClick);
            // 
            // barPrim
            // 
            this.barPrim.Caption = "Thuật toán Prim";
            this.barPrim.Glyph = ((System.Drawing.Image)(resources.GetObject("barPrim.Glyph")));
            this.barPrim.Id = 6;
            this.barPrim.Name = "barPrim";
            this.barPrim.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barPrim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPrim_ItemClick);
            // 
            // barKruskal
            // 
            this.barKruskal.Caption = "Thuật toán Kruskal";
            this.barKruskal.Glyph = ((System.Drawing.Image)(resources.GetObject("barKruskal.Glyph")));
            this.barKruskal.Id = 7;
            this.barKruskal.Name = "barKruskal";
            this.barKruskal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKruskal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKruskal_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barDijkstra);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBFS);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDFS);
            this.ribbonPageGroup1.ItemLinks.Add(this.barFordBellman);
            this.ribbonPageGroup1.ItemLinks.Add(this.barHamilton);
            this.ribbonPageGroup1.ItemLinks.Add(this.barPrim);
            this.ribbonPageGroup1.ItemLinks.Add(this.barKruskal);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 146);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1732, 717);
            this.panelMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 863);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình mô phỏng các thuật toán trên đồ thị";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barDijkstra;
        private DevExpress.XtraBars.BarButtonItem barBFS;
        private DevExpress.XtraBars.BarButtonItem barDFS;
        private DevExpress.XtraBars.BarButtonItem barFordBellman;
        private DevExpress.XtraBars.BarButtonItem barHamilton;
        private DevExpress.XtraBars.BarButtonItem barPrim;
        private DevExpress.XtraBars.BarButtonItem barKruskal;
        private DevExpress.XtraEditors.PanelControl panelMain;
    }
}

