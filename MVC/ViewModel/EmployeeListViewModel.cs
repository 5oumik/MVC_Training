using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC.ViewModel;
using MVC.Models;

namespace MVC.ViewModel
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employee { get; set; }       
    }
}