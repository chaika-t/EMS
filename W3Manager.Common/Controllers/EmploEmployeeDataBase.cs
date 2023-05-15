using EmployeeManagementSystem.Common.Models;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Common.Controllers
{
    public class EmployeeDataBase
    {
        private Employee employee;
        public EmployeeDataBase()
        {
        }
        public EmployeeDataBase(Employee employee)
        {
            this.employee = employee;
        }
        public void AddEmployee()
        {
            DataBase dataBase = new DataBase();
            switch (employee.Type)
            {
                case EmployeeType.Hourly:
                    dataBase.UpdateHourly((Hourly)employee);
                    break;
                case EmployeeType.Contract:
                    dataBase.UpdateContract((Contract)employee);
                    break;
                case EmployeeType.Salary:
                    dataBase.UpdateSalary((Salary)employee);
                    break;
                case EmployeeType.Sales:
                    dataBase.UpdateSales((Sales)employee);
                    break;
            }
        }
        public SortedDictionary<int, Employee> GetEmployees()
        {
            DataBase dataBase = new DataBase();
            return dataBase.GetEmployees();
        }
        public void RemoveEmployee(int id)
        {
            DataBase dataBase = new DataBase();
            dataBase.DeleteEmployee(id);
        }
    }
}
