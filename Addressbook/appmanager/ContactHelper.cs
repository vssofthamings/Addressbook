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
      public ContactHelper(ApplicationManager manager)
            : base(manager)
        {
        }


        public ContactHelper Create(ContactsData contacts)
        {
            manager.Navigator.GoToStartPage();
            GoToCreateNewContact();
            FillContactForm(contacts);
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }

        public ContactHelper Modify(int v, ContactsData newData)
        {
            manager.Navigator.GoToStartPage();
            SelectContact(v);
            InitContactsModification();
            FillContactForm(newData);
            SubmitContactModification();
            ReturnToHomePage();
            return this;
        }


        public ContactHelper Remove(int v)
        {
            manager.Navigator.GoToStartPage();
            SelectContact(v);
            RemoveContact();
            SubmitRemovalContact();
            ReturnToHomePage();
            return this;
        }


        //Контакт. Создать контакт
        public void GoToCreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        //Контакт. Заполнить контакт
        public ContactHelper FillContactForm(ContactsData contacts)
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
            return this;
        }

        //Контакт. Подтвердить создание контанкта
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            return this;
        }
        //Возврат на главную
        public ContactHelper ReturnToHomePage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            return this;
        }
        //Редактирование контактов. Выбор контакта
        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        //Редактирование контактов. Клик изменить
        public ContactHelper InitContactsModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        //Редактирование контактов. Подтвердить изменения
        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }
        //Удаление группы
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }

        public ContactHelper SubmitRemovalContact()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
