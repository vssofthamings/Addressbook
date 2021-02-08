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
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }
        //Открытие домашней старницы
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }

        //Переход в группы
        public void GoTogroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        //Контакт. Создать контакт
        public void GoToCreateNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
