namespace EmployeeManagementSystem.Controls
{
    partial class DepartmentInfoUC
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
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btn_DeletePosition = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstVw_Education
            // 
            this.LstVw_Education.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstVw_Education.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name});
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
            // Id
            // 
            this.Id.Text = "Position ID";
            this.Id.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Position Name";
            this.Name.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.btn_DeletePosition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 372);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2269, 138);
            this.panel1.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.add;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(8, 50);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(133, 81);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // btn_DeletePosition
            // 
            this.btn_DeletePosition.BackgroundImage = global::EmployeeManagementSystem.Properties.Resources.delete;
            this.btn_DeletePosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_DeletePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeletePosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_DeletePosition.Location = new System.Drawing.Point(143, 50);
            this.btn_DeletePosition.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_DeletePosition.Name = "btn_DeletePosition";
            this.btn_DeletePosition.Size = new System.Drawing.Size(97, 81);
            this.btn_DeletePosition.TabIndex = 2;
            this.btn_DeletePosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DeletePosition.UseVisualStyleBackColor = true;
            this.btn_DeletePosition.Click += new System.EventHandler(this.btn_DeletePosition_Click);
            // 
            // DepartmentInfoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LstVw_Education);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(2269, 510);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstVw_Education;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DeletePosition;
        private System.Windows.Forms.Button buttonAdd;
    }
}
