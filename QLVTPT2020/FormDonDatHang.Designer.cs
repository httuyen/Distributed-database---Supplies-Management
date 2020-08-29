namespace QLVTPT2020
{
    partial class FormDonDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDonDatHang));
            this.grCN = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridCTDDH = new DevExpress.XtraGrid.GridControl();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.dsQLVT = new QLVTPT2020.QLVT_DATHANGDataSet_DATA();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barEditDDH = new DevExpress.XtraBars.BarManager(this.components);
            this.barEditL = new DevExpress.XtraBars.Bar();
            this.btnAddL = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditL = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteL = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveL = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoL = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshL = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitL = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneL = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standAloneR = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridDH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grEditDDH = new System.Windows.Forms.GroupBox();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.SpinEdit();
            this.txtNCC = new DevExpress.XtraEditors.TextEdit();
            this.txtNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMSDDH = new DevExpress.XtraEditors.TextEdit();
            this.grEditCTDDH = new System.Windows.Forms.GroupBox();
            this.cmbMaVT_R = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSL = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMSDDHR = new DevExpress.XtraEditors.TextEdit();
            this.barEditCTDDH = new DevExpress.XtraBars.BarManager(this.components);
            this.barEditR = new DevExpress.XtraBars.Bar();
            this.btnAddR = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteR = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveR = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoR = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshR = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitR = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.datHangTableAdapter = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.CTDDHTableAdapter();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.PhieuNhapTableAdapter();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.grCN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barEditDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grEditDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).BeginInit();
            this.grEditCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDHR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barEditCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(27, 27);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(60, 13);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(49, 60);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(38, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(40, 91);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(47, 13);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nha CC:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(48, 124);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(40, 161);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(47, 13);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Location = new System.Drawing.Point(23, 27);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(60, 13);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Maso DDH:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(45, 60);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(24, 95);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(59, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(32, 128);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(51, 13);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // grCN
            // 
            this.grCN.BackColor = System.Drawing.SystemColors.Control;
            this.grCN.Controls.Add(this.labelControl1);
            this.grCN.Controls.Add(this.cmbCN);
            this.grCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.grCN.Location = new System.Drawing.Point(0, 0);
            this.grCN.Name = "grCN";
            this.grCN.Size = new System.Drawing.Size(1203, 41);
            this.grCN.TabIndex = 19;
            this.grCN.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(287, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Chi Nhánh";
            // 
            // cmbCN
            // 
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(345, 12);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(121, 21);
            this.cmbCN.TabIndex = 15;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12469F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87531F));
            this.tableLayoutPanel1.Controls.Add(this.gridCTDDH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridDH, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.standaloneL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.standAloneR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grEditDDH, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grEditCTDDH, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 41);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.34384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.65616F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1203, 603);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // gridCTDDH
            // 
            this.gridCTDDH.DataSource = this.bdsCTDDH;
            this.gridCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTDDH.Location = new System.Drawing.Point(606, 74);
            this.gridCTDDH.MainView = this.gridView2;
            this.gridCTDDH.MenuManager = this.barEditDDH;
            this.gridCTDDH.Name = "gridCTDDH";
            this.gridCTDDH.Size = new System.Drawing.Size(594, 272);
            this.gridCTDDH.TabIndex = 3;
            this.gridCTDDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridCTDDH.Click += new System.EventHandler(this.gridCTDDH_Click);
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDH;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "DatHang";
            this.bdsDH.DataSource = this.dsQLVT;
            // 
            // dsQLVT
            // 
            this.dsQLVT.DataSetName = "QLVT_DATHANGDataSet_DATA";
            this.dsQLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.gridCTDDH;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // barEditDDH
            // 
            this.barEditDDH.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barEditL});
            this.barEditDDH.DockControls.Add(this.barDockControlTop);
            this.barEditDDH.DockControls.Add(this.barDockControlBottom);
            this.barEditDDH.DockControls.Add(this.barDockControlLeft);
            this.barEditDDH.DockControls.Add(this.barDockControlRight);
            this.barEditDDH.DockControls.Add(this.standaloneL);
            this.barEditDDH.DockControls.Add(this.standAloneR);
            this.barEditDDH.Form = this;
            this.barEditDDH.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddL,
            this.btnEditL,
            this.btnDeleteL,
            this.btnSaveL,
            this.btnUndoL,
            this.btnRefreshL,
            this.btnExitL});
            this.barEditDDH.MaxItemId = 8;
            // 
            // barEditL
            // 
            this.barEditL.BarName = "Tools";
            this.barEditL.DockCol = 0;
            this.barEditL.DockRow = 0;
            this.barEditL.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barEditL.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEditL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDeleteL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaveL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExitL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barEditL.StandaloneBarDockControl = this.standaloneL;
            this.barEditL.Text = "Tools";
            // 
            // btnAddL
            // 
            this.btnAddL.Caption = "Thêm";
            this.btnAddL.Id = 0;
            this.btnAddL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddL.ImageOptions.Image")));
            this.btnAddL.Name = "btnAddL";
            this.btnAddL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddL_ItemClick);
            // 
            // btnEditL
            // 
            this.btnEditL.Caption = "Sửa";
            this.btnEditL.Id = 1;
            this.btnEditL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditL.ImageOptions.Image")));
            this.btnEditL.Name = "btnEditL";
            this.btnEditL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditL_ItemClick);
            // 
            // btnDeleteL
            // 
            this.btnDeleteL.Caption = "Xóa";
            this.btnDeleteL.Id = 3;
            this.btnDeleteL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteL.ImageOptions.Image")));
            this.btnDeleteL.Name = "btnDeleteL";
            this.btnDeleteL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteL_ItemClick);
            // 
            // btnSaveL
            // 
            this.btnSaveL.Caption = "Ghi";
            this.btnSaveL.Id = 4;
            this.btnSaveL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveL.ImageOptions.Image")));
            this.btnSaveL.Name = "btnSaveL";
            this.btnSaveL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveL_ItemClick);
            // 
            // btnUndoL
            // 
            this.btnUndoL.Caption = "Quay lại";
            this.btnUndoL.Id = 5;
            this.btnUndoL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoL.ImageOptions.Image")));
            this.btnUndoL.Name = "btnUndoL";
            this.btnUndoL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoL_ItemClick);
            // 
            // btnRefreshL
            // 
            this.btnRefreshL.Caption = "Làm mới";
            this.btnRefreshL.Id = 6;
            this.btnRefreshL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshL.ImageOptions.Image")));
            this.btnRefreshL.Name = "btnRefreshL";
            this.btnRefreshL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshL_ItemClick);
            // 
            // btnExitL
            // 
            this.btnExitL.Caption = "Thoát";
            this.btnExitL.Id = 7;
            this.btnExitL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitL.ImageOptions.Image")));
            this.btnExitL.Name = "btnExitL";
            this.btnExitL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitL_ItemClick);
            // 
            // standaloneL
            // 
            this.standaloneL.CausesValidation = false;
            this.standaloneL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standaloneL.Location = new System.Drawing.Point(3, 3);
            this.standaloneL.Manager = this.barEditDDH;
            this.standaloneL.Name = "standaloneL";
            this.standaloneL.Size = new System.Drawing.Size(597, 65);
            this.standaloneL.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barEditDDH;
            this.barDockControlTop.Size = new System.Drawing.Size(1203, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 644);
            this.barDockControlBottom.Manager = this.barEditDDH;
            this.barDockControlBottom.Size = new System.Drawing.Size(1203, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barEditDDH;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1203, 0);
            this.barDockControlRight.Manager = this.barEditDDH;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 644);
            // 
            // standAloneR
            // 
            this.standAloneR.CausesValidation = false;
            this.standAloneR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standAloneR.Location = new System.Drawing.Point(606, 3);
            this.standAloneR.Manager = this.barEditDDH;
            this.standAloneR.Name = "standAloneR";
            this.standAloneR.Size = new System.Drawing.Size(594, 65);
            this.standAloneR.Text = "standaloneBarDockControl2";
            // 
            // gridDH
            // 
            this.gridDH.DataSource = this.bdsDH;
            this.gridDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDH.Location = new System.Drawing.Point(3, 74);
            this.gridDH.MainView = this.gridView1;
            this.gridDH.MenuManager = this.barEditDDH;
            this.gridDH.Name = "gridDH";
            this.gridDH.Size = new System.Drawing.Size(597, 272);
            this.gridDH.TabIndex = 2;
            this.gridDH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridDH.Click += new System.EventHandler(this.gridDH_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gridDH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // grEditDDH
            // 
            this.grEditDDH.Controls.Add(mAKHOLabel);
            this.grEditDDH.Controls.Add(this.txtMaKho);
            this.grEditDDH.Controls.Add(mANVLabel);
            this.grEditDDH.Controls.Add(this.txtMaNV);
            this.grEditDDH.Controls.Add(nhaCCLabel);
            this.grEditDDH.Controls.Add(this.txtNCC);
            this.grEditDDH.Controls.Add(nGAYLabel);
            this.grEditDDH.Controls.Add(this.txtNgay);
            this.grEditDDH.Controls.Add(masoDDHLabel);
            this.grEditDDH.Controls.Add(this.txtMSDDH);
            this.grEditDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEditDDH.Location = new System.Drawing.Point(3, 352);
            this.grEditDDH.Name = "grEditDDH";
            this.grEditDDH.Size = new System.Drawing.Size(597, 248);
            this.grEditDDH.TabIndex = 6;
            this.grEditDDH.TabStop = false;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MAKHO", true));
            this.txtMaKho.Location = new System.Drawing.Point(93, 158);
            this.txtMaKho.MenuManager = this.barEditDDH;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(100, 20);
            this.txtMaKho.TabIndex = 9;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MANV", true));
            this.txtMaNV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMaNV.Location = new System.Drawing.Point(93, 121);
            this.txtMaNV.MenuManager = this.barEditDDH;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 7;
            // 
            // txtNCC
            // 
            this.txtNCC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "NhaCC", true));
            this.txtNCC.Location = new System.Drawing.Point(93, 88);
            this.txtNCC.MenuManager = this.barEditDDH;
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(100, 20);
            this.txtNCC.TabIndex = 5;
            // 
            // txtNgay
            // 
            this.txtNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "NGAY", true));
            this.txtNgay.EditValue = null;
            this.txtNgay.Location = new System.Drawing.Point(93, 57);
            this.txtNgay.MenuManager = this.barEditDDH;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgay.Size = new System.Drawing.Size(100, 20);
            this.txtNgay.TabIndex = 3;
            // 
            // txtMSDDH
            // 
            this.txtMSDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDH, "MasoDDH", true));
            this.txtMSDDH.Location = new System.Drawing.Point(93, 24);
            this.txtMSDDH.MenuManager = this.barEditDDH;
            this.txtMSDDH.Name = "txtMSDDH";
            this.txtMSDDH.Size = new System.Drawing.Size(100, 20);
            this.txtMSDDH.TabIndex = 1;
            // 
            // grEditCTDDH
            // 
            this.grEditCTDDH.Controls.Add(this.cmbMaVT_R);
            this.grEditCTDDH.Controls.Add(dONGIALabel);
            this.grEditCTDDH.Controls.Add(this.txtDonGia);
            this.grEditCTDDH.Controls.Add(sOLUONGLabel);
            this.grEditCTDDH.Controls.Add(this.txtSL);
            this.grEditCTDDH.Controls.Add(mAVTLabel);
            this.grEditCTDDH.Controls.Add(this.txtMaVT);
            this.grEditCTDDH.Controls.Add(masoDDHLabel1);
            this.grEditCTDDH.Controls.Add(this.txtMSDDHR);
            this.grEditCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEditCTDDH.Location = new System.Drawing.Point(606, 352);
            this.grEditCTDDH.Name = "grEditCTDDH";
            this.grEditCTDDH.Size = new System.Drawing.Size(594, 248);
            this.grEditCTDDH.TabIndex = 7;
            this.grEditCTDDH.TabStop = false;
            // 
            // cmbMaVT_R
            // 
            this.cmbMaVT_R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaVT_R.FormattingEnabled = true;
            this.cmbMaVT_R.Location = new System.Drawing.Point(195, 57);
            this.cmbMaVT_R.Name = "cmbMaVT_R";
            this.cmbMaVT_R.Size = new System.Drawing.Size(164, 21);
            this.cmbMaVT_R.TabIndex = 11;
            this.cmbMaVT_R.SelectionChangeCommitted += new System.EventHandler(this.cmbMaVT_R_SelectionChangeCommitted);
            this.cmbMaVT_R.Click += new System.EventHandler(this.cmbMaVT_R_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.txtDonGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGia.Location = new System.Drawing.Point(89, 125);
            this.txtDonGia.MenuManager = this.barEditDDH;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtSL
            // 
            this.txtSL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "SOLUONG", true));
            this.txtSL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSL.Location = new System.Drawing.Point(89, 92);
            this.txtSL.MenuManager = this.barEditDDH;
            this.txtSL.Name = "txtSL";
            this.txtSL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSL.Size = new System.Drawing.Size(100, 20);
            this.txtSL.TabIndex = 5;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MAVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(89, 57);
            this.txtMaVT.MenuManager = this.barEditDDH;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(100, 20);
            this.txtMaVT.TabIndex = 3;
            // 
            // txtMSDDHR
            // 
            this.txtMSDDHR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MasoDDH", true));
            this.txtMSDDHR.Location = new System.Drawing.Point(89, 24);
            this.txtMSDDHR.MenuManager = this.barEditDDH;
            this.txtMSDDHR.Name = "txtMSDDHR";
            this.txtMSDDHR.Size = new System.Drawing.Size(100, 20);
            this.txtMSDDHR.TabIndex = 1;
            this.txtMSDDHR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSDDHR_KeyPress);
            // 
            // barEditCTDDH
            // 
            this.barEditCTDDH.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barEditR});
            this.barEditCTDDH.DockControls.Add(this.barDockControl1);
            this.barEditCTDDH.DockControls.Add(this.barDockControl2);
            this.barEditCTDDH.DockControls.Add(this.barDockControl3);
            this.barEditCTDDH.DockControls.Add(this.barDockControl4);
            this.barEditCTDDH.Form = this;
            this.barEditCTDDH.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddR,
            this.barButtonItem7,
            this.btnDeleteR,
            this.btnSaveR,
            this.btnUndoR,
            this.btnRefreshR,
            this.btnExitR});
            this.barEditCTDDH.MaxItemId = 7;
            // 
            // barEditR
            // 
            this.barEditR.BarName = "Tools";
            this.barEditR.DockCol = 0;
            this.barEditR.DockRow = 0;
            this.barEditR.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barEditR.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDeleteR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaveR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExitR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barEditR.StandaloneBarDockControl = this.standAloneR;
            this.barEditR.Text = "Tools";
            // 
            // btnAddR
            // 
            this.btnAddR.Caption = "Thêm";
            this.btnAddR.Id = 0;
            this.btnAddR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddR.ImageOptions.Image")));
            this.btnAddR.Name = "btnAddR";
            this.btnAddR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddR_ItemClick);
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.Caption = "Xóa";
            this.btnDeleteR.Id = 2;
            this.btnDeleteR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteR.ImageOptions.Image")));
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteR_ItemClick);
            // 
            // btnSaveR
            // 
            this.btnSaveR.Caption = "Ghi";
            this.btnSaveR.Id = 3;
            this.btnSaveR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveR.ImageOptions.Image")));
            this.btnSaveR.Name = "btnSaveR";
            this.btnSaveR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveR_ItemClick);
            // 
            // btnUndoR
            // 
            this.btnUndoR.Caption = "Quay lại";
            this.btnUndoR.Id = 4;
            this.btnUndoR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoR.ImageOptions.Image")));
            this.btnUndoR.Name = "btnUndoR";
            this.btnUndoR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoR_ItemClick);
            // 
            // btnRefreshR
            // 
            this.btnRefreshR.Caption = "Làm mới";
            this.btnRefreshR.Id = 5;
            this.btnRefreshR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshR.ImageOptions.Image")));
            this.btnRefreshR.Name = "btnRefreshR";
            this.btnRefreshR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshR_ItemClick);
            // 
            // btnExitR
            // 
            this.btnExitR.Caption = "Thoát";
            this.btnExitR.Id = 6;
            this.btnExitR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitR.ImageOptions.Image")));
            this.btnExitR.Name = "btnExitR";
            this.btnExitR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitR_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barEditCTDDH;
            this.barDockControl1.Size = new System.Drawing.Size(1203, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 644);
            this.barDockControl2.Manager = this.barEditCTDDH;
            this.barDockControl2.Size = new System.Drawing.Size(1203, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barEditCTDDH;
            this.barDockControl3.Size = new System.Drawing.Size(0, 644);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1203, 0);
            this.barDockControl4.Manager = this.barEditCTDDH;
            this.barDockControl4.Size = new System.Drawing.Size(0, 644);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Sửa";
            this.barButtonItem7.Id = 1;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPN.DataSource = this.bdsDH;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FormDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 644);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grCN);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormDonDatHang";
            this.Text = "Đơn Đặt Hàng";
            this.Load += new System.EventHandler(this.FormDonDatHang_Load);
            this.grCN.ResumeLayout(false);
            this.grCN.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barEditDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grEditDDH.ResumeLayout(false);
            this.grEditDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDH.Properties)).EndInit();
            this.grEditCTDDH.ResumeLayout(false);
            this.grEditCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDHR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barEditCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grCN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneL;
        private DevExpress.XtraBars.BarManager barEditDDH;
        private DevExpress.XtraBars.Bar barEditL;
        private DevExpress.XtraBars.BarButtonItem btnAddL;
        private DevExpress.XtraBars.BarButtonItem btnEditL;
        private DevExpress.XtraBars.BarButtonItem btnDeleteL;
        private DevExpress.XtraBars.BarButtonItem btnSaveL;
        private DevExpress.XtraBars.BarButtonItem btnUndoL;
        private DevExpress.XtraBars.BarButtonItem btnRefreshL;
        private DevExpress.XtraBars.BarButtonItem btnExitL;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.StandaloneBarDockControl standAloneR;
        private System.Windows.Forms.BindingSource bdsDH;
        private QLVT_DATHANGDataSet_DATA dsQLVT;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barEditCTDDH;
        private DevExpress.XtraBars.Bar barEditR;
        private DevExpress.XtraBars.BarButtonItem btnAddR;
        private DevExpress.XtraBars.BarButtonItem btnDeleteR;
        private DevExpress.XtraBars.BarButtonItem btnSaveR;
        private DevExpress.XtraBars.BarButtonItem btnUndoR;
        private DevExpress.XtraBars.BarButtonItem btnRefreshR;
        private DevExpress.XtraBars.BarButtonItem btnExitR;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private QLVT_DATHANGDataSet_DATATableAdapters.DatHangTableAdapter datHangTableAdapter;
        private QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVT_DATHANGDataSet_DATATableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraGrid.GridControl gridCTDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsPN;
        private QLVT_DATHANGDataSet_DATATableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.GroupBox grEditDDH;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.SpinEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtNCC;
        private DevExpress.XtraEditors.DateEdit txtNgay;
        private DevExpress.XtraEditors.TextEdit txtMSDDH;
        private System.Windows.Forms.GroupBox grEditCTDDH;
        private DevExpress.XtraEditors.SpinEdit txtSL;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private DevExpress.XtraEditors.TextEdit txtMSDDHR;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private System.Windows.Forms.ComboBox cmbMaVT_R;
    }
}