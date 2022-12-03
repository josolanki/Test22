namespace Auto.Test
{
    public class Employee_Test : CommonDriver
    {
        [Test, Order(1), Description("Check if user can create an employee record with valid data")]
        public void CreateEmployee_Test()
        {
            
        }

        [Test, Order(2), Description("Check if user can edit an existing employee record successfully")]
        public void EditEmployee_Test()
        {
           
        }

        [Test, Order(3), Description("Check if user can delete an existing & edited employee record successfully")]
        public void DeleteEmployee_Test()
        {
           
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }



    }

}
