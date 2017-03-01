namespace StudentManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_Home = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btn_AddClass = new DevExpress.XtraBars.BarButtonItem();
            this.btn_CreateReport = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ChangeRules = new DevExpress.XtraBars.BarButtonItem();
            this.btn_FindStudent = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btn_Done = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.rib_Control = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorPickEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemColorPickEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Student = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_Class = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.btn_ScoreBoard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.rib_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Home, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_AddStudent, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_AddClass);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_CreateReport);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ChangeRules);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_FindStudent);
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Done, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // btn_Home
            // 
            this.btn_Home.Caption = "Home";
            this.btn_Home.Id = 18;
            this.btn_Home.ImageUri.Uri = "Home";
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Home_ItemClick);
            // 
            // btn_AddStudent
            // 
            this.btn_AddStudent.Caption = "Add Student";
            this.btn_AddStudent.Id = 5;
            this.btn_AddStudent.LargeGlyph = global::StudentManagement.Properties.Resources.IconAddStudent;
            this.btn_AddStudent.Name = "btn_AddStudent";
            this.btn_AddStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddStudent_ItemClick);
            // 
            // btn_AddClass
            // 
            this.btn_AddClass.Caption = "Add Class";
            this.btn_AddClass.Id = 6;
            this.btn_AddClass.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_AddClass.LargeGlyph")));
            this.btn_AddClass.Name = "btn_AddClass";
            this.btn_AddClass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_AddClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AddClass_ItemClick);
            // 
            // btn_CreateReport
            // 
            this.btn_CreateReport.Caption = "Create_Report";
            this.btn_CreateReport.Id = 10;
            this.btn_CreateReport.LargeGlyph = global::StudentManagement.Properties.Resources.report1;
            this.btn_CreateReport.Name = "btn_CreateReport";
            // 
            // btn_ChangeRules
            // 
            this.btn_ChangeRules.Caption = "Change_Rules";
            this.btn_ChangeRules.Id = 15;
            this.btn_ChangeRules.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_ChangeRules.LargeGlyph")));
            this.btn_ChangeRules.Name = "btn_ChangeRules";
            // 
            // btn_FindStudent
            // 
            this.btn_FindStudent.Caption = "Find Student";
            this.btn_FindStudent.Glyph = global::StudentManagement.Properties.Resources.findStudentIcon;
            this.btn_FindStudent.Id = 23;
            this.btn_FindStudent.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_FindStudent.LargeGlyph")));
            this.btn_FindStudent.Name = "btn_FindStudent";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            // 
            // 
            // 
            this.skinRibbonGalleryBarItem1.Gallery.FirstItemVertIndent = 2;
            this.skinRibbonGalleryBarItem1.Id = 19;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.RememberLastCommand = true;
            this.skinRibbonGalleryBarItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btn_Done
            // 
            this.btn_Done.Caption = "Done";
            this.btn_Done.Id = 20;
            this.btn_Done.ImageUri.Uri = "Apply";
            this.btn_Done.Name = "btn_Done";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Back";
            this.barSubItem1.Id = 2;
            this.barSubItem1.ImageUri.Uri = "Backward";
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Add Student";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Create Report";
            this.barButtonItem9.Id = 12;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Look ScoreBoard";
            this.barButtonItem10.Id = 13;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Add Class";
            this.barButtonItem8.Id = 11;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.ActAsDropDown = true;
            this.barButtonItem6.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem6.Caption = "Create Report";
            this.barButtonItem6.Id = 9;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.ActAsDropDown = true;
            this.barButtonItem4.Caption = "Create Report";
            this.barButtonItem4.Id = 7;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "AddStudent";
            this.barStaticItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.Glyph")));
            this.barStaticItem1.GlyphDisabled = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.GlyphDisabled")));
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.ImageUri.Uri = "AddNewDataSource";
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // rib_Control
            // 
            this.rib_Control.AllowMinimizeRibbon = false;
            this.rib_Control.AutoSizeItems = true;
            this.rib_Control.CausesValidation = false;
            this.rib_Control.ExpandCollapseItem.Id = 0;
            this.rib_Control.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rib_Control.ExpandCollapseItem,
            this.barSubItem1,
            this.barStaticItem1,
            this.barButtonItem1,
            this.btn_AddStudent,
            this.btn_AddClass,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.btn_CreateReport,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.btn_ChangeRules,
            this.barWorkspaceMenuItem1,
            this.btn_Home,
            this.skinRibbonGalleryBarItem1,
            this.btn_Done,
            this.barEditItem1,
            this.barEditItem2,
            this.btn_FindStudent});
            this.rib_Control.Location = new System.Drawing.Point(0, 0);
            this.rib_Control.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rib_Control.MaxItemId = 24;
            this.rib_Control.Name = "rib_Control";
            this.rib_Control.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Left;
            this.rib_Control.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.rib_Control.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemColorPickEdit1,
            this.repositoryItemColorPickEdit2});
            this.rib_Control.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.rib_Control.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.rib_Control.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.rib_Control.ShowToolbarCustomizeItem = false;
            this.rib_Control.Size = new System.Drawing.Size(1471, 152);
            this.rib_Control.Toolbar.ShowCustomizeItem = false;
            this.rib_Control.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ActAsDropDown = true;
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 8;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "barButtonItem11";
            this.barButtonItem11.Id = 14;
            this.barButtonItem11.Name = "barButtonItem11";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 16;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemColorPickEdit1;
            this.barEditItem1.Id = 21;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemColorPickEdit1
            // 
            this.repositoryItemColorPickEdit1.AutoHeight = false;
            this.repositoryItemColorPickEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit1.Name = "repositoryItemColorPickEdit1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Caption = "barEditItem2";
            this.barEditItem2.Edit = this.repositoryItemColorPickEdit2;
            this.barEditItem2.Id = 22;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemColorPickEdit2
            // 
            this.repositoryItemColorPickEdit2.AutoHeight = false;
            this.repositoryItemColorPickEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemColorPickEdit2.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemColorPickEdit2.ColorAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemColorPickEdit2.Name = "repositoryItemColorPickEdit2";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple;
            this.accordionControl1.Location = new System.Drawing.Point(3, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.ShowGroupExpandButtons = false;
            this.accordionControl1.Size = new System.Drawing.Size(237, 699);
            this.accordionControl1.StyleController = this.layoutControl1;
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Disabled.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Hovered.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Normal.Options.UseFont = true;
            this.accordionControlElement1.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControlElement1.Appearance.Pressed.Options.UseFont = true;
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.btn_Student,
            this.btn_Class,
            this.btn_ScoreBoard});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Left),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Actions";
            // 
            // btn_Student
            // 
            this.btn_Student.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Appearance.Disabled.Options.UseFont = true;
            this.btn_Student.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Appearance.Hovered.Options.UseFont = true;
            this.btn_Student.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Appearance.Normal.Options.UseFont = true;
            this.btn_Student.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student.Appearance.Pressed.Options.UseFont = true;
            this.btn_Student.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)});
            this.btn_Student.Name = "btn_Student";
            this.btn_Student.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Student.Text = "Student";
            this.btn_Student.Click += new System.EventHandler(this.btn_Student_Click);
            // 
            // btn_Class
            // 
            this.btn_Class.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class.Appearance.Disabled.Options.UseFont = true;
            this.btn_Class.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class.Appearance.Hovered.Options.UseFont = true;
            this.btn_Class.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class.Appearance.Normal.Options.UseFont = true;
            this.btn_Class.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Class.Appearance.Pressed.Options.UseFont = true;
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_Class.Text = "Class";
            this.btn_Class.Click += new System.EventHandler(this.btn_Class_Click);
            // 
            // btn_ScoreBoard
            // 
            this.btn_ScoreBoard.Appearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Appearance.Disabled.Options.UseFont = true;
            this.btn_ScoreBoard.Appearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Appearance.Hovered.Options.UseFont = true;
            this.btn_ScoreBoard.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Appearance.Normal.Options.UseFont = true;
            this.btn_ScoreBoard.Appearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreBoard.Appearance.Pressed.Options.UseFont = true;
            this.btn_ScoreBoard.Name = "btn_ScoreBoard";
            this.btn_ScoreBoard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.btn_ScoreBoard.Text = "ScoreBoard";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.accordionControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.layoutControl1.Location = new System.Drawing.Point(0, 152);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(243, 705);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 4;
            this.layoutControlGroup1.Size = new System.Drawing.Size(243, 705);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.accordionControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(243, 705);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Form1
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 857);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.rib_Control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Ribbon = this.rib_Control;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            ((System.ComponentModel.ISupportInitialize)(this.rib_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemColorPickEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_AddStudent;
        private DevExpress.XtraBars.BarButtonItem btn_AddClass;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btn_CreateReport;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem btn_ChangeRules;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraBars.BarButtonItem btn_Home;
        protected DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Student;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_Class;
        private DevExpress.XtraBars.Navigation.AccordionControlElement btn_ScoreBoard;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl rib_Control;
        private DevExpress.XtraBars.BarButtonItem btn_Done;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemColorPickEdit repositoryItemColorPickEdit2;
        private DevExpress.XtraBars.BarButtonItem btn_FindStudent;

    }
}

