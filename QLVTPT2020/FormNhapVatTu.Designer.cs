namespace QLVTPT2020
{
    partial class FormNhapVatTu
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapVatTu));
            this.grCN = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridCTPN = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.dsQLVT = new QLVTPT2020.QLVT_DATHANGDataSet_DATA();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barEditL = new DevExpress.XtraBars.Bar();
            this.btnAddL = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteL = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveL = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoL = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshL = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitL = new DevExpress.XtraBars.BarButtonItem();
            this.standAloneL = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.standAloneR = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.gridPN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grEditL = new System.Windows.Forms.GroupBox();
            this.cmbMSDDH = new System.Windows.Forms.ComboBox();
            this.txtMaNVL = new DevExpress.XtraEditors.TextEdit();
            this.txtMSDDHL = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayL = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPNL = new DevExpress.XtraEditors.TextEdit();
            this.grEditR = new System.Windows.Forms.GroupBox();
            this.cmbMaVT_R = new System.Windows.Forms.ComboBox();
            this.txtDonGiaR = new DevExpress.XtraEditors.SpinEdit();
            this.txtSLR = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVTR = new DevExpress.XtraEditors.TextEdit();
            this.txtMaPNR = new DevExpress.XtraEditors.TextEdit();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barEditR = new DevExpress.XtraBars.Bar();
            this.btnAddR = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveR = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoR = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshR = new DevExpress.XtraBars.BarButtonItem();
            this.btnExitR = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.phieuNhapTableAdapter = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager();
            this.cTPNTableAdapter = new QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.CTPNTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.grCN.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQLVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.grEditL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNVL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDHL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayL.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNL.Properties)).BeginInit();
            this.grEditR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVTR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(27, 41);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(39, 13);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(28, 67);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(38, 13);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(6, 93);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(60, 13);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(27, 119);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(38, 23);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(39, 13);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(39, 53);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(38, 13);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(18, 79);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(59, 13);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(26, 105);
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
            this.grCN.Size = new System.Drawing.Size(1122, 39);
            this.grCN.TabIndex = 18;
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91087F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08913F));
            this.tableLayoutPanel1.Controls.Add(this.gridCTPN, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.gridPN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.standAloneL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.standAloneR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grEditL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grEditR, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.92537F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.07462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 493);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // gridCTPN
            // 
            this.gridCTPN.DataSource = this.bdsCTPN;
            this.gridCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCTPN.Location = new System.Drawing.Point(562, 53);
            this.gridCTPN.MainView = this.gridView2;
            this.gridCTPN.MenuManager = this.barManager1;
            this.gridCTPN.Name = "gridCTPN";
            this.gridCTPN.Size = new System.Drawing.Size(557, 279);
            this.gridCTPN.TabIndex = 3;
            this.gridCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dsQLVT;
            // 
            // dsQLVT
            // 
            this.dsQLVT.DataSetName = "QLVT_DATHANGDataSet_DATA";
            this.dsQLVT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridCTPN;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barEditL});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standAloneL);
            this.barManager1.DockControls.Add(this.standAloneR);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddL,
            this.btnDeleteL,
            this.btnSaveL,
            this.btnUndoL,
            this.btnRefreshL,
            this.btnExitL});
            this.barManager1.MaxItemId = 6;
            // 
            // barEditL
            // 
            this.barEditL.BarName = "Tools";
            this.barEditL.DockCol = 0;
            this.barEditL.DockRow = 0;
            this.barEditL.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barEditL.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDeleteL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSaveL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndoL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefreshL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExitL, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barEditL.StandaloneBarDockControl = this.standAloneL;
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
            // btnDeleteL
            // 
            this.btnDeleteL.Caption = "Xóa";
            this.btnDeleteL.Id = 1;
            this.btnDeleteL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteL.ImageOptions.Image")));
            this.btnDeleteL.Name = "btnDeleteL";
            this.btnDeleteL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteL_ItemClick);
            // 
            // btnSaveL
            // 
            this.btnSaveL.Caption = "Ghi";
            this.btnSaveL.Id = 2;
            this.btnSaveL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveL.ImageOptions.Image")));
            this.btnSaveL.Name = "btnSaveL";
            this.btnSaveL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveL_ItemClick);
            // 
            // btnUndoL
            // 
            this.btnUndoL.Caption = "Quay lại";
            this.btnUndoL.Id = 3;
            this.btnUndoL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoL.ImageOptions.Image")));
            this.btnUndoL.Name = "btnUndoL";
            this.btnUndoL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoL_ItemClick);
            // 
            // btnRefreshL
            // 
            this.btnRefreshL.Caption = "Làm mới";
            this.btnRefreshL.Id = 4;
            this.btnRefreshL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshL.ImageOptions.Image")));
            this.btnRefreshL.Name = "btnRefreshL";
            this.btnRefreshL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshL_ItemClick);
            // 
            // btnExitL
            // 
            this.btnExitL.Caption = "Thoát";
            this.btnExitL.Id = 5;
            this.btnExitL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitL.ImageOptions.Image")));
            this.btnExitL.Name = "btnExitL";
            this.btnExitL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitL_ItemClick);
            // 
            // standAloneL
            // 
            this.standAloneL.CausesValidation = false;
            this.standAloneL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standAloneL.Location = new System.Drawing.Point(3, 3);
            this.standAloneL.Manager = this.barManager1;
            this.standAloneL.Name = "standAloneL";
            this.standAloneL.Size = new System.Drawing.Size(553, 44);
            this.standAloneL.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1122, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 532);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1122, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1122, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 532);
            // 
            // standAloneR
            // 
            this.standAloneR.CausesValidation = false;
            this.standAloneR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standAloneR.Location = new System.Drawing.Point(562, 3);
            this.standAloneR.Manager = this.barManager1;
            this.standAloneR.Name = "standAloneR";
            this.standAloneR.Size = new System.Drawing.Size(557, 44);
            this.standAloneR.Text = "standaloneBarDockControl1";
            // 
            // gridPN
            // 
            this.gridPN.DataSource = this.bdsPN;
            this.gridPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPN.Location = new System.Drawing.Point(3, 53);
            this.gridPN.MainView = this.gridView1;
            this.gridPN.MenuManager = this.barManager1;
            this.gridPN.Name = "gridPN";
            this.gridPN.Size = new System.Drawing.Size(553, 279);
            this.gridPN.TabIndex = 2;
            this.gridPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridPN.Click += new System.EventHandler(this.gridPN_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridPN;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // grEditL
            // 
            this.grEditL.Controls.Add(this.cmbMSDDH);
            this.grEditL.Controls.Add(mANVLabel);
            this.grEditL.Controls.Add(this.txtMaNVL);
            this.grEditL.Controls.Add(masoDDHLabel);
            this.grEditL.Controls.Add(this.txtMSDDHL);
            this.grEditL.Controls.Add(nGAYLabel);
            this.grEditL.Controls.Add(this.txtNgayL);
            this.grEditL.Controls.Add(mAPNLabel);
            this.grEditL.Controls.Add(this.txtMaPNL);
            this.grEditL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEditL.Location = new System.Drawing.Point(3, 338);
            this.grEditL.Name = "grEditL";
            this.grEditL.Size = new System.Drawing.Size(553, 152);
            this.grEditL.TabIndex = 6;
            this.grEditL.TabStop = false;
            // 
            // cmbMSDDH
            // 
            this.cmbMSDDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMSDDH.FormattingEnabled = true;
            this.cmbMSDDH.Location = new System.Drawing.Point(178, 89);
            this.cmbMSDDH.Name = "cmbMSDDH";
            this.cmbMSDDH.Size = new System.Drawing.Size(121, 21);
            this.cmbMSDDH.TabIndex = 11;
            this.cmbMSDDH.SelectionChangeCommitted += new System.EventHandler(this.cmbMSDDH_SelectionChangeCommitted);
            this.cmbMSDDH.DropDownClosed += new System.EventHandler(this.cmbMSDDH_DropDownClosed);
            this.cmbMSDDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbMSDDH_MouseClick);
            // 
            // txtMaNVL
            // 
            this.txtMaNVL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.txtMaNVL.Location = new System.Drawing.Point(72, 116);
            this.txtMaNVL.MenuManager = this.barManager1;
            this.txtMaNVL.Name = "txtMaNVL";
            this.txtMaNVL.Size = new System.Drawing.Size(100, 20);
            this.txtMaNVL.TabIndex = 7;
            // 
            // txtMSDDHL
            // 
            this.txtMSDDHL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.txtMSDDHL.Location = new System.Drawing.Point(72, 90);
            this.txtMSDDHL.MenuManager = this.barManager1;
            this.txtMSDDHL.Name = "txtMSDDHL";
            this.txtMSDDHL.Size = new System.Drawing.Size(100, 20);
            this.txtMSDDHL.TabIndex = 5;
            // 
            // txtNgayL
            // 
            this.txtNgayL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txtNgayL.EditValue = null;
            this.txtNgayL.Location = new System.Drawing.Point(72, 64);
            this.txtNgayL.MenuManager = this.barManager1;
            this.txtNgayL.Name = "txtNgayL";
            this.txtNgayL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayL.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayL.Size = new System.Drawing.Size(100, 20);
            this.txtNgayL.TabIndex = 3;
            // 
            // txtMaPNL
            // 
            this.txtMaPNL.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.txtMaPNL.Location = new System.Drawing.Point(72, 38);
            this.txtMaPNL.MenuManager = this.barManager1;
            this.txtMaPNL.Name = "txtMaPNL";
            this.txtMaPNL.Size = new System.Drawing.Size(100, 20);
            this.txtMaPNL.TabIndex = 1;
            this.txtMaPNL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaPNL_KeyPress);
            // 
            // grEditR
            // 
            this.grEditR.Controls.Add(this.cmbMaVT_R);
            this.grEditR.Controls.Add(dONGIALabel);
            this.grEditR.Controls.Add(this.txtDonGiaR);
            this.grEditR.Controls.Add(sOLUONGLabel);
            this.grEditR.Controls.Add(this.txtSLR);
            this.grEditR.Controls.Add(mAVTLabel);
            this.grEditR.Controls.Add(this.txtMaVTR);
            this.grEditR.Controls.Add(mAPNLabel1);
            this.grEditR.Controls.Add(this.txtMaPNR);
            this.grEditR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grEditR.Location = new System.Drawing.Point(562, 338);
            this.grEditR.Name = "grEditR";
            this.grEditR.Size = new System.Drawing.Size(557, 152);
            this.grEditR.TabIndex = 7;
            this.grEditR.TabStop = false;
            // 
            // cmbMaVT_R
            // 
            this.cmbMaVT_R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaVT_R.FormattingEnabled = true;
            this.cmbMaVT_R.Location = new System.Drawing.Point(189, 50);
            this.cmbMaVT_R.Name = "cmbMaVT_R";
            this.cmbMaVT_R.Size = new System.Drawing.Size(149, 21);
            this.cmbMaVT_R.TabIndex = 9;
            this.cmbMaVT_R.SelectionChangeCommitted += new System.EventHandler(this.cmbMaVT_R_SelectionChangeCommitted);
            this.cmbMaVT_R.DropDownClosed += new System.EventHandler(this.cmbMaVT_R_DropDownClosed);
            this.cmbMaVT_R.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbMaVT_R_MouseClick);
            // 
            // txtDonGiaR
            // 
            this.txtDonGiaR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.txtDonGiaR.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGiaR.Location = new System.Drawing.Point(83, 102);
            this.txtDonGiaR.MenuManager = this.barManager1;
            this.txtDonGiaR.Name = "txtDonGiaR";
            this.txtDonGiaR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGiaR.Size = new System.Drawing.Size(100, 20);
            this.txtDonGiaR.TabIndex = 7;
            // 
            // txtSLR
            // 
            this.txtSLR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "SOLUONG", true));
            this.txtSLR.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSLR.Location = new System.Drawing.Point(83, 76);
            this.txtSLR.MenuManager = this.barManager1;
            this.txtSLR.Name = "txtSLR";
            this.txtSLR.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSLR.Size = new System.Drawing.Size(100, 20);
            this.txtSLR.TabIndex = 5;
            // 
            // txtMaVTR
            // 
            this.txtMaVTR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAVT", true));
            this.txtMaVTR.Location = new System.Drawing.Point(83, 50);
            this.txtMaVTR.MenuManager = this.barManager1;
            this.txtMaVTR.Name = "txtMaVTR";
            this.txtMaVTR.Size = new System.Drawing.Size(100, 20);
            this.txtMaVTR.TabIndex = 3;
            // 
            // txtMaPNR
            // 
            this.txtMaPNR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAPN", true));
            this.txtMaPNR.Location = new System.Drawing.Point(83, 20);
            this.txtMaPNR.MenuManager = this.barManager1;
            this.txtMaPNR.Name = "txtMaPNR";
            this.txtMaPNR.Size = new System.Drawing.Size(100, 20);
            this.txtMaPNR.TabIndex = 1;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barEditR});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddR,
            this.barButtonItem8,
            this.btnUndoR,
            this.btnRefreshR,
            this.btnExitR,
            this.btnSaveR});
            this.barManager2.MaxItemId = 6;
            // 
            // barEditR
            // 
            this.barEditR.BarName = "Tools";
            this.barEditR.DockCol = 0;
            this.barEditR.DockRow = 0;
            this.barEditR.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barEditR.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddR, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // btnSaveR
            // 
            this.btnSaveR.Caption = "Ghi";
            this.btnSaveR.Id = 5;
            this.btnSaveR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveR.ImageOptions.Image")));
            this.btnSaveR.Name = "btnSaveR";
            this.btnSaveR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveR_ItemClick);
            // 
            // btnUndoR
            // 
            this.btnUndoR.Caption = "Quay lại";
            this.btnUndoR.Id = 2;
            this.btnUndoR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoR.ImageOptions.Image")));
            this.btnUndoR.Name = "btnUndoR";
            this.btnUndoR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoR_ItemClick);
            // 
            // btnRefreshR
            // 
            this.btnRefreshR.Caption = "Làm mới";
            this.btnRefreshR.Id = 3;
            this.btnRefreshR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshR.ImageOptions.Image")));
            this.btnRefreshR.Name = "btnRefreshR";
            this.btnRefreshR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshR_ItemClick);
            // 
            // btnExitR
            // 
            this.btnExitR.Caption = "Thoát";
            this.btnExitR.Id = 4;
            this.btnExitR.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitR.ImageOptions.Image")));
            this.btnExitR.Name = "btnExitR";
            this.btnExitR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExitR_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1122, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 532);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1122, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 532);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1122, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 532);
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Xóa";
            this.barButtonItem8.Id = 1;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVTPT2020.QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhapVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 532);
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
            this.Name = "FormNhapVatTu";
            this.Text = "Nhập Vật Tư";
            this.Load += new System.EventHandler(this.FormNhapVatTu_Load);
            this.grCN.ResumeLayout(false);
            this.grCN.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsQLVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.grEditL.ResumeLayout(false);
            this.grEditL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNVL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMSDDHL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayL.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNL.Properties)).EndInit();
            this.grEditR.ResumeLayout(false);
            this.grEditR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVTR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPNR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grCN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraBars.StandaloneBarDockControl standAloneL;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barEditL;
        private DevExpress.XtraBars.BarButtonItem btnAddL;
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
        private System.Windows.Forms.BindingSource bdsPN;
        private QLVT_DATHANGDataSet_DATA dsQLVT;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar barEditR;
        private DevExpress.XtraBars.BarButtonItem btnAddR;
        private DevExpress.XtraBars.BarButtonItem btnSaveR;
        private DevExpress.XtraBars.BarButtonItem btnUndoR;
        private DevExpress.XtraBars.BarButtonItem btnRefreshR;
        private DevExpress.XtraBars.BarButtonItem btnExitR;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private QLVT_DATHANGDataSet_DATATableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private QLVT_DATHANGDataSet_DATATableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gridPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVT_DATHANGDataSet_DATATableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraGrid.GridControl gridCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox grEditL;
        private System.Windows.Forms.ComboBox cmbMSDDH;
        private DevExpress.XtraEditors.TextEdit txtMaNVL;
        private DevExpress.XtraEditors.TextEdit txtMSDDHL;
        private DevExpress.XtraEditors.DateEdit txtNgayL;
        private DevExpress.XtraEditors.TextEdit txtMaPNL;
        private System.Windows.Forms.GroupBox grEditR;
        private System.Windows.Forms.ComboBox cmbMaVT_R;
        private DevExpress.XtraEditors.SpinEdit txtDonGiaR;
        private DevExpress.XtraEditors.SpinEdit txtSLR;
        private DevExpress.XtraEditors.TextEdit txtMaVTR;
        private DevExpress.XtraEditors.TextEdit txtMaPNR;
    }
}