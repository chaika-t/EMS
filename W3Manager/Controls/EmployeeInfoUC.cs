using System.Text;
using System.Windows.Forms;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Controls
{
    public partial class EmployeeInfoUC : UserControl
    {
        public EmployeeInfoUC()
        {
            InitializeComponent();
        }
     
        public void Show(Employee emp)
        {
            var details = new StringBuilder();
            details.AppendLine($"Details:");
            details.AppendLine($"Id: {emp.Id} LastName: {emp.LastName}, FirstName: {emp.FirstName}");
            details.AppendLine($"Contacts:");
            details.AppendLine($"City: {emp.City} Street: {emp.Street} Phone Number: {emp.Phone}");
            details.AppendLine($"Type:");
            details.AppendLine($"Type: {emp.Type} ");
            RTBx_Main.Text = details.ToString();
        }
        public void Clear()
        {
            RTBx_Main.Clear();
        }
    }
}
