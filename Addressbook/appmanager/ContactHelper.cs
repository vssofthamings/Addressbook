﻿using System;
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

        public ContactHelper Create(ContactData contacts)
        {
            manager.Navigator.GoToStartPage();
            GoToCreateNewContact();
            FillContactForm(contacts);
            SubmitContactCreation();
            ReturnToHomePage();
            return this;
        }

        //Список контактов
        public List<ContactData> GetContactList()
        {
            List<ContactData> contacts = new List<ContactData>();
            manager.Navigator.GoToStartPage();
            //Подсчет списка всех элементов "контакт". Ищем по имени. Возможно есть вариант получше
            ICollection<IWebElement> elements = driver.FindElements(By.Name("entry"));
            foreach (IWebElement element in elements)
            {
                contacts.Add(new ContactData(element.Text, element.Text));
            }
            return contacts;
        }

        public ContactHelper Modify(int v, ContactData newData)
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
        public ContactHelper FillContactForm(ContactData contacts)
        {
            Type(By.Name("firstname"), contacts.Firstname);
            Type(By.Name("middlename"), contacts.Middlename);
            Type(By.Name("lastname"), contacts.Lastname);
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
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
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
