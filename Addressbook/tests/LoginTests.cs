using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            //предварительно выходим, если вдруг залогинен
            app.Auth.Logout();
            //заходим (1. создали переменную account, 2. обратились к ней)
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);
            //проверка. Данные валидные, зайти должно
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }

        [Test]
        public void LoginWithInvalidCredentials()
        {
            //предварительно выходим, если вдруг залогинен
            app.Auth.Logout();
            //заходим (1. создали переменную account, 2. обратились к ней)
            AccountData account = new AccountData("admin", "123456");
            app.Auth.Login(account);
            //проверка. Так как данные невалидные, зайти не должно
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
