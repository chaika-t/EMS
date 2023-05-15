namespace EmployeeManagementSystem.Forms
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpBx_Phone = new System.Windows.Forms.GroupBox();
            this.RdoBtn_Intl = new System.Windows.Forms.RadioButton();
            this.RdoBtn_Standard = new System.Windows.Forms.RadioButton();
            this.RdoBtn_Dashes = new System.Windows.Forms.RadioButton();
            this.RdoBtn_Dots = new System.Windows.Forms.RadioButton();
            this.grpBx_Phone.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCancel.Location = new System.Drawing.Point(144, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 32);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSave.Location = new System.Drawing.Point(36, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // grpBx_Phone
            // 
            this.grpBx_Phone.Controls.Add(this.RdoBtn_Intl);
            this.grpBx_Phone.Controls.Add(this.RdoBtn_Standard);
            this.grpBx_Phone.Controls.Add(this.RdoBtn_Dashes);
            this.grpBx_Phone.Controls.Add(this.RdoBtn_Dots);
            this.grpBx_Phone.Location = new System.Drawing.Point(12, 12);
            this.grpBx_Phone.Name = "grpBx_Phone";
            this.grpBx_Phone.Size = new System.Drawing.Size(225, 184);
            this.grpBx_Phone.TabIndex = 0;
            this.grpBx_Phone.TabStop = false;
            this.grpBx_Phone.Text = "Phone Pattern";
            // 
            // RdoBtn_Intl
            // 
            this.RdoBtn_Intl.AutoSize = true;
            this.RdoBtn_Intl.Location = new System.Drawing.Point(18, 159);
            this.RdoBtn_Intl.Name = "RdoBtn_Intl";
            this.RdoBtn_Intl.Size = new System.Drawing.Size(102, 19);
            this.RdoBtn_Intl.TabIndex = 3;
            this.RdoBtn_Intl.Text = "+1.xxxxxxxxxx";
            this.RdoBtn_Intl.UseVisualStyleBackColor = true;
            // 
            // RdoBtn_Standard
            // 
            this.RdoBtn_Standard.AutoSize = true;
            this.RdoBtn_Standard.Location = new System.Drawing.Point(18, 78);
            this.RdoBtn_Standard.Name = "RdoBtn_Standard";
            this.RdoBtn_Standard.Size = new System.Drawing.Size(100, 19);
            this.RdoBtn_Standard.TabIndex = 0;
            this.RdoBtn_Standard.Text = "(xxx) xxx-xxxx";
            this.RdoBtn_Standard.UseVisualStyleBackColor = true;
            // 
            // RdoBtn_Dashes
            // 
            this.RdoBtn_Dashes.AutoSize = true;
            this.RdoBtn_Dashes.Location = new System.Drawing.Point(18, 114);
            this.RdoBtn_Dashes.Name = "RdoBtn_Dashes";
            this.RdoBtn_Dashes.Size = new System.Drawing.Size(93, 19);
            this.RdoBtn_Dashes.TabIndex = 2;
            this.RdoBtn_Dashes.Text = "xxx-xxx-xxxx";
            this.RdoBtn_Dashes.UseVisualStyleBackColor = true;
            // 
            // RdoBtn_Dots
            // 
            this.RdoBtn_Dots.AutoSize = true;
            this.RdoBtn_Dots.Checked = true;
            this.RdoBtn_Dots.Location = new System.Drawing.Point(18, 40);
            this.RdoBtn_Dots.Name = "RdoBtn_Dots";
            this.RdoBtn_Dots.Size = new System.Drawing.Size(91, 19);
            this.RdoBtn_Dots.TabIndex = 1;
            this.RdoBtn_Dots.TabStop = true;
            this.RdoBtn_Dots.Text = "xxx.xxx.xxxx";
            this.RdoBtn_Dots.UseVisualStyleBackColor = true;
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(253, 261);
            this.Controls.Add(this.grpBx_Phone);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Settings";
            this.Text = "Settings";
            this.grpBx_Phone.ResumeLayout(false);
            this.grpBx_Phone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpBx_Phone;
        private System.Windows.Forms.RadioButton RdoBtn_Intl;
        private System.Windows.Forms.RadioButton RdoBtn_Standard;
        private System.Windows.Forms.RadioButton RdoBtn_Dashes;
        private System.Windows.Forms.RadioButton RdoBtn_Dots;
    }
}