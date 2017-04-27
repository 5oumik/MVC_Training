using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.DataAccessLayer;

namespace MVC.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            SalesERPDAL salesDAL = new SalesERPDAL();
            return salesDAL.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }


    }
}