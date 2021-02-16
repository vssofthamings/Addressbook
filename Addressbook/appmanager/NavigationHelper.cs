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
        //Открытие домашней старницы. + Предварительная проверка, что уже не там
        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }

        //Переход в группы + Предварительная проверка, что уже не там
        public void GoTogroupsPage()
        {
            if (driver.Url == baseURL + "/addressbook/edit.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        //Страница Home
        public void GoToStartPage()
        {
            if (driver.Url == baseURL + "/addressbook"
                && IsElementPresent(By.Name("home")))
            {
                return;
            }
                driver.FindElement(By.LinkText("home")).Click();
        }
    }
}
