namespace EmployeeManagementSystem.Controls
{
    partial class EmployeeInfoUC
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
            this.RTBx_Main = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RTBx_Main
            // 
            this.RTBx_Main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RTBx_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBx_Main.Location = new System.Drawing.Point(0, 0);
            this.RTBx_Main.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.RTBx_Main.Name = "RTBx_Main";
            this.RTBx_Main.ReadOnly = true;
            this.RTBx_Main.Size = new System.Drawing.Size(618, 198);
            this.RTBx_Main.TabIndex = 1;
            this.RTBx_Main.Text = "";
            // 
            // EmployeeInfoUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RTBx_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "EmployeeInfoUC";
            this.Size = new System.Drawing.Size(618, 198);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBx_Main;
    }
}
