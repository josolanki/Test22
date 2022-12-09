using Automation22.NewPages;
using Automation22.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation22.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Test : CommonDriver
    {

        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            HomePage homepageobj = new HomePage();
            homepageobj.GotoEmployeePage(driver);


            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);

        }

        [Test, Order(2)]
        public void EditEmployee()
        {
            HomePage homepageobj = new HomePage();
            homepageobj.GotoEmployeePage(driver);

            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee()
        {
            HomePage homepageobj = new HomePage();
            homepageobj.GotoEmployeePage(driver);


            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }
    }
  


    
}

