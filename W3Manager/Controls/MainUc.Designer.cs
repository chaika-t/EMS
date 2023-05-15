namespace EmployeeManagementSystem.Controls
{
    partial class MainUc
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
            this.LstView_General = new System.Windows.Forms.ListView();
            this.IDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LstView_General
            // 
            this.LstView_General.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDHeader,
            this.fNameHeader,
            this.lNameHeader,
            this.statusHeader,
            this.Name});
            this.LstView_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstView_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_General.FullRowSelect = true;
            this.LstView_General.GridLines = true;
            this.LstView_General.HideSelection = false;
            this.LstView_General.Location = new System.Drawing.Point(0, 0);
            this.LstView_General.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.LstView_General.MultiSelect = false;
            this.LstView_General.Name = "LstView_General";
            this.LstView_General.Size = new System.Drawing.Size(1747, 711);
            this.LstView_General.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.LstView_General.TabIndex = 1;
            this.LstView_General.UseCompatibleStateImageBehavior = false;
            this.LstView_General.View = System.Windows.Forms.View.Details;
            // 
            // IDHeader
            // 
            this.IDHeader.Text = "ID";
            this.IDHeader.Width = 100;
            // 
            // fNameHeader
            // 
            this.fNameHeader.Text = "First Name";
            this.fNameHeader.Width = 200;
            // 
            // lNameHeader
            // 
            this.lNameHeader.Text = "Last Name";
            this.lNameHeader.Width = 200;
            // 
            // statusHeader
            // 
            this.statusHeader.Text = "Type";
            this.statusHeader.Width = 150;
            // 
            // Name
            // 
            this.Name.Text = "Position";
            this.Name.Width = 313;
            // 
            // MainUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.LstView_General);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
          
            this.Size = new System.Drawing.Size(1747, 711);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstView_General;
        private System.Windows.Forms.ColumnHeader IDHeader;
        private System.Windows.Forms.ColumnHeader fNameHeader;
        private System.Windows.Forms.ColumnHeader lNameHeader;
        private System.Windows.Forms.ColumnHeader statusHeader;
        private System.Windows.Forms.ColumnHeader Name;
    }
}
