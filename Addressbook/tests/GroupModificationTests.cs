using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            //Берем нулевой элемент и сравниваем его имя с новым именем
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            //Сравниваем количество групп. Старое значение + 1 = новое значение
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
