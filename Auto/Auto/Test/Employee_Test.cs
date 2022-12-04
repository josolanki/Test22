using Auto.Pages;

namespace Auto.Test
{
    public class Employee_Test : CommonDriver
    {
        [Test, Order(1), Description("Check if user can create an employee record")]
        public void CreateEmployee_Test()
        {
            //import Homepage here
            HomePage homepageobj = new HomePage();
            homepageobj.GoToEmployeePage(driver);
            EmployeePage employeeobj = new EmployeePage();
            employeeobj.CreateEmployee(driver);

        }

        [Test, Order(2), Description("Check if user can edit an existing employee record")]
        public void EditEmployee()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user can delete an existing record")]
        public void DeleteEmployee()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.DeleteEmployee(driver);
        }
        [TearDown]
        public new void CloseTestRun()
        {
            driver.Quit();
        }
    }

      

    

}
