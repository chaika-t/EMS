namespace EmployeeManagementSystem.Controls
{
    partial class DepartmentUC
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
            this.LstView_Departments = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnnualSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LstView_Departments
            // 
            this.LstView_Departments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.AnnualSalary});
            this.LstView_Departments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstView_Departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_Departments.FullRowSelect = true;
            this.LstView_Departments.GridLines = true;
            this.LstView_Departments.HideSelection = false;
            this.LstView_Departments.Location = new System.Drawing.Point(0, 0);
            this.LstView_Departments.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.LstView_Departments.MultiSelect = false;
            this.LstView_Departments.Name = "LstView_Departments";
            this.LstView_Departments.Size = new System.Drawing.Size(1014, 292);
            this.LstView_Departments.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LstView_Departments.TabIndex = 2;
            this.LstView_Departments.UseCompatibleStateImageBehavior = false;
            this.LstView_Departments.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 100;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 200;
            // 
            // AnnualSalary
            // 
            this.AnnualSalary.Text = "AnnualSalary";
            this.AnnualSalary.Width = 238;
            // 
            // DepartmentUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LstView_Departments);
           
            this.Size = new System.Drawing.Size(1014, 292);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstView_Departments;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader AnnualSalary;
    }
}
