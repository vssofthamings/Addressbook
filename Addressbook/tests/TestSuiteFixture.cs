﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//где-то тут ошибка. Использую OneTimeSetUp вместо SetUp и OneTimeTearDown аналогично
namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {

        [OneTimeSetUp]
        public void InitApplicationManager()
        {
            ApplicationManager app = ApplicationManager.GetInstance();
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        } 
       /* [OneTimeTearDown]
        public void StopApplicationManager()
        {
            ApplicationManager.GetInstance().Stop();
        }*/
    }
}
