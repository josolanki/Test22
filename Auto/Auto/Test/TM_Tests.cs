

namespace Auto.Test
{
         [TestFixture]     
        public class TM_Tests : CommonDriver
        
    {

        [Test, Order(1)]
        public void LoginSteps() 
        {
           

            // Home page object intilazation and defination
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }
            [Test, Order(2)]
            public void CreateTM_Test()
            {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);

            }
            [Test, Order(3)]
            public void EditTM_Test()
            {
            // Edit tm object intilazation and defination
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
            }
            [Test, Order(4)]
             public void DeleteTM_Test() 
            {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver); 
             }
    
    
    }
}
