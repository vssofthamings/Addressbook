using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactsData newData = new ContactsData("123");
            newData.Middlename = "123";
            newData.Lastname = "qwe";

            app.Contacts.Modify(0, newData);
        }
    }
}


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactsData newData = new ContactsData("123");
            newData.Middlename = "123";
            newData.Lastname = "qwe";

            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Modify(0, newData);

            //Новый список контактов
            List<ContactsData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newData.Firstname;
            oldContacts.Sort();
            newContacts.Sort();
            //Сравниваем количество контактов. Старое значение + 1 = новое значение
            Assert.AreEqual(oldContacts, newContacts);

        }
    }
}
*/