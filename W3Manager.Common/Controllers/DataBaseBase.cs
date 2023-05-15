using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using EmployeeManagementSystem.Common.Models;

namespace EmployeeManagementSystem.Common.Controllers
{
    public class DataBaseBase
    {

        public SqlConnection conn;
        public string ConnectString;
        public string ErrStr = "";

        public string GetConnectString()
        {
            if (string.IsNullOrEmpty(ConnectString))
                try
                {
                    DataBaseSettings ds = new SettingsSerializer().Deserialize();
                    ConnectString +=
                        @"User Id=" + ds.User + ";Password=" + ds.Password + "; " +
                        "MultipleActiveResultSets=" + ds.MultipleActiveResultSets + ";" +
                        "Server=" + ds.Server + ";" +
                        "Database=" + ds.Database + "; ";
                }
                catch (Exception ex)
                {
                    ErrStr = $"ERROR GetConnectString DB: {ex.Message}";
                }

            return ConnectString;
        }


        protected bool Reconnect()
        {
            try
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
            catch (Exception ex)
            {
                ErrStr = $"ERROR Reconnect DB: {ex.Message}";
                return false;
            }

            return Connect();
        }

        public bool Connect()
        {
            ErrStr = "";

            if (conn == null) conn = new SqlConnection();
            if (conn.State == ConnectionState.Open) return true;
            if (conn.State == ConnectionState.Executing || conn.State == ConnectionState.Fetching)
            {
                // чекаємо 10 сек. закінчення поточного запиту
                var secondCounter = 0;
                while (conn.State != ConnectionState.Open)
                {
                    Thread.Sleep(500);
                    if (secondCounter++ > 20) ErrStr = "Connect() wait end Executing/Fetching too long (10 sec)";
                    return false;
                }
            }

            if (string.IsNullOrEmpty(conn.ConnectionString)) conn.ConnectionString = GetConnectString();
            else if (conn.ConnectionString != ConnectString) return Reconnect();

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                ErrStr = $"ERROR connect DB: {ex.Message}";
                return false;
            }

            if (conn.State != ConnectionState.Open) return false;
            return true;
        }
    }
}
