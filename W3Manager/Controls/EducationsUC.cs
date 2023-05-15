using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Models;
using EmployeeManagementSystem.Forms;
using EmployeeManagementSystem.Properties;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Controls
{
    public partial class EducationsUC : UserControl
    {
        public EducationsUC()
        {
            InitializeComponent();
        }

        public int PersonId { get; set; }

        /// <summary>
        /// Adds a new Course to the ListView by creating a new ListViewItem
        /// </summary>
        /// <param name="course">The new Course to add</param>
        public void AddItem(Course course)
        {
            // Create a ListViewItem
            var lvi = new ListViewItem($"{course.CourseId}");
            lvi.SubItems.Add($"{course.CourseName}");
            lvi.SubItems.Add($"{course.Description}");
            lvi.SubItems.Add($"{course.Credits}");
            lvi.SubItems.Add($"{course.Approved}");
            lvi.SubItems.Add($"{course.ApprovedDate}");

            // Add LVI to LstBx.Items
            LstVw_Education.Items.Add(lvi);
        }
       
        /// <summary>
        /// Calls up the course information allowing the user to modify it. Used with context menu and buttons.
        /// The updated information is added back into the Employee.Benefits.Courses
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void ModifyCourseClick(object sender, EventArgs e)
        {
            if (LstVw_Education.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    Resources.NoRecordsSelectedError,
                    Resources.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            ModifyCourseHandler(
                PersonId,
                LstVw_Education.SelectedItems[0].Text);
        }

        /// <summary>
        /// Adds a new course to the selected Employee
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        public void AddCourseClick(object sender, EventArgs e)
        {
            if (PersonId == 0)
            {
                MessageBox.Show(
                    Resources.NoRecordsSelectedError,
                    Resources.ErrorTitle,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // int id = int.Parse(LstView_General.SelectedItems[0].Text);
            using (var form = new FrmAddCourse())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var course = form.Course;
                    course.PersonId = PersonId;
                    var db = new DataBase();
                    db.AddCourse(course);
                    AddItem(course);
                }
            }
        }


        public void Show(int personId)
        {
            PersonId = personId;
            var db = new DataBase();
            var lst = db.GetCourse(personId);
            LstVw_Education.Items.Clear();
            LstVw_Education.BeginUpdate();
            foreach (var course in lst)
            {
                AddItem(course);
            }

            LstVw_Education.EndUpdate();
        }
        /// <summary>
        /// Gets the selected course reference and instantiates a form to modify the referenced Course object
        /// </summary>
        /// <param name="empId">Employee object ID</param>
        /// <param name="courseId">Course ID of the object to be modified</param>
        public void ModifyCourseHandler(int empId, string courseId)
        {
            DataBase db = new DataBase();
            var lst = db.GetCourse(empId);
            var course = lst.FirstOrDefault(item => item.CourseId == courseId);
            using (var form = new FrmAddCourse(course))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LstVw_Education.SelectedItems[0].Remove(); // !!! update DB
                    AddItem(form.Course);
                    db.UpdateCourse(form.Course);
                }
            }
        }
        public void Clear()
        {
            LstVw_Education.Items.Clear();
        }
    }
}
