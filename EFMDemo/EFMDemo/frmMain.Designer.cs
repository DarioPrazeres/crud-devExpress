
namespace EFMDemo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroFuncionario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSeccao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NomeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SexoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NumeroFuncionarioTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CargoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SeccaoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNome = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNumeroFuncionario = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSexo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCargo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSeccao = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFuncionarioTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeccaoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumeroFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSeccao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete,
            this.btnCancel});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 4;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUpdate, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel, true)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "MainMenu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Update";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.LargeImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 2;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 3;
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.LargeImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "StatusBar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "StatusBar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1479, 56);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 859);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1479, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 56);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 803);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1479, 56);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 803);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.layoutControl1);
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NomeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SexoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NumeroFuncionarioTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CargoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SeccaoTextEdit);
            this.dataLayoutControl1.DataSource = this.funcionarioBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 56);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(3546, 209, 812, 500);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1479, 803);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl);
            this.layoutControl1.Location = new System.Drawing.Point(12, 90);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1469, 722);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.funcionarioBindingSource;
            this.gridControl.Location = new System.Drawing.Point(12, 12);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.MenuManager = this.barManager1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1445, 698);
            this.gridControl.TabIndex = 4;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataSource = typeof(EFMDemo.Funcionario);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNome,
            this.colSexo,
            this.colNumeroFuncionario,
            this.colCargo,
            this.colSeccao});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 94;
            // 
            // colNome
            // 
            this.colNome.FieldName = "Nome";
            this.colNome.MinWidth = 25;
            this.colNome.Name = "colNome";
            this.colNome.Visible = true;
            this.colNome.VisibleIndex = 1;
            this.colNome.Width = 94;
            // 
            // colSexo
            // 
            this.colSexo.FieldName = "Sexo";
            this.colSexo.MinWidth = 25;
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 2;
            this.colSexo.Width = 94;
            // 
            // colNumeroFuncionario
            // 
            this.colNumeroFuncionario.FieldName = "NumeroFuncionario";
            this.colNumeroFuncionario.MinWidth = 25;
            this.colNumeroFuncionario.Name = "colNumeroFuncionario";
            this.colNumeroFuncionario.Visible = true;
            this.colNumeroFuncionario.VisibleIndex = 3;
            this.colNumeroFuncionario.Width = 94;
            // 
            // colCargo
            // 
            this.colCargo.FieldName = "Cargo";
            this.colCargo.MinWidth = 25;
            this.colCargo.Name = "colCargo";
            this.colCargo.Visible = true;
            this.colCargo.VisibleIndex = 4;
            this.colCargo.Width = 94;
            // 
            // colSeccao
            // 
            this.colSeccao.FieldName = "Seccao";
            this.colSeccao.MinWidth = 25;
            this.colSeccao.Name = "colSeccao";
            this.colSeccao.Visible = true;
            this.colSeccao.VisibleIndex = 5;
            this.colSeccao.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1469, 722);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(1449, 702);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(1449, 702);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1449, 702);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Id", true));
            this.IdTextEdit.Location = new System.Drawing.Point(131, 12);
            this.IdTextEdit.MenuManager = this.barManager1;
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Size = new System.Drawing.Size(1350, 22);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 4;
            // 
            // NomeTextEdit
            // 
            this.NomeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Nome", true));
            this.NomeTextEdit.Location = new System.Drawing.Point(131, 38);
            this.NomeTextEdit.MenuManager = this.barManager1;
            this.NomeTextEdit.Name = "NomeTextEdit";
            this.NomeTextEdit.Size = new System.Drawing.Size(417, 22);
            this.NomeTextEdit.StyleController = this.dataLayoutControl1;
            this.NomeTextEdit.TabIndex = 5;
            // 
            // SexoTextEdit
            // 
            this.SexoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Sexo", true));
            this.SexoTextEdit.Location = new System.Drawing.Point(671, 38);
            this.SexoTextEdit.MenuManager = this.barManager1;
            this.SexoTextEdit.Name = "SexoTextEdit";
            this.SexoTextEdit.Size = new System.Drawing.Size(810, 22);
            this.SexoTextEdit.StyleController = this.dataLayoutControl1;
            this.SexoTextEdit.TabIndex = 6;
            // 
            // NumeroFuncionarioTextEdit
            // 
            this.NumeroFuncionarioTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "NumeroFuncionario", true));
            this.NumeroFuncionarioTextEdit.Location = new System.Drawing.Point(671, 64);
            this.NumeroFuncionarioTextEdit.MenuManager = this.barManager1;
            this.NumeroFuncionarioTextEdit.Name = "NumeroFuncionarioTextEdit";
            this.NumeroFuncionarioTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.NumeroFuncionarioTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NumeroFuncionarioTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NumeroFuncionarioTextEdit.Properties.Mask.EditMask = "N0";
            this.NumeroFuncionarioTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NumeroFuncionarioTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NumeroFuncionarioTextEdit.Size = new System.Drawing.Size(245, 22);
            this.NumeroFuncionarioTextEdit.StyleController = this.dataLayoutControl1;
            this.NumeroFuncionarioTextEdit.TabIndex = 7;
            // 
            // CargoTextEdit
            // 
            this.CargoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Cargo", true));
            this.CargoTextEdit.Location = new System.Drawing.Point(131, 64);
            this.CargoTextEdit.MenuManager = this.barManager1;
            this.CargoTextEdit.Name = "CargoTextEdit";
            this.CargoTextEdit.Size = new System.Drawing.Size(417, 22);
            this.CargoTextEdit.StyleController = this.dataLayoutControl1;
            this.CargoTextEdit.TabIndex = 8;
            // 
            // SeccaoTextEdit
            // 
            this.SeccaoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.funcionarioBindingSource, "Seccao", true));
            this.SeccaoTextEdit.Location = new System.Drawing.Point(1039, 64);
            this.SeccaoTextEdit.MenuManager = this.barManager1;
            this.SeccaoTextEdit.Name = "SeccaoTextEdit";
            this.SeccaoTextEdit.Size = new System.Drawing.Size(442, 22);
            this.SeccaoTextEdit.StyleController = this.dataLayoutControl1;
            this.SeccaoTextEdit.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1493, 824);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForId,
            this.ItemForNome,
            this.ItemForNumeroFuncionario,
            this.ItemForSexo,
            this.ItemForCargo,
            this.ItemForSeccao});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1473, 78);
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.Location = new System.Drawing.Point(0, 0);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(1473, 26);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(115, 16);
            // 
            // ItemForNome
            // 
            this.ItemForNome.Control = this.NomeTextEdit;
            this.ItemForNome.Location = new System.Drawing.Point(0, 26);
            this.ItemForNome.Name = "ItemForNome";
            this.ItemForNome.Size = new System.Drawing.Size(540, 26);
            this.ItemForNome.Text = "Nome";
            this.ItemForNome.TextSize = new System.Drawing.Size(115, 16);
            // 
            // ItemForNumeroFuncionario
            // 
            this.ItemForNumeroFuncionario.Control = this.NumeroFuncionarioTextEdit;
            this.ItemForNumeroFuncionario.Location = new System.Drawing.Point(540, 52);
            this.ItemForNumeroFuncionario.Name = "ItemForNumeroFuncionario";
            this.ItemForNumeroFuncionario.Size = new System.Drawing.Size(368, 26);
            this.ItemForNumeroFuncionario.Text = "Numero Funcionario";
            this.ItemForNumeroFuncionario.TextSize = new System.Drawing.Size(115, 16);
            // 
            // ItemForSexo
            // 
            this.ItemForSexo.Control = this.SexoTextEdit;
            this.ItemForSexo.Location = new System.Drawing.Point(540, 26);
            this.ItemForSexo.Name = "ItemForSexo";
            this.ItemForSexo.Size = new System.Drawing.Size(933, 26);
            this.ItemForSexo.Text = "Sexo";
            this.ItemForSexo.TextSize = new System.Drawing.Size(115, 16);
            // 
            // ItemForCargo
            // 
            this.ItemForCargo.Control = this.CargoTextEdit;
            this.ItemForCargo.Location = new System.Drawing.Point(0, 52);
            this.ItemForCargo.Name = "ItemForCargo";
            this.ItemForCargo.Size = new System.Drawing.Size(540, 26);
            this.ItemForCargo.Text = "Cargo";
            this.ItemForCargo.TextSize = new System.Drawing.Size(115, 16);
            // 
            // ItemForSeccao
            // 
            this.ItemForSeccao.Control = this.SeccaoTextEdit;
            this.ItemForSeccao.Location = new System.Drawing.Point(908, 52);
            this.ItemForSeccao.Name = "ItemForSeccao";
            this.ItemForSeccao.Size = new System.Drawing.Size(565, 26);
            this.ItemForSeccao.Text = "Seccao";
            this.ItemForSeccao.TextSize = new System.Drawing.Size(115, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.layoutControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 78);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1473, 726);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 881);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD using Entity Framework";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SexoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroFuncionarioTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CargoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeccaoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumeroFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSeccao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private DevExpress.XtraEditors.TextEdit NomeTextEdit;
        private DevExpress.XtraEditors.TextEdit SexoTextEdit;
        private DevExpress.XtraEditors.TextEdit NumeroFuncionarioTextEdit;
        private DevExpress.XtraEditors.TextEdit CargoTextEdit;
        private DevExpress.XtraEditors.TextEdit SeccaoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNome;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSexo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumeroFuncionario;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCargo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSeccao;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNome;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroFuncionario;
        private DevExpress.XtraGrid.Columns.GridColumn colCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colSeccao;
    }
}