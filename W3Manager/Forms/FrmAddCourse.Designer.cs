namespace EmployeeManagementSystem.Forms
{
    partial class FrmAddCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCourse));
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBx_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.grpBx_Details = new System.Windows.Forms.GroupBox();
            this.numeric_Hours = new System.Windows.Forms.NumericUpDown();
            this.txtBx_Descript = new System.Windows.Forms.TextBox();
            this.txtBx_Name = new System.Windows.Forms.TextBox();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.grpBx_Approval_Details = new System.Windows.Forms.GroupBox();
            this.DatePickerApproval = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.chckBx_Approved = new System.Windows.Forms.CheckBox();
            this.lbl_Approved = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.grpBx_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hours)).BeginInit();
            this.grpBx_Approval_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(332, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 30);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(237, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddClick);
            // 
            // txtBx_ID
            // 
            this.txtBx_ID.Location = new System.Drawing.Point(166, 30);
            this.txtBx_ID.Name = "txtBx_ID";
            this.txtBx_ID.Size = new System.Drawing.Size(221, 21);
            this.txtBx_ID.TabIndex = 1;
            this.txtBx_ID.Leave += new System.EventHandler(this.ValidateId);
            this.txtBx_ID.MouseHover += new System.EventHandler(this.IdToolTipShow);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_ID.Location = new System.Drawing.Point(6, 34);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(70, 17);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Course ID";
            // 
            // grpBx_Details
            // 
            this.grpBx_Details.Controls.Add(this.numeric_Hours);
            this.grpBx_Details.Controls.Add(this.txtBx_Descript);
            this.grpBx_Details.Controls.Add(this.txtBx_Name);
            this.grpBx_Details.Controls.Add(this.lbl_Hours);
            this.grpBx_Details.Controls.Add(this.lbl_Description);
            this.grpBx_Details.Controls.Add(this.lbl_Name);
            this.grpBx_Details.Controls.Add(this.txtBx_ID);
            this.grpBx_Details.Controls.Add(this.lbl_ID);
            this.grpBx_Details.Location = new System.Drawing.Point(12, 12);
            this.grpBx_Details.Name = "grpBx_Details";
            this.grpBx_Details.Size = new System.Drawing.Size(403, 218);
            this.grpBx_Details.TabIndex = 4;
            this.grpBx_Details.TabStop = false;
            this.grpBx_Details.Text = "Course Details";
            // 
            // numeric_Hours
            // 
            this.numeric_Hours.Location = new System.Drawing.Point(166, 175);
            this.numeric_Hours.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_Hours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Hours.Name = "numeric_Hours";
            this.numeric_Hours.Size = new System.Drawing.Size(221, 21);
            this.numeric_Hours.TabIndex = 4;
            this.numeric_Hours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBx_Descript
            // 
            this.txtBx_Descript.Location = new System.Drawing.Point(166, 118);
            this.txtBx_Descript.Name = "txtBx_Descript";
            this.txtBx_Descript.Size = new System.Drawing.Size(221, 21);
            this.txtBx_Descript.TabIndex = 3;
            // 
            // txtBx_Name
            // 
            this.txtBx_Name.Location = new System.Drawing.Point(166, 77);
            this.txtBx_Name.Name = "txtBx_Name";
            this.txtBx_Name.Size = new System.Drawing.Size(221, 21);
            this.txtBx_Name.TabIndex = 2;
            this.txtBx_Name.Leave += new System.EventHandler(this.ValidateName);
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.AutoSize = true;
            this.lbl_Hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Hours.Location = new System.Drawing.Point(6, 177);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(87, 17);
            this.lbl_Hours.TabIndex = 6;
            this.lbl_Hours.Text = "Credit Hours";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Description.Location = new System.Drawing.Point(6, 120);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(128, 17);
            this.lbl_Description.TabIndex = 5;
            this.lbl_Description.Text = "Course Description";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Name.Location = new System.Drawing.Point(6, 77);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(94, 17);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "Course Name";
            // 
            // grpBx_Approval_Details
            // 
            this.grpBx_Approval_Details.Controls.Add(this.DatePickerApproval);
            this.grpBx_Approval_Details.Controls.Add(this.lbl_Date);
            this.grpBx_Approval_Details.Controls.Add(this.chckBx_Approved);
            this.grpBx_Approval_Details.Controls.Add(this.lbl_Approved);
            this.grpBx_Approval_Details.Location = new System.Drawing.Point(12, 236);
            this.grpBx_Approval_Details.Name = "grpBx_Approval_Details";
            this.grpBx_Approval_Details.Size = new System.Drawing.Size(403, 143);
            this.grpBx_Approval_Details.TabIndex = 5;
            this.grpBx_Approval_Details.TabStop = false;
            this.grpBx_Approval_Details.Text = "Approval Details";
            // 
            // DatePickerApproval
            // 
            this.DatePickerApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DatePickerApproval.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerApproval.Location = new System.Drawing.Point(166, 79);
            this.DatePickerApproval.Name = "DatePickerApproval";
            this.DatePickerApproval.Size = new System.Drawing.Size(221, 23);
            this.DatePickerApproval.TabIndex = 6;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Date.Location = new System.Drawing.Point(7, 85);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(98, 17);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Approval Date";
            // 
            // chckBx_Approved
            // 
            this.chckBx_Approved.AutoSize = true;
            this.chckBx_Approved.Location = new System.Drawing.Point(166, 41);
            this.chckBx_Approved.Name = "chckBx_Approved";
            this.chckBx_Approved.Size = new System.Drawing.Size(15, 14);
            this.chckBx_Approved.TabIndex = 5;
            this.chckBx_Approved.UseVisualStyleBackColor = true;
            // 
            // lbl_Approved
            // 
            this.lbl_Approved.AutoSize = true;
            this.lbl_Approved.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Approved.Location = new System.Drawing.Point(6, 40);
            this.lbl_Approved.Name = "lbl_Approved";
            this.lbl_Approved.Size = new System.Drawing.Size(69, 17);
            this.lbl_Approved.TabIndex = 0;
            this.lbl_Approved.Text = "Approved";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // FrmAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(427, 435);
            this.Controls.Add(this.grpBx_Approval_Details);
            this.Controls.Add(this.grpBx_Details);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAddCourse";
            this.Text = "Add Course";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.grpBx_Details.ResumeLayout(false);
            this.grpBx_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Hours)).EndInit();
            this.grpBx_Approval_Details.ResumeLayout(false);
            this.grpBx_Approval_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBx_Approval_Details;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.CheckBox chckBx_Approved;
        private System.Windows.Forms.Label lbl_Approved;
        private System.Windows.Forms.GroupBox grpBx_Details;
        private System.Windows.Forms.NumericUpDown numeric_Hours;
        private System.Windows.Forms.TextBox txtBx_Descript;
        private System.Windows.Forms.TextBox txtBx_Name;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtBx_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DateTimePicker DatePickerApproval;
    }
}