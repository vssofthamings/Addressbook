using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToCreateNewContact();
            FillContactForm();
            SubmitContactCreation();
            ReturnToHomePage();
            Logout();
        }

        private void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        private void SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }

        private void FillContactForm()
        {
            driver.FindElement(By.Name("firstname")).SendKeys("a");
            driver.FindElement(By.Name("middlename")).SendKeys("s");
            driver.FindElement(By.Name("lastname")).SendKeys("d");
            driver.FindElement(By.Name("nickname")).SendKeys("qq");
            driver.FindElement(By.Name("title")).SendKeys("w");
            driver.FindElement(By.Name("company")).SendKeys("e");
            driver.FindElement(By.Name("address")).SendKeys("d1");
            driver.FindElement(By.Name("home")).SendKeys("1d");
            driver.FindElement(By.Name("mobile")).SendKeys("123234");
            driver.FindElement(By.Name("work")).SendKeys("qwe123");
            driver.FindElement(By.Name("fax")).SendKeys("123qwe");
            driver.FindElement(By.Name("email")).SendKeys("qwe123");
            driver.FindElement(By.Name("email2")).SendKeys("qwe234");
            driver.FindElement(By.Name("email3")).SendKeys("qwe345");
            driver.FindElement(By.Name("homepage")).SendKeys("qqq22www");
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("March");
            driver.FindElement(By.Name("byear")).SendKeys("1999");
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("May");
            driver.FindElement(By.Name("ayear")).SendKeys("2999");
            driver.FindElement(By.Name("address2")).SendKeys("red");
            driver.FindElement(By.Name("phone2")).SendKeys("88");
            driver.FindElement(By.Name("notes")).SendKeys("rrreeedfdd");
        }

        private void GoToCreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys("admin");
            driver.FindElement(By.Name("pass")).SendKeys("secret");
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        private void OpenHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
