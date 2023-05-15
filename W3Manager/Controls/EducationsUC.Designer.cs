namespace EmployeeManagementSystem.Controls
{
    partial class EducationsUC
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
            this.LstVw_Education = new System.Windows.Forms.ListView();
            this.Edu_Clmn_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Clmn_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Clmn_Descript = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Clmn_Credits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Clmn_Approved = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edu_Clmn_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ModifyCourse = new System.Windows.Forms.Button();
            this.btn_Add_Course = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstVw_Education
            // 
            this.LstVw_Education.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVw_Education.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Edu_Clmn_ID,
            this.Edu_Clmn_Name,
            this.Edu_Clmn_Descript,
            this.Edu_Clmn_Credits,
            this.Edu_Clmn_Approved,
            this.Edu_Clmn_Date});
            this.LstVw_Education.FullRowSelect = true;
            this.LstVw_Education.HideSelection = false;
            this.LstVw_Education.Location = new System.Drawing.Point(8, 7);
            this.LstVw_Education.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LstVw_Education.MinimumSize = new System.Drawing.Size(4, 114);
            this.LstVw_Education.MultiSelect = false;
            this.LstVw_Education.Name = "LstVw_Education";
            this.LstVw_Education.Size = new System.Drawing.Size(2247, 345);
            this.LstVw_Education.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LstVw_Education.TabIndex = 3;
            this.LstVw_Education.UseCompatibleStateImageBehavior = false;
            this.LstVw_Education.View = System.Windows.Forms.View.Details;
            // 
            // Edu_Clmn_ID
            // 
            this.Edu_Clmn_ID.Text = "Course ID";
            this.Edu_Clmn_ID.Width = 100;
            // 
            // Edu_Clmn_Name
            // 
            this.Edu_Clmn_Name.Text = "Course Name";
            this.Edu_Clmn_Name.Width = 125;
            // 
            // Edu_Clmn_Descript
            // 
            this.Edu_Clmn_Descript.Text = "Course Description";
            this.Edu_Clmn_Descript.Width = 300;
            // 
            // Edu_Clmn_Credits
            // 
            this.Edu_Clmn_Credits.Text = "Credits";
            this.Edu_Clmn_Credits.Width = 90;
            // 
            // Edu_Clmn_Approved
            // 
            this.Edu_Clmn_Approved.Text = "Approved";
            this.Edu_Clmn_Approved.Width = 90;
            // 
            // Edu_Clmn_Date
            // 
            this.Edu_Clmn_Date.Text = "Approval Date";
            this.Edu_Clmn_Date.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_ModifyCourse);
            this.panel1.Controls.Add(this.btn_Add_Course);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2269, 138);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_ModifyCourse
            // 
            this.btn_ModifyCourse.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.edit_png_icon_blue_pencil_18;
            this.btn_ModifyCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ModifyCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModifyCourse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ModifyCourse.Location = new System.Drawing.Point(157, 26);
            this.btn_ModifyCourse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_ModifyCourse.Name = "btn_ModifyCourse";
            this.btn_ModifyCourse.Size = new System.Drawing.Size(88, 81);
            this.btn_ModifyCourse.TabIndex = 2;
            this.btn_ModifyCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ModifyCourse.UseVisualStyleBackColor = true;
            this.btn_ModifyCourse.Click += new System.EventHandler(this.ModifyCourseClick);
            // 
            // btn_Add_Course
            // 
            this.btn_Add_Course.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Add_Course.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add_Course.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.add_student3;
            this.btn_Add_Course.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add_Course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Add_Course.ForeColor = System.Drawing.Color.White;
            this.btn_Add_Course.Location = new System.Drawing.Point(8, 12);
            this.btn_Add_Course.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Add_Course.Name = "btn_Add_Course";
            this.btn_Add_Course.Size = new System.Drawing.Size(133, 119);
            this.btn_Add_Course.TabIndex = 0;
            this.btn_Add_Course.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add_Course.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add_Course.UseVisualStyleBackColor = true;
            this.btn_Add_Course.Click += new System.EventHandler(this.AddCourseClick);
            // 
            // EducationsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LstVw_Education);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EducationsUC";
            this.Size = new System.Drawing.Size(2269, 510);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstVw_Education;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_ID;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_Name;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_Descript;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_Credits;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_Approved;
        private System.Windows.Forms.ColumnHeader Edu_Clmn_Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ModifyCourse;
        private System.Windows.Forms.Button btn_Add_Course;
    }
}
