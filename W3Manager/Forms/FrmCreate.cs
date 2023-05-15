using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Enumerations;
using EmployeeManagementSystem.Common.Extensions;
using EmployeeManagementSystem.Common.Models;
using EmployeeManagementSystem.Properties;
using EmployeeManagementSystem.ValidationEngine;

namespace EmployeeManagementSystem.Forms
{
    /// <summary>
    /// Represents a form that allows the user to create new employees
    /// </summary>
    /// <seealso cref="FrmMain"/>
    /// <seealso cref="Common.Models.Employee"/>
    /// <seealso cref="Logger"/>
    /// <seealso cref="ValidationEngine"/>
    /// <seealso cref="ValidationPatterns"/>
    public partial class FrmCreate : Form
    {
        private readonly ValidationPatterns patterns;
        private ValidationEngine.ValidationEngine validation;
        private int empId;

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCreate"/> class with the given employee ID
        /// </summary>
        /// <param name="id">Employee ID to be assigned</param>
        public FrmCreate()
        {
            InitializeComponent();          
            patterns = new ValidationPatterns
            {
                NamePattern = Settings.Default.NamePattern,
                PhonePattern = Settings.Default.PhonePattern,
                ZipPattern = Settings.Default.ZipPattern,
                CurrencyPattern = Settings.Default.CurrencyPattern
            };
            errProvider.Icon = Resources.blackX;
            TxtBx_ID.Text = $"{empId:D7}";
            DisplayPositions();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrmCreate"/> class with an Employee object to modify
        /// </summary>
        /// <param name="employee">Employee object to be modified</param>
        public FrmCreate(Employee employee)
        {
            InitializeComponent();
           
            patterns = new ValidationPatterns
            {
                NamePattern = Settings.Default.NamePattern,
                PhonePattern = Settings.Default.PhonePattern,
                ZipPattern = Settings.Default.ZipPattern,
                CurrencyPattern = Settings.Default.CurrencyPattern
            };
            errProvider.Icon = Resources.blackX;
            Employee = employee;
            DisplayPositions();
            empId = Employee.Id;
            
            FillForm();
        }
        
        /// <summary>
        /// Gets the Employee property with private setter
        /// </summary>
        public Employee Employee { get; private set; }

        /// <summary>
        /// Parses the form and instantiates a Person object and an Employee sub-class with provided data
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnCreateClick(object sender, EventArgs e)
        {
            Control[] controls =
            {
                TxtBx_First_Name,
                TxtBx_Last_Name,              
                TxtBx_Phone,
                CmbBx_Status,
                TxtBx_ID
            };

            if (!FormIsFilled(controls))
            {
                return;
            }

            try
            {
                Employee = GetEmployee(GetPerson());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    Resources.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
               
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Sets DialogResult to Cancel and closes the form
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Modifies which employee group text boxes are enabled based on status selection
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void CmbBxStatusSelectedIndexChanged(object sender, EventArgs e)
        {
            DisableAllTextboxes();
            switch (CmbBx_Status.Text)
            {
                case EmployeeTypes.Contract:
                    TxtBx_Wage.Enabled = true;
                    return;
                case EmployeeTypes.Hourly:
                    TxtBx_Wage.Enabled = true;
                    TxtBx_Hours.Enabled = true;
                    return;
                case EmployeeTypes.Salary:
                    TxtBx_Salary.Enabled = true;
                    return;
                case EmployeeTypes.Sales:
                    TxtBx_Salary.Enabled = true;
                    TxtBx_Commission.Enabled = true;
                    TxtBx_Sales.Enabled = true;
                    return;
                default:
                    return;
            }
        }

        /// <summary>
        /// Displays a tooltip with the required pattern for phone input
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void TxtBxPhoneMouseHover(object sender, EventArgs e)
        {
            toolTip.Show(
                Resources.PhoneTooltip.FormatInvariant(Settings.Default.PhonePatternLabel),
                TxtBx_Phone);
        }

        /// <summary>
        /// Displays a tooltip with the required details for the Employee Id
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void TxtBxIdMouseHover(object sender, EventArgs e)
        {
            toolTip.Show(Resources.EmployeeIdTooltip, TxtBx_ID);
        }

        /// <summary>
        /// Checks if the First Name text box is filled with valid data
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidateFirstNameInput(object sender, EventArgs e)
        {
            CheckIfEmpty(TxtBx_First_Name);
            validation = new ValidationEngine.ValidationEngine();
            validation.SetPattern(patterns.NamePattern);
            ValidateInput(TxtBx_First_Name);
        }

        /// <summary>
        /// Checks if the Last Name text box is filled with valid data
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidateLastName(object sender, EventArgs e)
        {
            CheckIfEmpty(TxtBx_Last_Name);
            validation = new ValidationEngine.ValidationEngine();
            validation.SetPattern(patterns.NamePattern);
            ValidateInput(TxtBx_Last_Name);
        }
       
        /// <summary>
        /// Checks if the Phone number text box is filled with valid data
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ValidatePhone(object sender, EventArgs e)
        {
            CheckIfEmpty(TxtBx_Phone);
            validation = new ValidationEngine.ValidationEngine();
            validation.SetPattern(patterns.PhonePattern);
            ValidateInput(TxtBx_Phone);
        }
        
        /// <summary>
        /// Checks if the Control.Text is null or empty and displays an error if so
        /// </summary>
        /// <param name="control">Control to be validated against</param>
        /// <returns>True if the control is empty; otherwise, false</returns>
        private bool CheckIfEmpty(Control control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errProvider.SetError(control, "Invalid input");
                return true;
            }

            errProvider.SetError(control, string.Empty);
            return false;
        }

        /// <summary>
        /// Checks if the Control.Text matches a predefined Regex pattern
        /// </summary>
        /// <param name="control">Control to be validated against</param>
        private void ValidateInput(Control control)
        {
            string error = !validation.Validate(control.Text) ? "Invalid input" : string.Empty;
            errProvider.SetError(control, error);
        }

        /// <summary>
        /// Checks a set of controls to ensure that they are not empty, an error is displayed if they are
        /// </summary>
        /// <param name="controls">Collection of controls that are being validated</param>
        /// <returns>True if the form is filled; otherwise, false</returns>
        private bool FormIsFilled(IEnumerable<Control> controls)
        {
            return controls.Any(control => !CheckIfEmpty(control));
        }

        /// <summary>
        /// Parses and validates field in Person group, creates a new Person object with provided values
        /// </summary>
        /// <returns>Generated Person object</returns>
        private Person GetPerson()
        {          
            return new Person(
                TxtBx_First_Name.Text,
                TxtBx_Last_Name.Text,
                TxtBx_Street.Text,
                TxtBx_City.Text,              
                TxtBx_Phone.Text);
        }

        /// <summary>
        /// Parses and validates fields in Employee group, creates a new Employee sub-class
        /// </summary>
        /// <param name="person">Person object with desired property values</param>
        /// <returns>Generated Employee sub-class with provided values</returns>
        /// <exception cref="System.ArgumentException">Thrown if any of the form inputs required are invalid</exception>
        private Employee GetEmployee(Person person)
        {
            decimal wage, salary;
            if (CheckIfEmpty(TxtBx_ID) || !int.TryParse(TxtBx_ID.Text, out empId))
            {
                MessageBox.Show(Resources.InvalidFormDataError, Resources.ErrorTitle);
                return null;
            }
            decimal hours;
            switch (CmbBx_Status.Text)
            {
                case EmployeeTypes.Contract:
                    if (CheckIfEmpty(TxtBx_Wage) || !decimal.TryParse(TxtBx_Wage.Text, out wage))
                    {
                        throw new ArgumentException(Resources.InvalidFormDataError);
                    }
                    else
                    {
                        return new Contract(person, wage, empId)
                        {
                            position = positinCmbBox.SelectedItem as Position
                        };
                    }

                case EmployeeTypes.Hourly:
                    if (CheckIfEmpty(TxtBx_Wage) || CheckIfEmpty(TxtBx_Hours))
                    {
                        throw new ArgumentException(Resources.FormFieldEmptyError);
                    }
                    else if (!decimal.TryParse(TxtBx_Wage.Text, out wage) ||
                        !decimal.TryParse(TxtBx_Hours.Text, out  hours))
                    {
                        throw new ArgumentException(Resources.InvalidFormDataError);
                    }
                    else
                    {

                        return new Hourly(person, wage, hours, empId)
                        {
                            position = positinCmbBox.SelectedItem as Position
                        };
                    }

                case EmployeeTypes.Salary:
                    if (CheckIfEmpty(TxtBx_Salary) || !decimal.TryParse(TxtBx_Salary.Text, out salary))
                    {
                        throw new ArgumentException(Resources.InvalidFormDataError);
                    }
                    else
                    {
                        return new Salary(person, salary, empId)
                        {
                            position = positinCmbBox.SelectedItem as Position
                        };
                    }

                case EmployeeTypes.Sales:
                    if (CheckIfEmpty(TxtBx_Salary) ||
                        CheckIfEmpty(TxtBx_Commission) ||
                        CheckIfEmpty(TxtBx_Sales))
                    {
                        throw new ArgumentException(Resources.FormFieldEmptyError);
                    }

                    if (!decimal.TryParse(TxtBx_Salary.Text, out salary) ||
                        !decimal.TryParse(TxtBx_Commission.Text, out var commission) ||
                        !decimal.TryParse(TxtBx_Sales.Text, out var sales ))
                    {
                        throw new ArgumentException(Resources.InvalidFormDataError);
                    }
                    else
                    {
                        return new Sales(person, salary, commission, sales, empId)
                        {
                            position = positinCmbBox.SelectedItem as Position
                        };
                    }

                default:
                    throw new ArgumentException(Resources.InvalidEmployeeStatusError);
            }
        }

        /// <summary>
        /// Fills the form with the Employee object's data
        /// </summary>
        private void FillForm()
        {
            if (Employee == null)
            {
                return;
            }

            TxtBx_First_Name.Text = Employee.FirstName;
            TxtBx_Last_Name.Text = Employee.LastName;
            TxtBx_Street.Text = Employee.Street;
            TxtBx_City.Text = Employee.City;           
            TxtBx_Phone.Text = Employee.Phone;
            CmbBx_Status.Text = Employee.Type.ToString();
            TxtBx_ID.Text = $"{Employee.Id:D7}";
            positinCmbBox.SelectedItem = Employee.position;

            FillEmpTypeCompensation();
        }

        /// <summary>
        /// Converts the Employee to a subclass and fills the remaining form
        /// </summary>
        private void FillEmpTypeCompensation()
        {
            // In order to provide the required methods, I converted the Employee object
            // to it's respective subclass based off the EmpType
            // From there I'll fill out the pertinent form fields with the data
            switch (Employee.Type)
            {
                case EmployeeType.Contract:
                    Contract contract = (Contract)Convert.ChangeType(Employee, typeof(Contract));
                    TxtBx_Wage.Enabled = true;
                    TxtBx_Wage.Text = contract.ContractWage.ToString(CultureInfo.CurrentCulture);
                    return;
                case EmployeeType.Hourly:
                    Hourly hourly = (Hourly)Convert.ChangeType(Employee, typeof(Hourly));
                    TxtBx_Wage.Enabled = true;
                    TxtBx_Hours.Enabled = true;
                    TxtBx_Wage.Text = hourly.HourlyRate.ToString(CultureInfo.CurrentCulture);
                    TxtBx_Hours.Text = hourly.Hours.ToString(CultureInfo.CurrentCulture);
                    return;
                case EmployeeType.Salary:
                    Salary salary = (Salary)Convert.ChangeType(Employee, typeof(Salary));
                    TxtBx_Salary.Enabled = true;
                    TxtBx_Salary.Text = salary.MonthlySalary.ToString(CultureInfo.CurrentCulture);
                    return;
                case EmployeeType.Sales:
                    Sales sales = (Sales)Convert.ChangeType(Employee, typeof(Sales));
                    TxtBx_Salary.Enabled = true;
                    TxtBx_Commission.Enabled = true;
                    TxtBx_Sales.Enabled = true;
                    TxtBx_Salary.Text = sales.MonthlySalary.ToString(CultureInfo.CurrentCulture);
                    TxtBx_Commission.Text = sales.SalesCommission.ToString(CultureInfo.CurrentCulture);
                    TxtBx_Sales.Text = sales.GrossSales.ToString(CultureInfo.CurrentCulture);
                    return;
                default:
                    DisableAllTextboxes();
                    return;
            }
        }

        /// <summary>
        /// Disables Employee group textboxes
        /// </summary>
        private void DisableAllTextboxes()
        {
            TxtBx_Wage.Enabled = false;
            TxtBx_Hours.Enabled = false;
            TxtBx_Salary.Enabled = false;
            TxtBx_Commission.Enabled = false;
            TxtBx_Sales.Enabled = false;
        }

        private void DisplayPositions()
        {
            var db = new DataBase();
            positinCmbBox.DisplayMember = "Name";
            positinCmbBox.ValueMember = "Id";
            positinCmbBox.DataSource = db.GetPositions();
        }
    }
}
