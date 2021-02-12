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
            Type(By.Name("firstname"), contacts.Firstname);
            Type(By.Name("middlename"), contacts.Middlename);
            Type(By.Name("lastname"), contacts.Lastname);
            /*Type(By.Name("group_name"), contacts.Nickname);
            Type(By.Name("title"), contacts.Title);
            Type(By.Name("company"), contacts.Company);
            Type(By.Name("address"), contacts.Address);
            Type(By.Name("home"), contacts.Home);
            Type(By.Name("mobile"), contacts.Mobile);
            Type(By.Name("work"), contacts.Work);
            Type(By.Name("fax"), contacts.Fax);
            Type(By.Name("email"), contacts.Email);
            Type(By.Name("email2"), contacts.Email2);
            Type(By.Name("email3"), contacts.Email3);
            Type(By.Name("homepage"), contacts.Homepage);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("March");
            Type(By.Name("byear"), contacts.Byear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("May");
            Type(By.Name("ayear"), contacts.Ayear);
            Type(By.Name("address2"), contacts.Address2);
            Type(By.Name("phone2"), contacts.Phone2);
            Type(By.Name("notes"), contacts.Notes);*/
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
        //Удаление контакта
        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        //Удаление контакта. Закр вспл окно
        public ContactHelper SubmitRemovalContact()
        {
            driver.SwitchTo().Alert().Accept();
            return this;
        }
    }
}
