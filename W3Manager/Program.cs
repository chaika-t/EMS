namespace EmployeeManagementSystem
{
    using System;
    using System.Windows.Forms;
    using Forms;

    /// <summary>
    /// Primary thread class for interacting with the application
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartApplication();
        }

        /// <summary>
        /// Starts an Application instance using a file specified in the parameter
        /// </summary>
        private static void StartApplication()
        {
            var form = new FrmMain();       
            Application.Run(form);
        }
    }
}
