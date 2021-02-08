using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : TestBase
    {

        [Test]
        public void TheUntitledTestCaseTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.GoToCreateNewContact();
            ContactsData contacts = new ContactsData();
            contacts.Firstname = "AAA";
            contacts.Middlename = "BBB";
            contacts.Lastname = "CCC";
            contacts.Nickname = "SS";
            contacts.Title = "qwe123";
            contacts.Company = "qwe123";
            contacts.Address = "qwe123";
            contacts.Home = "23";
            contacts.Mobile = "qwe123";
            contacts.Work = "qwe123";
            contacts.Fax = "qwe123";
            contacts.Email = "qwe123";
            contacts.Email2 = "qwe123";
            contacts.Email3 = "qwe123";
            contacts.Homepage = "qwe123";
            contacts.Byear = "1999";
            contacts.Ayear = "2099";
            contacts.Address2 = "qwe123";
            contacts.Phone2 = "qwe123";
            contacts.Notes = "qwe123";
            app.Contacts.FillContactForm(contacts);
            app.Contacts.SubmitContactCreation();
            app.Contacts.ReturnToHomePage();
            app.Auth.Logout();
        }


    }
}
