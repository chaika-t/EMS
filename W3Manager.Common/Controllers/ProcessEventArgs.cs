using System;

namespace EmployeeManagementSystem.Common.Controllers
{
    /// <summary>
    /// Данные события
    /// </summary>
    public class ProcessEventArgs : EventArgs
    {
        public ProcessEventArgs(object arg)
        {
            this.Argument = arg;
        }
        public object Argument { get; set; }
    }
}
