namespace GUI
{
    partial class frmStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraLayout.LayoutControl layoutControl1;
            DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.txt_Level = new DevExpress.XtraEditors.TextEdit();
            this.txt_Phone = new DevExpress.XtraEditors.TextEdit();
            this.txt_Address = new DevExpress.XtraEditors.TextEdit();
            this.txt_Name = new DevExpress.XtraEditors.TextEdit();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.dtp_Birth = new DevExpress.XtraEditors.DateEdit();
            this.txt_Department = new DevExpress.XtraEditors.TextEdit();
            this.txt_BangCap = new DevExpress.XtraEditors.TextEdit();
            this.lci_NS = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_TenTT = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_DC = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_SDT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lci_CV = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_Insert = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMãNhânViên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHọTên = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgàySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colĐịaChỉ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSốĐiệnThoại = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênBộPhận = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTênChứcVụ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBằngCấp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(layoutControl1)).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Level.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Birth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Birth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BangCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_NS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TenTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_DC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_CV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(this.txt_Level);
            layoutControl1.Controls.Add(this.txt_Phone);
            layoutControl1.Controls.Add(this.txt_Address);
            layoutControl1.Controls.Add(this.txt_Name);
            layoutControl1.Controls.Add(this.txt_ID);
            layoutControl1.Controls.Add(this.dtp_Birth);
            layoutControl1.Controls.Add(this.txt_Department);
            layoutControl1.Controls.Add(this.txt_BangCap);
            layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            layoutControl1.Location = new System.Drawing.Point(0, 0);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(238, 169, 550, 350);
            layoutControl1.Root = layoutControlGroup1;
            layoutControl1.Size = new System.Drawing.Size(944, 125);
            layoutControl1.TabIndex = 7;
            layoutControl1.Text = "layoutControl1";
            // 
            // txt_Level
            // 
            this.txt_Level.Enabled = false;
            this.txt_Level.Location = new System.Drawing.Point(109, 92);
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Level.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Level.Properties.Appearance.Options.UseFont = true;
            this.txt_Level.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Level.Size = new System.Drawing.Size(341, 24);
            this.txt_Level.StyleController = layoutControl1;
            this.txt_Level.TabIndex = 10;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(551, 68);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Phone.Properties.Appearance.Options.UseFont = true;
            this.txt_Phone.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Phone.Size = new System.Drawing.Size(364, 24);
            this.txt_Phone.StyleController = layoutControl1;
            this.txt_Phone.TabIndex = 9;
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(551, 40);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Address.Properties.Appearance.Options.UseFont = true;
            this.txt_Address.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Address.Size = new System.Drawing.Size(364, 24);
            this.txt_Address.StyleController = layoutControl1;
            this.txt_Address.TabIndex = 6;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(109, 40);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Name.Properties.Appearance.Options.UseFont = true;
            this.txt_Name.Properties.Appearance.Options.UseForeColor = true;
            this.txt_Name.Size = new System.Drawing.Size(341, 24);
            this.txt_Name.StyleController = layoutControl1;
            this.txt_Name.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(109, 12);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ID.Properties.Appearance.Options.UseFont = true;
            this.txt_ID.Properties.Appearance.Options.UseForeColor = true;
            this.txt_ID.Size = new System.Drawing.Size(341, 24);
            this.txt_ID.StyleController = layoutControl1;
            this.txt_ID.TabIndex = 4;
            // 
            // dtp_Birth
            // 
            this.dtp_Birth.EditValue = null;
            this.dtp_Birth.Location = new System.Drawing.Point(551, 12);
            this.dtp_Birth.Name = "dtp_Birth";
            this.dtp_Birth.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Birth.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtp_Birth.Properties.Appearance.Options.UseFont = true;
            this.dtp_Birth.Properties.Appearance.Options.UseForeColor = true;
            this.dtp_Birth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Birth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_Birth.Properties.Mask.BeepOnError = true;
            this.dtp_Birth.Properties.Mask.IgnoreMaskBlank = false;
            this.dtp_Birth.Size = new System.Drawing.Size(364, 24);
            this.dtp_Birth.StyleController = layoutControl1;
            this.dtp_Birth.TabIndex = 7;
            // 
            // txt_Department
            // 
            this.txt_Department.Enabled = false;
            this.txt_Department.Location = new System.Drawing.Point(109, 68);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(341, 20);
            this.txt_Department.StyleController = layoutControl1;
            this.txt_Department.TabIndex = 11;
            // 
            // txt_BangCap
            // 
            this.txt_BangCap.Location = new System.Drawing.Point(551, 96);
            this.txt_BangCap.Name = "txt_BangCap";
            this.txt_BangCap.Size = new System.Drawing.Size(364, 20);
            this.txt_BangCap.StyleController = layoutControl1;
            this.txt_BangCap.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            layoutControlGroup1.GroupBordersVisible = false;
            layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci_NS,
            this.layoutControlItem1,
            this.lci_TenTT,
            this.layoutControlItem2,
            this.lci_DC,
            this.lci_SDT,
            this.lci_CV,
            this.layoutControlItem3});
            layoutControlGroup1.Name = "Root";
            layoutControlGroup1.Size = new System.Drawing.Size(927, 128);
            layoutControlGroup1.TextVisible = false;
            // 
            // lci_NS
            // 
            this.lci_NS.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_NS.AppearanceItemCaption.Options.UseFont = true;
            this.lci_NS.Control = this.dtp_Birth;
            this.lci_NS.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lci_NS.Location = new System.Drawing.Point(442, 0);
            this.lci_NS.Name = "lci_NS";
            this.lci_NS.Size = new System.Drawing.Size(465, 28);
            this.lci_NS.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_NS.Text = "Ngày sinh";
            this.lci_NS.TextSize = new System.Drawing.Size(94, 17);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem1.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem1.Control = this.txt_ID;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(442, 28);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem1.Text = "Mã Nhân Viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 17);
            // 
            // lci_TenTT
            // 
            this.lci_TenTT.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_TenTT.AppearanceItemCaption.Options.UseFont = true;
            this.lci_TenTT.Control = this.txt_Name;
            this.lci_TenTT.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lci_TenTT.Location = new System.Drawing.Point(0, 28);
            this.lci_TenTT.Name = "lci_TenTT";
            this.lci_TenTT.Size = new System.Drawing.Size(442, 28);
            this.lci_TenTT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_TenTT.Text = "Họ tên";
            this.lci_TenTT.TextSize = new System.Drawing.Size(94, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txt_Department;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(442, 24);
            this.layoutControlItem2.Text = "Bộ Phận";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 16);
            // 
            // lci_DC
            // 
            this.lci_DC.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_DC.AppearanceItemCaption.Options.UseFont = true;
            this.lci_DC.Control = this.txt_Address;
            this.lci_DC.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lci_DC.Location = new System.Drawing.Point(442, 28);
            this.lci_DC.Name = "lci_DC";
            this.lci_DC.Size = new System.Drawing.Size(465, 28);
            this.lci_DC.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_DC.Text = "Địa chỉ";
            this.lci_DC.TextSize = new System.Drawing.Size(94, 17);
            // 
            // lci_SDT
            // 
            this.lci_SDT.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_SDT.AppearanceItemCaption.Options.UseFont = true;
            this.lci_SDT.Control = this.txt_Phone;
            this.lci_SDT.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lci_SDT.Location = new System.Drawing.Point(442, 56);
            this.lci_SDT.Name = "lci_SDT";
            this.lci_SDT.Size = new System.Drawing.Size(465, 28);
            this.lci_SDT.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_SDT.Text = "Điện thoại";
            this.lci_SDT.TextSize = new System.Drawing.Size(94, 17);
            // 
            // lci_CV
            // 
            this.lci_CV.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lci_CV.AppearanceItemCaption.Options.UseFont = true;
            this.lci_CV.Control = this.txt_Level;
            this.lci_CV.ControlAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lci_CV.Location = new System.Drawing.Point(0, 80);
            this.lci_CV.Name = "lci_CV";
            this.lci_CV.Size = new System.Drawing.Size(442, 28);
            this.lci_CV.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lci_CV.Text = "Chức vụ";
            this.lci_CV.TextSize = new System.Drawing.Size(94, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.layoutControlItem3.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txt_BangCap;
            this.layoutControlItem3.Location = new System.Drawing.Point(442, 84);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(465, 24);
            this.layoutControlItem3.Text = "Bằng Cấp";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 16);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Giới tính";
            this.gridColumn4.FieldName = "Sex";
            this.gridColumn4.MinWidth = 40;
            this.gridColumn4.Name = "gridColumn4";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Insert.Appearance.Options.UseFont = true;
            this.btn_Insert.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Insert.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Insert.ImageOptions.Image")));
            this.btn_Insert.Location = new System.Drawing.Point(2, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(181, 41);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Tiếp Nhận Nhân Viên";
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Update.Appearance.Options.UseFont = true;
            this.btn_Update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.ImageOptions.Image")));
            this.btn_Update.Location = new System.Drawing.Point(183, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(107, 41);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Delete.Appearance.Options.UseFont = true;
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ImageOptions.Image")));
            this.btn_Delete.Location = new System.Drawing.Point(290, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(107, 41);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "DELETE";
            // 
            // btn_Save
            // 
            this.btn_Save.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Save.Appearance.Options.UseFont = true;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.ImageOptions.Image")));
            this.btn_Save.Location = new System.Drawing.Point(397, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(107, 41);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "SAVE";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.ImageOptions.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(504, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(107, 41);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "CANCEL";
            // 
            // txt_Search
            // 
            this.txt_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Search.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Search.Location = new System.Drawing.Point(611, 2);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(331, 41);
            this.txt_Search.TabIndex = 5;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.txt_Search);
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Update);
            this.panelControl1.Controls.Add(this.btn_Insert);
            this.panelControl1.Location = new System.Drawing.Point(0, 128);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(944, 45);
            this.panelControl1.TabIndex = 8;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "SELECT_NV";
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 177);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(944, 183);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMãNhânViên,
            this.colHọTên,
            this.colNgàySinh,
            this.colĐịaChỉ,
            this.colSốĐiệnThoại,
            this.colTênBộPhận,
            this.colTênChứcVụ,
            this.colBằngCấp});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click_1);
            // 
            // colMãNhânViên
            // 
            this.colMãNhânViên.FieldName = "Mã Nhân Viên";
            this.colMãNhânViên.Name = "colMãNhânViên";
            this.colMãNhânViên.Visible = true;
            this.colMãNhânViên.VisibleIndex = 0;
            // 
            // colHọTên
            // 
            this.colHọTên.FieldName = "Họ Tên";
            this.colHọTên.Name = "colHọTên";
            this.colHọTên.Visible = true;
            this.colHọTên.VisibleIndex = 1;
            // 
            // colNgàySinh
            // 
            this.colNgàySinh.FieldName = "Ngày Sinh";
            this.colNgàySinh.Name = "colNgàySinh";
            this.colNgàySinh.Visible = true;
            this.colNgàySinh.VisibleIndex = 2;
            // 
            // colĐịaChỉ
            // 
            this.colĐịaChỉ.FieldName = "Địa Chỉ";
            this.colĐịaChỉ.Name = "colĐịaChỉ";
            this.colĐịaChỉ.Visible = true;
            this.colĐịaChỉ.VisibleIndex = 3;
            // 
            // colSốĐiệnThoại
            // 
            this.colSốĐiệnThoại.FieldName = "Số Điện Thoại";
            this.colSốĐiệnThoại.Name = "colSốĐiệnThoại";
            this.colSốĐiệnThoại.Visible = true;
            this.colSốĐiệnThoại.VisibleIndex = 4;
            // 
            // colTênBộPhận
            // 
            this.colTênBộPhận.FieldName = "Tên Bộ Phận";
            this.colTênBộPhận.Name = "colTênBộPhận";
            this.colTênBộPhận.Visible = true;
            this.colTênBộPhận.VisibleIndex = 5;
            // 
            // colTênChứcVụ
            // 
            this.colTênChứcVụ.FieldName = "Tên Chức Vụ";
            this.colTênChứcVụ.Name = "colTênChứcVụ";
            this.colTênChứcVụ.Visible = true;
            this.colTênChứcVụ.VisibleIndex = 6;
            // 
            // colBằngCấp
            // 
            this.colBằngCấp.FieldName = "Bằng Cấp";
            this.colBằngCấp.Name = "colBằngCấp";
            this.colBằngCấp.Visible = true;
            this.colBằngCấp.VisibleIndex = 7;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_LibraryManagement_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // frmStaff
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(layoutControl1);
            this.Name = "frmStaff";
            this.Size = new System.Drawing.Size(944, 360);
            this.Load += new System.EventHandler(this.frmLibrarian_Load);
            ((System.ComponentModel.ISupportInitialize)(layoutControl1)).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Level.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Birth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_Birth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BangCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_NS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_TenTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_DC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_SDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci_CV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txt_Level;
        private DevExpress.XtraEditors.TextEdit txt_Phone;
        private DevExpress.XtraEditors.TextEdit txt_Address;
        private DevExpress.XtraEditors.TextEdit txt_Name;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.DateEdit dtp_Birth;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lci_NS;
        private DevExpress.XtraLayout.LayoutControlItem lci_TenTT;
        private DevExpress.XtraLayout.LayoutControlItem lci_DC;
        private DevExpress.XtraLayout.LayoutControlItem lci_SDT;
        private DevExpress.XtraLayout.LayoutControlItem lci_CV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btn_Insert;
        private DevExpress.XtraEditors.SimpleButton btn_Update;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private System.Windows.Forms.TextBox txt_Search;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMãNhânViên;
        private DevExpress.XtraGrid.Columns.GridColumn colHọTên;
        private DevExpress.XtraGrid.Columns.GridColumn colNgàySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colĐịaChỉ;
        private DevExpress.XtraGrid.Columns.GridColumn colSốĐiệnThoại;
        private DevExpress.XtraGrid.Columns.GridColumn colTênBộPhận;
        private DevExpress.XtraGrid.Columns.GridColumn colTênChứcVụ;
        private DevExpress.XtraEditors.TextEdit txt_Department;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colBằngCấp;
        private DevExpress.XtraEditors.TextEdit txt_BangCap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
