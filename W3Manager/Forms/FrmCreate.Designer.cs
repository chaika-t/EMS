namespace EmployeeManagementSystem.Forms
{
    partial class FrmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBx_Last_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBx_First_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBx_Phone = new System.Windows.Forms.TextBox();
            this.TxtBx_City = new System.Windows.Forms.TextBox();
            this.TxtBx_Street = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBx_ID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtBx_Sales = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtBx_Commission = new System.Windows.Forms.TextBox();
            this.TxtBx_Hours = new System.Windows.Forms.TextBox();
            this.TxtBx_Salary = new System.Windows.Forms.TextBox();
            this.TxtBx_Wage = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBx_Status = new System.Windows.Forms.ComboBox();
            this.Btn_Create = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.positinCmbBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBx_Last_Name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtBx_First_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnal Details";
            // 
            // TxtBx_Last_Name
            // 
            this.TxtBx_Last_Name.Location = new System.Drawing.Point(126, 64);
            this.TxtBx_Last_Name.Name = "TxtBx_Last_Name";
            this.TxtBx_Last_Name.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Last_Name.TabIndex = 2;
            this.TxtBx_Last_Name.Leave += new System.EventHandler(this.ValidateLastName);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // TxtBx_First_Name
            // 
            this.TxtBx_First_Name.Location = new System.Drawing.Point(126, 39);
            this.TxtBx_First_Name.Name = "TxtBx_First_Name";
            this.TxtBx_First_Name.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_First_Name.TabIndex = 1;
            this.TxtBx_First_Name.Leave += new System.EventHandler(this.ValidateFirstNameInput);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // TxtBx_Phone
            // 
            this.TxtBx_Phone.Location = new System.Drawing.Point(126, 90);
            this.TxtBx_Phone.Name = "TxtBx_Phone";
            this.TxtBx_Phone.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Phone.TabIndex = 7;
            this.TxtBx_Phone.Leave += new System.EventHandler(this.ValidatePhone);
            this.TxtBx_Phone.MouseHover += new System.EventHandler(this.TxtBxPhoneMouseHover);
            // 
            // TxtBx_City
            // 
            this.TxtBx_City.Location = new System.Drawing.Point(126, 36);
            this.TxtBx_City.Name = "TxtBx_City";
            this.TxtBx_City.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_City.TabIndex = 4;
            // 
            // TxtBx_Street
            // 
            this.TxtBx_Street.Location = new System.Drawing.Point(126, 63);
            this.TxtBx_Street.Name = "TxtBx_Street";
            this.TxtBx_Street.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Street.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 39);
            this.label8.TabIndex = 7;
            this.label8.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Street";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtBx_ID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxtBx_Sales);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.TxtBx_Commission);
            this.groupBox2.Controls.Add(this.TxtBx_Hours);
            this.groupBox2.Controls.Add(this.TxtBx_Salary);
            this.groupBox2.Controls.Add(this.TxtBx_Wage);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CmbBx_Status);
            this.groupBox2.Location = new System.Drawing.Point(368, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Details";
            // 
            // TxtBx_ID
            // 
            this.TxtBx_ID.Enabled = false;
            this.TxtBx_ID.Location = new System.Drawing.Point(132, 69);
            this.TxtBx_ID.Name = "TxtBx_ID";
            this.TxtBx_ID.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_ID.TabIndex = 12;
            this.TxtBx_ID.MouseHover += new System.EventHandler(this.TxtBxIdMouseHover);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(11, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 39);
            this.label14.TabIndex = 17;
            this.label14.Text = "Employee ID";
            // 
            // TxtBx_Sales
            // 
            this.TxtBx_Sales.Enabled = false;
            this.TxtBx_Sales.Location = new System.Drawing.Point(132, 204);
            this.TxtBx_Sales.Name = "TxtBx_Sales";
            this.TxtBx_Sales.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Sales.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 39);
            this.label13.TabIndex = 16;
            this.label13.Text = "Gross Sales";
            // 
            // TxtBx_Commission
            // 
            this.TxtBx_Commission.Enabled = false;
            this.TxtBx_Commission.Location = new System.Drawing.Point(132, 177);
            this.TxtBx_Commission.Name = "TxtBx_Commission";
            this.TxtBx_Commission.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Commission.TabIndex = 10;
            // 
            // TxtBx_Hours
            // 
            this.TxtBx_Hours.Enabled = false;
            this.TxtBx_Hours.Location = new System.Drawing.Point(132, 150);
            this.TxtBx_Hours.Name = "TxtBx_Hours";
            this.TxtBx_Hours.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Hours.TabIndex = 10;
            // 
            // TxtBx_Salary
            // 
            this.TxtBx_Salary.Enabled = false;
            this.TxtBx_Salary.Location = new System.Drawing.Point(132, 123);
            this.TxtBx_Salary.Name = "TxtBx_Salary";
            this.TxtBx_Salary.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Salary.TabIndex = 9;
            // 
            // TxtBx_Wage
            // 
            this.TxtBx_Wage.Enabled = false;
            this.TxtBx_Wage.Location = new System.Drawing.Point(132, 96);
            this.TxtBx_Wage.Name = "TxtBx_Wage";
            this.TxtBx_Wage.Size = new System.Drawing.Size(182, 41);
            this.TxtBx_Wage.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(286, 39);
            this.label12.TabIndex = 12;
            this.label12.Text = "Commission Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 39);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hours";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 39);
            this.label10.TabIndex = 10;
            this.label10.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 39);
            this.label9.TabIndex = 9;
            this.label9.Text = "Wage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status";
            // 
            // CmbBx_Status
            // 
            this.CmbBx_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CmbBx_Status.FormattingEnabled = true;
            this.CmbBx_Status.Items.AddRange(new object[] {
            "CONTRACT",
            "HOURLY",
            "SALARY",
            "SALES"});
            this.CmbBx_Status.Location = new System.Drawing.Point(132, 39);
            this.CmbBx_Status.Name = "CmbBx_Status";
            this.CmbBx_Status.Size = new System.Drawing.Size(182, 46);
            this.CmbBx_Status.TabIndex = 8;
            this.CmbBx_Status.SelectedIndexChanged += new System.EventHandler(this.CmbBxStatusSelectedIndexChanged);
            // 
            // Btn_Create
            // 
            this.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Create.Location = new System.Drawing.Point(454, 287);
            this.Btn_Create.Name = "Btn_Create";
            this.Btn_Create.Size = new System.Drawing.Size(105, 35);
            this.Btn_Create.TabIndex = 2;
            this.Btn_Create.Text = "Create";
            this.Btn_Create.UseVisualStyleBackColor = true;
            this.Btn_Create.Click += new System.EventHandler(this.BtnCreateClick);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Btn_Cancel.Location = new System.Drawing.Point(577, 287);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(105, 35);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // errProvider
            // 
            this.errProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errProvider.ContainerControl = this;
            this.errProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errProvider.Icon")));
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtBx_Phone);
            this.groupBox3.Controls.Add(this.TxtBx_City);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtBx_Street);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 139);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "Position";
            // 
            // positinCmbBox
            // 
            this.positinCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.positinCmbBox.FormattingEnabled = true;
            this.positinCmbBox.Items.AddRange(new object[] {
            "CONTRACT",
            "HOURLY",
            "SALARY",
            "SALES"});
            this.positinCmbBox.Location = new System.Drawing.Point(138, 274);
            this.positinCmbBox.Name = "positinCmbBox";
            this.positinCmbBox.Size = new System.Drawing.Size(182, 46);
            this.positinCmbBox.TabIndex = 18;
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(722, 333);
            this.Controls.Add(this.positinCmbBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Create);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCreate";
            this.Text = "Create Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Create;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBx_Status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBx_First_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBx_Phone;
        private System.Windows.Forms.TextBox TxtBx_City;
        private System.Windows.Forms.TextBox TxtBx_Street;
        private System.Windows.Forms.TextBox TxtBx_Last_Name;
        private System.Windows.Forms.TextBox TxtBx_Sales;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtBx_Commission;
        private System.Windows.Forms.TextBox TxtBx_Hours;
        private System.Windows.Forms.TextBox TxtBx_Salary;
        private System.Windows.Forms.TextBox TxtBx_Wage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBx_ID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox positinCmbBox;
        private System.Windows.Forms.Label label6;
    }
}