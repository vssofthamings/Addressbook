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
            ContactData newData = new ContactData("123");
            newData.Middlename = "123";
            newData.Lastname = "qwe";

            app.Contacts.Modify(0, newData);
        }
    }
}


/*using System;
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
            ContactData newData = new ContactData("123", "qwe");
            newData.Middlename = "123";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Modify(0, newData);

            //Новый список контактов
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts[0].Firstname = newData.Firstname;
            oldContacts[0].Lastname = newData.Lastname;
            oldContacts.Sort();
            newContacts.Sort();
            //Сравниваем количество контактов
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}*/

