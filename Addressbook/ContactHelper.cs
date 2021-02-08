using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
      public ContactHelper(IWebDriver driver)
    : base(driver)
        {
        }
        //Контакт. Создать контакт
        public void GoToCreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        //Контакт. Заполнить контакт
        public void FillContactForm(ContactsData contacts)
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
        //Контакт. Подтвердить создание контанкта
        public void SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
        }
        //Возврат на главную
        public void ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
