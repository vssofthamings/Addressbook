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
            ContactsData newData = new ContactsData();
            newData.Firstname = "123";
            newData.Middlename = "123";
            newData.Lastname = "qwe";
            /*newData.Nickname = "SS";
            newData.Title = "qwe123";
            newData.Company = "qwe123";
            newData.Address = "qwe123";
            newData.Home = "23";
            newData.Mobile = "qwe123";
            newData.Work = "qwe123";
            newData.Fax = "qwe123";
            newData.Email = "qwe123";
            newData.Email2 = "qwe123";
            newData.Email3 = "qwe123";
            newData.Homepage = "qwe123";
            newData.Byear = "1999";
            newData.Ayear = "2099";
            newData.Address2 = "qwe123";
            newData.Phone2 = "qwe123";
            newData.Notes = "qwe123";*/

            app.Contacts.Modify(1, newData);
        }
    }
}
