using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Models;
using EmployeeManagementSystem.Forms;
using EmployeeManagementSystem.Properties;
using System;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Controls
{
    public partial class DepartmentUC : UserControl
    {
        private BusinessRules<int, Department> _datafile;
        public event EventHandler<ProcessEventArgs> UCEventHandler;

        public DepartmentUC()
        {
            InitializeComponent();
            LstView_Departments.ItemSelectionChanged += GeneralViewSelectedIndexChanged;
            _datafile = new BusinessRules<int, Department>();
            LoadData();
        }
        /// <summary>
        /// Event handler for when the index in the ListBox is changed, displays object text in <see cref="RTBx_Main"/>
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void GeneralViewSelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem lvi = e.Item;
            if (lvi != null)
            {
                var emp = _datafile.Retrieve(int.Parse(lvi.Text));
                UCEventHandler(this, new ProcessEventArgs(emp));
            }
            else
            {
                UCEventHandler(this, new ProcessEventArgs(null));
            }
        }


        /// <summary>
        /// Shows a new form to allow the addition of a new Employee object
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void AddDepartmentClick(object sender, EventArgs e)
        {
            using (var form = new AddDepartment())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var my = new DepartmentDataBase(form.department);
                        my.AddDepartment();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Resources.ErrorTitle);
                    }
                }
            }
        }

        /// <summary>
        /// Displays the employee details in the creation form to allow modification
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void ModifyDepartmentClick(object sender, EventArgs e)
        {
            if (LstView_Departments.SelectedItems.Count == 0)
            {
                ShowNoRecordsSelectedErrorMessage();
                return;
            }

            int id = int.Parse(LstView_Departments.SelectedItems[0].Text);
            using (var form = new AddDepartment(_datafile.Retrieve(id)))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DepartmentDataBase my = new DepartmentDataBase(form.department);
                    my.AddDepartment();
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Allows the user to remove an entry from the viewer, doesn't actually delete the record.
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void RemoveDepartmentClick(object sender, EventArgs e)
        {
            if (LstView_Departments.SelectedIndices.Count == 0)
            {
                ShowNoRecordsSelectedErrorMessage();
            }
            else
            {
                if (MessageBox.Show(
                        Resources.ConfirmActionMessage,
                        Resources.ConfirmActionTitle,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    uint id = uint.Parse(LstView_Departments.SelectedItems[0].Text);
                    var employeeClass = new DepartmentDataBase();
                    employeeClass.RemoveDepartment(id);
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Displays each Employee in the data file     
        private void DisplayDatabase()
        {
            if (LstView_Departments.Items.Count > 0)
            {
                LstView_Departments.Items.Clear();
            }

            LstView_Departments.BeginUpdate();
            foreach (var emp in _datafile.Database.Values)
            {
                AddItem(emp);
            }

            LstView_Departments.EndUpdate();
        }
        /// <summary>
        /// Adds a new Employee object to the ListBox by creating a ListViewItem
        /// </summary>
        /// <param name="emp">Employee object to add to the ListBox</param>
        private void AddItem(Department emp)
        {
            // Check for null emp
            if (emp == null)
            {
                throw new ArgumentNullException(Resources.InvalidEmployeeObjectError);
            }

            // Create a ListViewItem
            var lvi = new ListViewItem($"{emp.Id}");
            lvi.SubItems.Add($"{emp.Name}");
            lvi.SubItems.Add($"{emp.Positions.Count}");
            lvi.SubItems.Add($"{emp.AnnualSalary}");
            lvi.SubItems.Add($"{emp.MonthlySalary}");

            LstView_Departments.Items.Add(lvi);
        }


        internal void LoadData()
        {
            var dep = new DepartmentDataBase();
            _datafile.Database = dep.GetDepartments();
            DisplayDatabase();
        }

        private void ShowNoRecordsSelectedErrorMessage()
        {
            MessageBox.Show(
                   Resources.NoRecordsSelectedError,
                   Resources.ErrorTitle,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }
    }
}
