using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Common.Controllers;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Forms
{
    public partial class AddPosition : Form
    {
        public Position Position { get; set; }
        private int idDepartment;
        public AddPosition(int idDepartment)
        {
            InitializeComponent();
            this.errProvider.Icon = Properties.Resources.blackX;
            this.idDepartment = idDepartment;
            
            DataBase db = new DataBase();
            List<Position> lst = db.GetPositions();
            DisplayPositions( lst);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Position pos = comboBox1.SelectedItem as Position;
            this.Position = pos;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// Sets DialogResult to Cancel and closes the form
        /// </summary>
        /// <param name="sender">Object triggering the event</param>
        /// <param name="e">Additional event arguments</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Sets each member of the Course object to their respective fields on the form
        /// </summary>
        /// <param name="course"><see cref="Common.Models.Course"/> object to be displayed</param>
        private void DisplayPositions(List<Position> lst)
        {
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            this.comboBox1.DataSource = lst;
        }

        private void positionsCmbBox_Click(object sender, EventArgs e)
        {

        }
    }
}
