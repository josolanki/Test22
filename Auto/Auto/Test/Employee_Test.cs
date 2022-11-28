﻿using Auto.Pages;
using Auto.utilities;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Test
{
    [TextFixture]
    public class Employee_Test : CommonDriver
    {
        [SetUp]
        public void loginSteps()

        {
            driver = new ChromeDriver();
            //Login page Object intilazation and defination
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginAction(driver);


            // Home Page Object intilazation and defination            
            HomePage EmployeePage = new HomePage();
            EmployeePage employeePageObj = new EmployeePage();

        }


        [Test, Order(1)]

        public void CreateEmployeePage()

        {
            // create a new Employee
            EmployeePage createEmployeePageObj = new EmployeePage();
            EmployeePage createEmployeePage = new EmployeePage();




        }





    }

}