using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;

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
        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        protected void GoTogroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        protected void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        protected void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        protected void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        protected void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }

        protected void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        protected void GoToCreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        protected void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
        }

        protected void FillContactForm(ContactsData contacts)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contacts.Firstname);
            driver.FindElement(By.Name("middlename")).SendKeys(contacts.Middlename);
            driver.FindElement(By.Name("lastname")).SendKeys(contacts.Lastname);
            driver.FindElement(By.Name("nickname")).SendKeys(contacts.Nickname);
            driver.FindElement(By.Name("title")).SendKeys(contacts.Title);
            driver.FindElement(By.Name("company")).SendKeys(contacts.Company);
            driver.FindElement(By.Name("address")).SendKeys(contacts.Address);
            driver.FindElement(By.Name("home")).SendKeys(contacts.Home);
            driver.FindElement(By.Name("mobile")).SendKeys(contacts.Mobile);
            driver.FindElement(By.Name("work")).SendKeys(contacts.Work);
            driver.FindElement(By.Name("fax")).SendKeys(contacts.Fax);
            driver.FindElement(By.Name("email")).SendKeys(contacts.Email);
            driver.FindElement(By.Name("email2")).SendKeys(contacts.Email2);
            driver.FindElement(By.Name("email3")).SendKeys(contacts.Email3);
            driver.FindElement(By.Name("homepage")).SendKeys(contacts.Homepage);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("March");
            driver.FindElement(By.Name("byear")).SendKeys(contacts.Byear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("May");
            driver.FindElement(By.Name("ayear")).SendKeys(contacts.Ayear);
            driver.FindElement(By.Name("address2")).SendKeys(contacts.Address2);
            driver.FindElement(By.Name("phone2")).SendKeys(contacts.Phone2);
            driver.FindElement(By.Name("notes")).SendKeys(contacts.Notes);
        }
        protected void SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }
    }
}
