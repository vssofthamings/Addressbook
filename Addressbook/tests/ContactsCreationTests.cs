using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactsCreationTests : AuthTestBase
    {

        [Test]
        public void ContactsCreationTest()
        {
            ContactsData contacts = new ContactsData("AAA");
            contacts.Middlename = "BBB";
            contacts.Lastname = "CCC";
            /*contacts.Nickname = "SS";
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
            contacts.Notes = "qwe123";*/

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }

        [Test]
        public void EmptyContactsCreationTest()
        {
            ContactsData contacts = new ContactsData("");
            contacts.Middlename = "";
            contacts.Lastname = "";
            /*contacts.Nickname = "";
            contacts.Title = "";
            contacts.Company = "";
            contacts.Address = "";
            contacts.Home = "";
            contacts.Mobile = "";
            contacts.Work = "";
            contacts.Fax = "";
            contacts.Email = "";
            contacts.Email2 = "";
            contacts.Email3 = "";
            contacts.Homepage = "";
            contacts.Byear = "";
            contacts.Ayear = "";
            contacts.Address2 = "";
            contacts.Phone2 = "";
            contacts.Notes = "";*/

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }
        [Test]
        public void BadNameContactsCreationTest()
        {
            ContactsData contacts = new ContactsData("a'a");
            contacts.Middlename = "";
            contacts.Lastname = "";

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count, newContacts.Count);
        }
    }
}
