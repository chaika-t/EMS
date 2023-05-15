using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Models;
using EmployeeManagementSystem.Forms;
using EmployeeManagementSystem.Properties;

namespace EmployeeManagementSystem.Controls
{
    public partial class DepartmentInfoUC : UserControl
    {
        public int PersonId;

        public DepartmentInfoUC()
        {
            InitializeComponent();
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
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
           
            using (var form = new AddPosition(PersonId))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Position position = form.Position;
                    if (position == null) return;

                    position.IdDepartment = PersonId;
                    DataBase db = new DataBase();
                    db.UpdateDepartmentPosition(position);
                    AddItem(position);
                }
            }
        }
        private void btn_DeletePosition_Click(object sender, EventArgs e)
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

            if (MessageBox.Show(
                    Resources.ConfirmActionMessage,
                    Resources.ConfirmActionTitle,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataBase db = new DataBase();
                db.RemoveDepartmentPosition(int.Parse(LstVw_Education.SelectedItems[0].Text), PersonId);
                Show(PersonId);
            }
        }
        public void Show(int departmentId)
        {
            PersonId = departmentId;
            var db = new DataBase();
            List<Position> lst = db.GetPositions(departmentId);
            LstVw_Education.Items.Clear();
            LstVw_Education.BeginUpdate();
            foreach (var course in lst)
            {
                AddItem(course);
            }

            LstVw_Education.EndUpdate();
        }

        /// <summary>
        /// Adds a new Course to the ListView by creating a new ListViewItem
        /// </summary>
        /// <param name="position">The new Course to add</param>
        public void AddItem(Position position)
        {
            // Create a ListViewItem
            var lvi = new ListViewItem($"{position.Id}");
            lvi.SubItems.Add($"{position.Name}");

            // Add LVI to LstBx.Items
            LstVw_Education.Items.Add(lvi);
        }
        
    }
}
