namespace EmployeeManagementSystem.Forms
{
    partial class AddPosition
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.positionsCmbBox = new System.Windows.Forms.Label();
            this.grpBx_Details = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBx_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 500;
            // 
            // positionsCmbBox
            // 
            this.positionsCmbBox.AutoSize = true;
            this.positionsCmbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.positionsCmbBox.Location = new System.Drawing.Point(10, 43);
            this.positionsCmbBox.Name = "positionsCmbBox";
            this.positionsCmbBox.Size = new System.Drawing.Size(138, 36);
            this.positionsCmbBox.TabIndex = 3;
            this.positionsCmbBox.Text = "Positions";
            this.positionsCmbBox.Click += new System.EventHandler(this.positionsCmbBox_Click);
            // 
            // grpBx_Details
            // 
            this.grpBx_Details.Controls.Add(this.comboBox1);
            this.grpBx_Details.Controls.Add(this.positionsCmbBox);
            this.grpBx_Details.Location = new System.Drawing.Point(13, 3);
            this.grpBx_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBx_Details.Name = "grpBx_Details";
            this.grpBx_Details.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBx_Details.Size = new System.Drawing.Size(403, 94);
            this.grpBx_Details.TabIndex = 8;
            this.grpBx_Details.TabStop = false;
            this.grpBx_Details.Text = "Position";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 44);
            this.comboBox1.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(212, 114);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(313, 114);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // AddPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(438, 180);
            this.Controls.Add(this.grpBx_Details);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPosition";
            this.Text = "AddPosition";
            this.grpBx_Details.ResumeLayout(false);
            this.grpBx_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label positionsCmbBox;
        private System.Windows.Forms.GroupBox grpBx_Details;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}