using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTests : AuthTestBase
    {

        [Test]
        public void GroupRemovalTest()
        {
            //Старый список групп
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Remove(0);

            //быстро возвращает количество групп
            Assert.AreEqual(oldGroups.Count - 1, app.Groups.GetGroupCount());

            //Новый список групп
            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);
        }

    }
}
