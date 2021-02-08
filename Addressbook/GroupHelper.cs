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
    public class GroupHelper
    {
        private IWebDriver driver;

        public GroupHelper(IWebDriver driver)
        {
            this.driver = driver;
        }
        //Группы. Создание новой группы
        public void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }
        //Группы. Заполнение формы для группы
        public void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        //Группы. Подтверждение новой группы
        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        //Группы. Возврат к списку групп
        public void ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        //Удаление группы. Выбор группы
        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
        //Удаление группы
        public void RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
    }
}
