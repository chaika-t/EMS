namespace EmployeeManagementSystem.Forms
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
            this.MenuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.Btn_AddEmp = new System.Windows.Forms.ToolStripButton();
            this.Btn_EditEmp = new System.Windows.Forms.ToolStripButton();
            this.removeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addCourseBtn = new System.Windows.Forms.ToolStripButton();
            this.modifyCourseBtn = new System.Windows.Forms.ToolStripButton();
            this.Btn_AddDepartment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Btn_EditDepartment = new System.Windows.Forms.ToolStripButton();
            this.btn_DeleteDeprtment = new System.Windows.Forms.ToolStripButton();
            this.CntxtMnuModify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benefitsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtMnuBenefits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyBenefitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtMnuEmpInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxtMnuEducation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainUC = new EmployeeManagementSystem.Controls.MainUc();
            this.departmentUC1 = new EmployeeManagementSystem.Controls.DepartmentUC();
            this.SpltContainer = new System.Windows.Forms.SplitContainer();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.employeeInfoUC = new EmployeeManagementSystem.Controls.EmployeeInfoUC();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.educationsUC = new EmployeeManagementSystem.Controls.EducationsUC();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.StatusStripMain = new System.Windows.Forms.StatusStrip();
            this.departmentInfoUC1 = new EmployeeManagementSystem.Controls.DepartmentInfoUC();
            this.MenuStripMain.SuspendLayout();
            this.ToolStripMain.SuspendLayout();
            this.CntxtMnuModify.SuspendLayout();
            this.CntxtMnuBenefits.SuspendLayout();
            this.CntxtMnuEmpInfo.SuspendLayout();
            this.CntxtMnuEducation.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpltContainer)).BeginInit();
            this.SpltContainer.Panel1.SuspendLayout();
            this.SpltContainer.Panel2.SuspendLayout();
            this.SpltContainer.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripMain
            // 
            this.MenuStripMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MenuStripMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuStripMain.ImageScalingSize = new System.Drawing.Size(44, 44);
            this.MenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStripMain.Location = new System.Drawing.Point(0, 0);
            this.MenuStripMain.Name = "MenuStripMain";
            this.MenuStripMain.Size = new System.Drawing.Size(2205, 49);
            this.MenuStripMain.TabIndex = 0;
            this.MenuStripMain.Text = "MenuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 45);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(239, 46);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // setingsToolStripMenuItem
            // 
            this.setingsToolStripMenuItem.Name = "setingsToolStripMenuItem";
            this.setingsToolStripMenuItem.Size = new System.Drawing.Size(229, 46);
            this.setingsToolStripMenuItem.Text = "Setings";
            this.setingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 46);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMain.ImageScalingSize = new System.Drawing.Size(44, 44);
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_AddEmp,
            this.Btn_EditEmp,
            this.removeBtn,
            this.toolStripSeparator1,
            this.addCourseBtn,
            this.modifyCourseBtn,
            this.Btn_AddDepartment,
            this.toolStripSeparator2,
            this.Btn_EditDepartment,
            this.btn_DeleteDeprtment});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 49);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStripMain.Size = new System.Drawing.Size(2205, 51);
            this.ToolStripMain.Stretch = true;
            this.ToolStripMain.TabIndex = 6;
            this.ToolStripMain.Text = "ToolStripMain";
            // 
            // Btn_AddEmp
            // 
            this.Btn_AddEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_AddEmp.Image = global::EmployeeManagementSystem.Properties.Resources.Male_user_add_icon;
            this.Btn_AddEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_AddEmp.Name = "Btn_AddEmp";
            this.Btn_AddEmp.Size = new System.Drawing.Size(48, 48);
            this.Btn_AddEmp.Text = "Add Employee";
            // 
            // Btn_EditEmp
            // 
            this.Btn_EditEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_EditEmp.Image = global::EmployeeManagementSystem.Properties.Resources.Male_user_edit_icon1;
            this.Btn_EditEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_EditEmp.Name = "Btn_EditEmp";
            this.Btn_EditEmp.Size = new System.Drawing.Size(48, 48);
            this.Btn_EditEmp.Text = "Add Employee";
            // 
            // removeBtn
            // 
            this.removeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeBtn.Image = global::EmployeeManagementSystem.Properties.Resources.Male_user_deleteicon;
            this.removeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(48, 48);
            this.removeBtn.Text = "Remove Employee";
            this.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCourseBtn.Image = ((System.Drawing.Image)(resources.GetObject("addCourseBtn.Image")));
            this.addCourseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(48, 48);
            this.addCourseBtn.Text = "Add Course";
            // 
            // modifyCourseBtn
            // 
            this.modifyCourseBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.modifyCourseBtn.Image = global::EmployeeManagementSystem.Properties.Resources.edit_png_icon_blue_pencil_18;
            this.modifyCourseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.modifyCourseBtn.Name = "modifyCourseBtn";
            this.modifyCourseBtn.Size = new System.Drawing.Size(48, 48);
            this.modifyCourseBtn.Text = "Modify Course";
            // 
            // Btn_AddDepartment
            // 
            this.Btn_AddDepartment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_AddDepartment.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddDepartment.Image")));
            this.Btn_AddDepartment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_AddDepartment.Name = "Btn_AddDepartment";
            this.Btn_AddDepartment.Size = new System.Drawing.Size(48, 48);
            this.Btn_AddDepartment.Text = "Add Department";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // Btn_EditDepartment
            // 
            this.Btn_EditDepartment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btn_EditDepartment.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EditDepartment.Image")));
            this.Btn_EditDepartment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_EditDepartment.Name = "Btn_EditDepartment";
            this.Btn_EditDepartment.Size = new System.Drawing.Size(48, 48);
            this.Btn_EditDepartment.Text = "Edit Dep";
            // 
            // btn_DeleteDeprtment
            // 
            this.btn_DeleteDeprtment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_DeleteDeprtment.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteDeprtment.Image")));
            this.btn_DeleteDeprtment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_DeleteDeprtment.Name = "btn_DeleteDeprtment";
            this.btn_DeleteDeprtment.Size = new System.Drawing.Size(48, 48);
            this.btn_DeleteDeprtment.Text = "toolStripButton3";
            // 
            // CntxtMnuModify
            // 
            this.CntxtMnuModify.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntxtMnuModify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.modifyToolStripMenuItem1,
            this.removeEmployeeToolStripMenuItem});
            this.CntxtMnuModify.Name = "CntxtMnuModify";
            this.CntxtMnuModify.Size = new System.Drawing.Size(204, 142);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(203, 46);
            this.addEmployeeToolStripMenuItem.Text = "Add";
            // 
            // modifyToolStripMenuItem1
            // 
            this.modifyToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDetailsToolStripMenuItem,
            this.benefitsToolStripMenuItem1});
            this.modifyToolStripMenuItem1.Name = "modifyToolStripMenuItem1";
            this.modifyToolStripMenuItem1.Size = new System.Drawing.Size(203, 46);
            this.modifyToolStripMenuItem1.Text = "Modify";
            // 
            // personalDetailsToolStripMenuItem
            // 
            this.personalDetailsToolStripMenuItem.Name = "personalDetailsToolStripMenuItem";
            this.personalDetailsToolStripMenuItem.Size = new System.Drawing.Size(323, 46);
            this.personalDetailsToolStripMenuItem.Text = "Employee Info";
            // 
            // benefitsToolStripMenuItem1
            // 
            this.benefitsToolStripMenuItem1.Name = "benefitsToolStripMenuItem1";
            this.benefitsToolStripMenuItem1.Size = new System.Drawing.Size(323, 46);
            this.benefitsToolStripMenuItem1.Text = "Benefits";
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(203, 46);
            this.removeEmployeeToolStripMenuItem.Text = "Remove";
            // 
            // CntxtMnuBenefits
            // 
            this.CntxtMnuBenefits.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntxtMnuBenefits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyBenefitsToolStripMenuItem});
            this.CntxtMnuBenefits.Name = "contextMenuStrip1";
            this.CntxtMnuBenefits.Size = new System.Drawing.Size(304, 50);
            // 
            // modifyBenefitsToolStripMenuItem
            // 
            this.modifyBenefitsToolStripMenuItem.Name = "modifyBenefitsToolStripMenuItem";
            this.modifyBenefitsToolStripMenuItem.Size = new System.Drawing.Size(303, 46);
            this.modifyBenefitsToolStripMenuItem.Text = "Modify Benefits";
            // 
            // CntxtMnuEmpInfo
            // 
            this.CntxtMnuEmpInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntxtMnuEmpInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyInformationToolStripMenuItem});
            this.CntxtMnuEmpInfo.Name = "CntxtMnuEmpInfo";
            this.CntxtMnuEmpInfo.Size = new System.Drawing.Size(354, 50);
            // 
            // modifyInformationToolStripMenuItem
            // 
            this.modifyInformationToolStripMenuItem.Name = "modifyInformationToolStripMenuItem";
            this.modifyInformationToolStripMenuItem.Size = new System.Drawing.Size(353, 46);
            this.modifyInformationToolStripMenuItem.Text = "Modify Information";
            // 
            // CntxtMnuEducation
            // 
            this.CntxtMnuEducation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CntxtMnuEducation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.modifyCourseToolStripMenuItem});
            this.CntxtMnuEducation.Name = "contextMenuStrip1";
            this.CntxtMnuEducation.Size = new System.Drawing.Size(292, 96);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(291, 46);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // modifyCourseToolStripMenuItem
            // 
            this.modifyCourseToolStripMenuItem.Name = "modifyCourseToolStripMenuItem";
            this.modifyCourseToolStripMenuItem.Size = new System.Drawing.Size(291, 46);
            this.modifyCourseToolStripMenuItem.Text = "Modify Course";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(3, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2220, 452);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mainUC);
            this.tabPage1.Location = new System.Drawing.Point(10, 57);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2200, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.departmentUC1);
            this.tabPage2.Location = new System.Drawing.Point(10, 57);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2200, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Departments";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mainUC
            // 
            this.mainUC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mainUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUC.Location = new System.Drawing.Point(3, 3);
            this.mainUC.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.mainUC.Name = "mainUC";
            this.mainUC.Size = new System.Drawing.Size(2194, 379);
            this.mainUC.TabIndex = 0;
            // 
            // departmentUC1
            // 
            this.departmentUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.departmentUC1.Location = new System.Drawing.Point(3, 3);
            this.departmentUC1.Name = "departmentUC1";
            this.departmentUC1.Size = new System.Drawing.Size(2194, 379);
            this.departmentUC1.TabIndex = 0;
            // 
            // SpltContainer
            // 
            this.SpltContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpltContainer.Location = new System.Drawing.Point(0, 103);
            this.SpltContainer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SpltContainer.Name = "SpltContainer";
            this.SpltContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SpltContainer.Panel1
            // 
            this.SpltContainer.Panel1.Controls.Add(this.mainPanel);
            this.SpltContainer.Panel1MinSize = 200;
            // 
            // SpltContainer.Panel2
            // 
            this.SpltContainer.Panel2.AllowDrop = true;
            this.SpltContainer.Panel2.AutoScroll = true;
            this.SpltContainer.Panel2.Controls.Add(this.tabControl2);
            this.SpltContainer.Panel2.Controls.Add(this.StatusStripMain);
            this.SpltContainer.Panel2MinSize = 200;
            this.SpltContainer.Size = new System.Drawing.Size(2205, 986);
            this.SpltContainer.SplitterDistance = 463;
            this.SpltContainer.SplitterWidth = 3;
            this.SpltContainer.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(2205, 463);
            this.mainPanel.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tabControl2.Location = new System.Drawing.Point(0, 278);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(2205, 220);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.employeeInfoUC);
            this.tabPage3.Location = new System.Drawing.Point(10, 57);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(2185, 153);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Employee Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // employeeInfoUC
            // 
            this.employeeInfoUC.AutoScroll = true;
            this.employeeInfoUC.BackColor = System.Drawing.Color.White;
            this.employeeInfoUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeInfoUC.Location = new System.Drawing.Point(3, 3);
            this.employeeInfoUC.Margin = new System.Windows.Forms.Padding(4);
            this.employeeInfoUC.Name = "employeeInfoUC";
            this.employeeInfoUC.Size = new System.Drawing.Size(2179, 147);
            this.employeeInfoUC.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.educationsUC);
            this.tabPage7.Location = new System.Drawing.Point(10, 57);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(2185, 153);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Education";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // educationsUC
            // 
            this.educationsUC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.educationsUC.Location = new System.Drawing.Point(3, 3);
            this.educationsUC.Margin = new System.Windows.Forms.Padding(4);
            this.educationsUC.Name = "educationsUC";
            this.educationsUC.Size = new System.Drawing.Size(2179, 147);
            this.educationsUC.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.departmentInfoUC1);
            this.tabPage8.Location = new System.Drawing.Point(10, 57);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(2185, 153);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "Positions";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // StatusStripMain
            // 
            this.StatusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStripMain.Location = new System.Drawing.Point(0, 498);
            this.StatusStripMain.Name = "StatusStripMain";
            this.StatusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.StatusStripMain.Size = new System.Drawing.Size(2205, 22);
            this.StatusStripMain.TabIndex = 5;
            this.StatusStripMain.Text = "StatusStripMain";
            // 
            // departmentInfoUC1
            // 
            this.departmentInfoUC1.AutoScroll = true;
            this.departmentInfoUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentInfoUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.departmentInfoUC1.Location = new System.Drawing.Point(3, 3);
            this.departmentInfoUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departmentInfoUC1.Name = "departmentInfoUC1";
            this.departmentInfoUC1.Size = new System.Drawing.Size(2179, 147);
            this.departmentInfoUC1.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(2205, 1090);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SpltContainer);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.MenuStripMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(890, 534);
            this.Name = "FrmMain";
            this.Text = "Employee Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStripMain.ResumeLayout(false);
            this.MenuStripMain.PerformLayout();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            this.CntxtMnuModify.ResumeLayout(false);
            this.CntxtMnuBenefits.ResumeLayout(false);
            this.CntxtMnuEmpInfo.ResumeLayout(false);
            this.CntxtMnuEducation.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.SpltContainer.Panel1.ResumeLayout(false);
            this.SpltContainer.Panel2.ResumeLayout(false);
            this.SpltContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpltContainer)).EndInit();
            this.SpltContainer.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setingsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.SplitContainer SpltContainer;
        private System.Windows.Forms.StatusStrip StatusStripMain;
        private System.Windows.Forms.ToolStripButton Btn_AddEmp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuModify;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benefitsToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuEmpInfo;
        private System.Windows.Forms.ToolStripMenuItem modifyInformationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuBenefits;
        private System.Windows.Forms.ContextMenuStrip CntxtMnuEducation;
        private System.Windows.Forms.ToolStripMenuItem modifyBenefitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton removeBtn;
        private System.Windows.Forms.ToolStripButton Btn_EditEmp;
        private System.Windows.Forms.Panel mainPanel;
        private Controls.EmployeeInfoUC employeeInfoUC;
        private Controls.EducationsUC educationsUC;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton addCourseBtn;
        private System.Windows.Forms.ToolStripButton modifyCourseBtn;
        private Controls.MainUc mainUC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.DepartmentUC departmentUC1;
        private System.Windows.Forms.ToolStripButton Btn_AddDepartment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Btn_EditDepartment;
        private System.Windows.Forms.ToolStripButton btn_DeleteDeprtment;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private Controls.DepartmentInfoUC departmentInfoUC1;
    }
}

