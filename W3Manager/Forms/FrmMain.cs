using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Forms
{
    /// <summary>
    /// Represents the main form in the application
    /// </summary>
    /// <seealso cref="Common.Controllers.BusinessRules{TKey, TValue}"/>
    /// <seealso cref="Employee"/>
    /// <seealso cref="FrmAddCourse"/>W   
    /// <seealso cref="FrmCreate"/>
    /// <seealso cref="FrmSettings"/>
    public partial class FrmMain : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FrmMain"/> class
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            mainUC.UCEventHandler += MainUC_EventHandler;
            departmentUC1.UCEventHandler += MainUC_EventHandler;
            addToolStripMenuItem.Click += mainUC.AddEmployeeClick;
            Btn_AddEmp.Click += mainUC.AddEmployeeClick;
            addEmployeeToolStripMenuItem.Click += mainUC.AddEmployeeClick;
            Btn_EditEmp.Click += mainUC.ModifyEmployeeInfoClick;
            modifyInformationToolStripMenuItem.Click += mainUC.ModifyEmployeeInfoClick;
            modifyToolStripMenuItem.Click += mainUC.ModifyEmployeeInfoClick;
            removeToolStripMenuItem.Click += mainUC.RemoveEmployeeClick;
            removeEmployeeToolStripMenuItem.Click += mainUC.RemoveEmployeeClick;
            removeBtn.Click += mainUC.RemoveEmployeeClick;
            addCourseBtn.Click += educationsUC.AddCourseClick;
            modifyCourseBtn.Click += educationsUC.ModifyCourseClick;

            Btn_AddDepartment.Click += departmentUC1.AddDepartmentClick;
            Btn_EditDepartment.Click += departmentUC1.ModifyDepartmentClick;
            btn_DeleteDeprtment.Click += departmentUC1.RemoveDepartmentClick;
        }

        private void MainUC_EventHandler(object sender, ProcessEventArgs e)
        {
            if (e.Argument is Employee emp)
            {
                employeeInfoUC.Show(emp);
                educationsUC.Show(emp.Id);
            }
            else
            {
                employeeInfoUC.Clear();
                educationsUC.Clear();
            }

            if (e.Argument is Department dep)
            {
                departmentInfoUC1.Show(dep.Id);
            }

        }

        /// <summary>
        /// Exits the W3 Manager Application
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {           
            Application.Exit();
        }


        /// <summary>
        /// Displays a settings dialog allowing the user to modify a few AppSettings options
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void SettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            FrmSettings settingsDialog = new FrmSettings();
            settingsDialog.ShowDialog();
        }
       
    }
}
