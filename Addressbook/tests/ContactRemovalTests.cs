using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
   [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {

        [Test]
        public void ContactRemovalTest()
        {
            //Старый список контактов
            List<ContactsData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Remove(0);

            //Новый список контактов
              List<ContactsData> newContacts = app.Contacts.GetContactList();

              oldContacts.RemoveAt(0);
              Assert.AreEqual(oldContacts, newContacts);
        }

    }
}