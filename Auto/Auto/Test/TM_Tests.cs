

using Auto.Pages;

namespace Auto.Test
{
         [TestFixture]     
        public class TM_Tests : CommonDriver

        {

        [Test, Order(1)]
           public void CreateTM_Test()
            {
            //import Homepage here
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);
           
            //TM page object intilazation
            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
            }

        [Test, Order(2)]
            public void EditTM_Test()
            {
            // Edit tm object intilazation and defination
            //import Homepage here
            HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);

            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
            }
            
             [Test, Order(3)]
           public void DeleteTM_Test()
           {
              //import Homepage here
              HomePage homepageobj = new HomePage();
            homepageobj.GoToTMPage(driver);

               TMPage tmPageObj = new TMPage();
              tmPageObj.DeleteTM(driver); 
             }
    
    
        }
}
