/*
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Addressbook.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = null;
            int attempt = 0;
            //do...while
            do
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            }
            while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60);

            //while
            while (driver.FindElements(By.Id("test")).Count == 0 && attempt < 60)
            {
                System.Threading.Thread.Sleep(1000);
                attempt++;
            }


            //Способ вывести массив 
            string[] s = new string[] { "I", "want", "to", "sleep" };

            foreach (string element in s)
            {
                Console.Out.Write(element + "\n");
            }
        }
    }
}*/
