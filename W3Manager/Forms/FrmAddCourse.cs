namespace EmployeeManagementSystem.Forms
{
    using System;
    using System.Windows.Forms;
    
    using EmployeeManagementSystem.Common.Models;
    using EmployeeManagementSystem.ValidationEngine;

    /// <summary>
    /// Represents a form to add courses to an employee
    /// </summary>
    /// <seealso cref="FrmMain"/>
    /// <seealso cref="EmployeeBenefits"/>
    /// <seealso cref="ValidationEngine"/>
    /// <seealso cref="ValidationPatterns"/>
    public partial class FrmAddCourse : Form
    {
        private readonly ValidationEngine validation;
        private readonly ValidationPatterns patterns;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmAddCourse"/> class
        /// </summary>
        public FrmAddCourse()
        {
            this.InitializeComponent();
            this.errProvider.Icon = Properties.Resources.blackX;
            this.validation = new ValidationEngine();
            this.patterns = new ValidationPatterns
            {
                NamePattern = Properties.Settings.Default.NamePattern,
                IdPattern = Properties.Settings.Default.CourseIDPattern,
                DatePattern = Properties.Settings.Default.DatePattern
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmAddCourse"/> class with a given Course to update
        /// </summary>
        /// <param name="course">Course to modify</param>
        public FrmAddCourse(Course course)
        {
            this.InitializeComponent();
            this.errProvider.Icon = Properties.Resources.blackX;
            this.validation = new ValidationEngine();
            this.patterns = new ValidationPatterns
            {
                NamePattern = Properties.Settings.Default.NamePattern,
                IdPattern = Properties.Settings.Default.CourseIDPattern,
                DatePattern = Properties.Settings.Default.DatePattern
            };
            this.DisplayCourse(course);
        }

        /// <summary>
        /// Gets or sets the <see cref="EmployeeManagementSystem.Common.Models.Course"/> to be added to an Employee object
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Sets DialogResult to Cancel and closes the form
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Validates that the form is filled and creates a new Course object
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnAddClick(object sender, EventArgs e)
        {
            Control[] controls = { this.txtBx_ID, this.txtBx_Name, this.DatePickerApproval };

            foreach (Control control in controls)
            {
                this.CheckIfEmpty(control);
            }
            
            this.Course = new Course(
                this.txtBx_ID.Text.Trim(),
                decimal.ToInt32(this.numeric_Hours.Value),
                this.txtBx_Name.Text,
                decimal.ToInt32(this.numeric_Hours.Value),
                this.chckBx_Approved.Checked,
                this.DatePickerApproval.Text,
                this.txtBx_Descript.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Shows a tooltip for the Course ID required pattern
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void IdToolTipShow(object sender, EventArgs e)
        {
            this.toolTip.Show(Properties.Resources.CourseIdTooltip, this.txtBx_ID);
        }

        /// <summary>
        /// Shows a tooltip for the Date field pattern
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void DateToolTipShow(object sender, EventArgs e)
        {
            this.toolTip.Show(Properties.Resources.DateTooltip, this.DatePickerApproval);
        }

        /// <summary>
        /// Validates the CourseId against the validation engine
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidateId(object sender, EventArgs e)
        {
            this.CheckIfEmpty(this.txtBx_ID);
            this.validation.SetPattern(this.patterns.IdPattern);
            this.CheckValidation(this.txtBx_ID);
        }

        /// <summary>
        /// Validates the Course Name against the validation engine
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidateName(object sender, EventArgs e)
        {
            this.CheckIfEmpty(this.txtBx_Name);
            this.validation.SetPattern(this.patterns.NamePattern);
            this.CheckValidation(this.txtBx_Name);
        }

        /// <summary>
        /// Validates the Approval date against the validation engine
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidateDate(object sender, EventArgs e)
        {
            this.CheckIfEmpty(this.DatePickerApproval);
            this.validation.SetPattern(this.patterns.DatePattern);
            this.CheckValidation(this.DatePickerApproval);
        }
        
        /// <summary>
        /// Checks if the form field is empty and displays an error if so
        /// </summary>
        /// <param name="control">Form field to be validated</param>
        private void CheckIfEmpty(Control control)
        {
            string error = string.IsNullOrEmpty(control.Text) ? Properties.Resources.FormFieldEmptyError : string.Empty;
            this.errProvider.SetError(control, error);
        }

        /// <summary>
        /// Checks if the form field validates against a pre-set pattern
        /// </summary>
        /// <param name="control">Form field to be validated</param>
        private void CheckValidation(Control control)
        {
            string error = !this.validation.Validate(control.Text)
                               ? Properties.Resources.InvalidFormDataError
                               : string.Empty;
            this.errProvider.SetError(control, error);
        }

        /// <summary>
        /// Sets each member of the Course object to their respective fields on the form
        /// </summary>
        /// <param name="course"><see cref="Common.Models.Course"/> object to be displayed</param>
        private void DisplayCourse(Course course)
        {
            this.txtBx_ID.Text = course.CourseId;
            this.txtBx_ID.Enabled = false;
            this.txtBx_Name.Text = course.CourseName;
            this.txtBx_Descript.Text = course.Description;
            this.numeric_Hours.Value = course.Credits;
            this.chckBx_Approved.Checked = course.Approved;
            this.DatePickerApproval.Text = course.ApprovedDate.ToString();
        }
    }
}
