using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Common.Models
{
    [Serializable]
    public class DataBaseSettings
    {
        public string User { get; set; }
        public string Password { get; set; }
        public bool MultipleActiveResultSets { get; set; }
        public string Server { get; set; }
        public string Database { get; set; }
    }
}
