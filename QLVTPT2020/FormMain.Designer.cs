namespace QLVTPT2020
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatVT = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAcc = new DevExpress.XtraBars.BarButtonItem();
            this.btnInNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnInVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnInBangKe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusTrip = new System.Windows.Forms.StatusStrip();
            this.statusMaNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusTenNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusNhomQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusTrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.btnKho,
            this.btnDatHang,
            this.btnNhapVT,
            this.btnXuatVT,
            this.barButtonItem4,
            this.btnCreateAcc,
            this.btnInNV,
            this.btnInVT,
            this.btnInDSDH,
            this.btnInBangKe});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(850, 143);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nhân Viên";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Vật Tư";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 5;
            this.btnKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.Image")));
            this.btnKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKho.ImageOptions.LargeImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Caption = "Đặt Hàng";
            this.btnDatHang.Id = 6;
            this.btnDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatHang.ImageOptions.Image")));
            this.btnDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDatHang.ImageOptions.LargeImage")));
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatHang_ItemClick);
            // 
            // btnNhapVT
            // 
            this.btnNhapVT.Caption = "Nhập Vật Tư";
            this.btnNhapVT.Id = 7;
            this.btnNhapVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapVT.ImageOptions.Image")));
            this.btnNhapVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhapVT.ImageOptions.LargeImage")));
            this.btnNhapVT.Name = "btnNhapVT";
            this.btnNhapVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapVT_ItemClick);
            // 
            // btnXuatVT
            // 
            this.btnXuatVT.Caption = "Xuất Vật Tư";
            this.btnXuatVT.Id = 8;
            this.btnXuatVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatVT.ImageOptions.Image")));
            this.btnXuatVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatVT.ImageOptions.LargeImage")));
            this.btnXuatVT.Name = "btnXuatVT";
            this.btnXuatVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatVT_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Caption = "Tạo Tài Khoản";
            this.btnCreateAcc.Id = 10;
            this.btnCreateAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateAcc.ImageOptions.Image")));
            this.btnCreateAcc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCreateAcc.ImageOptions.LargeImage")));
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAcc_ItemClick);
            // 
            // btnInNV
            // 
            this.btnInNV.Caption = "Danh Sách Nhân Viên";
            this.btnInNV.Id = 11;
            this.btnInNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInNV.ImageOptions.Image")));
            this.btnInNV.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInNV.ImageOptions.LargeImage")));
            this.btnInNV.Name = "btnInNV";
            this.btnInNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInNV_ItemClick);
            // 
            // btnInVT
            // 
            this.btnInVT.Caption = "Danh Sách Vật Tư";
            this.btnInVT.Id = 12;
            this.btnInVT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInVT.ImageOptions.Image")));
            this.btnInVT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInVT.ImageOptions.LargeImage")));
            this.btnInVT.Name = "btnInVT";
            this.btnInVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInVT_ItemClick);
            // 
            // btnInDSDH
            // 
            this.btnInDSDH.Caption = "Danh Sách Đơn Hàng";
            this.btnInDSDH.Id = 13;
            this.btnInDSDH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInDSDH.ImageOptions.Image")));
            this.btnInDSDH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInDSDH.ImageOptions.LargeImage")));
            this.btnInDSDH.Name = "btnInDSDH";
            this.btnInDSDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInDSDH_ItemClick);
            // 
            // btnInBangKe
            // 
            this.btnInBangKe.Caption = "Bảng Kê Nhập Xuất";
            this.btnInBangKe.Id = 14;
            this.btnInBangKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInBangKe.ImageOptions.Image")));
            this.btnInBangKe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInBangKe.ImageOptions.LargeImage")));
            this.btnInBangKe.Name = "btnInBangKe";
            this.btnInBangKe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInBangKe_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDatHang);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnNhapVT);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnXuatVT);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tài Khoản";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnCreateAcc);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Báo Cáo";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup8.Glyph")));
            this.ribbonPageGroup8.ItemLinks.Add(this.btnInNV);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnInVT);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnInDSDH);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnInBangKe);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // statusTrip
            // 
            this.statusTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusMaNV,
            this.statusTenNV,
            this.statusNhomQuyen});
            this.statusTrip.Location = new System.Drawing.Point(0, 423);
            this.statusTrip.Name = "statusTrip";
            this.statusTrip.Size = new System.Drawing.Size(850, 22);
            this.statusTrip.TabIndex = 2;
            this.statusTrip.Text = "statusStrip1";
            // 
            // statusMaNV
            // 
            this.statusMaNV.Name = "statusMaNV";
            this.statusMaNV.Size = new System.Drawing.Size(118, 17);
            this.statusMaNV.Text = "toolStripStatusLabel1";
            // 
            // statusTenNV
            // 
            this.statusTenNV.Name = "statusTenNV";
            this.statusTenNV.Size = new System.Drawing.Size(118, 17);
            this.statusTenNV.Text = "toolStripStatusLabel2";
            // 
            // statusNhomQuyen
            // 
            this.statusNhomQuyen.Name = "statusNhomQuyen";
            this.statusNhomQuyen.Size = new System.Drawing.Size(118, 17);
            this.statusNhomQuyen.Text = "toolStripStatusLabel3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 445);
            this.Controls.Add(this.statusTrip);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.Text = "Quản Lý Vật Tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing_1);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusTrip.ResumeLayout(false);
            this.statusTrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.StatusStrip statusTrip;
        public System.Windows.Forms.ToolStripStatusLabel statusMaNV;
        public System.Windows.Forms.ToolStripStatusLabel statusTenNV;
        public System.Windows.Forms.ToolStripStatusLabel statusNhomQuyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnDatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnNhapVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnXuatVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnCreateAcc;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnInNV;
        private DevExpress.XtraBars.BarButtonItem btnInVT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnInDSDH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnInBangKe;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
    }
}