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
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager)
            :base(manager)
        {
        }
        //Проверка выполнен ли логин
        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                //Если верная учетка - return
                if (IsLoggedIn(account))
                {
                    return;
                }
                //если неправильная учетка
                Logout();
            }
            //Выполнение логина
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        //Выход
        public void Logout()
        {
            //Сначала проверяется не залогинен ли уже и потом выполняется выход
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
            }
        }
        //Проверка наличия кнопки logout
        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }
        //Проверка имени пользователя, который сейчас в сети
        public bool IsLoggedIn(AccountData account)
        {
            //юзер залогинен и имя совпадает 
            return IsLoggedIn()
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                == "(" + account.Username + ")";
        }
    }
}
