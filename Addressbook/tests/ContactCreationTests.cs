using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {

        [Test]
        public void ContactsCreationTest()
        {
            ContactData contacts = new ContactData("AAA");
            contacts.Middlename = "BBB";
            contacts.Lastname = "CCC";

            //Старый список контактов
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }

        [Test]
        public void EmptyContactsCreationTest()
        {
            ContactData contacts = new ContactData("");
            contacts.Middlename = "";
            contacts.Lastname = "";

            //Старый список контактов
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count + 1, newContacts.Count);
        }
        [Test]
        public void BadNameContactsCreationTest()
        {
            ContactData contacts = new ContactData("a'a");
            contacts.Middlename = "";
            contacts.Lastname = "";

            //Старый список контактов
            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactData> newContacts = app.Contacts.GetContactList();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts.Count, newContacts.Count);
        }
    }
}

/*
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

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contacts);
            oldContacts.Sort();
            newContacts.Sort();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts, newContacts);
        }

        [Test]
        public void EmptyContactsCreationTest()
        {
            ContactsData contacts = new ContactsData("");
            contacts.Middlename = "";
            contacts.Lastname = "";

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contacts);
            //app.Auth.Logout();

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contacts);
            oldContacts.Sort();
            newContacts.Sort();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts, newContacts);
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
            oldContacts.Sort();
            newContacts.Sort();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
*/