using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Properties;
using EmployeeManagementSystem.Forms;
using EmployeeManagementSystem.Common.Models;
using EmployeeManagementSystem.Common.Controllers;

namespace EmployeeManagementSystem.Controls
{
    public partial class MainUc : UserControl
    {
     
        private BusinessRules<int, Employee> _datafile;
        public event EventHandler<ProcessEventArgs> UCEventHandler;

        public MainUc()
        {
            InitializeComponent();
            LstView_General.ItemSelectionChanged += new ListViewItemSelectionChangedEventHandler(GeneralViewSelectedIndexChanged);
            _datafile = new BusinessRules<int, Employee>();
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
        public void AddEmployeeClick(object sender, EventArgs e)
        {
            using (var form = new FrmCreate())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var my = new EmployeeDataBase(form.Employee);
                        my.AddEmployee();
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
        public void ModifyEmployeeInfoClick(object sender, EventArgs e)
        {
            if (LstView_General.SelectedItems.Count == 0)
            {
                ShowNoRecordsSelectedErrorMessage();
                return;
            }

            int id = int.Parse(LstView_General.SelectedItems[0].Text);
            using (var form = new FrmCreate(_datafile.Retrieve(id)))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var my = new EmployeeDataBase(form.Employee);
                    my.AddEmployee();
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Allows the user to remove an entry from the viewer, doesn't actually delete the record.
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void RemoveEmployeeClick(object sender, EventArgs e)
        {
            if (LstView_General.SelectedIndices.Count == 0)
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
                    uint id = uint.Parse(LstView_General.SelectedItems[0].Text);
                    var employeeClass = new EmployeeDataBase();
                    employeeClass.RemoveEmployee((int)id);
                    LoadData();
                }
            }
        }

        /// <summary>
        /// Displays each Employee in the data file     
        private void DisplayDatabase()
        {
            if (LstView_General.Items.Count > 0)
            {
                LstView_General.Items.Clear();
            }

            LstView_General.BeginUpdate();
            foreach (var emp in _datafile.Database.Values)
            {
                AddItem(emp);
            }

            LstView_General.EndUpdate();
        }
        /// <summary>
        /// Adds a new Employee object to the ListBox by creating a ListViewItem
        /// </summary>
        /// <param name="emp">Employee object to add to the ListBox</param>
        private void AddItem(Employee emp)
        {
            // Check for null emp
            if (emp == null)
            {
                throw new ArgumentNullException(Resources.InvalidEmployeeObjectError);
            }

            // Create a ListViewItem
            var lvi = new ListViewItem($"{emp.Id}");
            lvi.SubItems.Add($"{emp.FirstName}");
            lvi.SubItems.Add($"{emp.LastName}");
            lvi.SubItems.Add($"{emp.Type}");
            lvi.SubItems.Add($"{emp.position.Name}");

            LstView_General.Items.Add(lvi);
        }


        internal void LoadData()
        {
            var empl = new EmployeeDataBase();
            _datafile.Database = empl.GetEmployees();
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
