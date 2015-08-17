using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    //EmployeeContext class derives from DbContext class, and is 
    //    responsible for establishing a connection to the database. So the
    //        next step, is to include connection string in web.config file.
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }

}