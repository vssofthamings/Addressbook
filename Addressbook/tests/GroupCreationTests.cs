using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
 
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";

            //Старый список групп
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);

            //Новый список групп
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            //Сравниваем количество групп. Старое значение + 1 = новое значение
            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            //Старый список групп
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            //app.Auth.Logout();

            //Новый список групп
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            //Сравниваем количество групп. Старое значение + 1 = новое значение
            Assert.AreEqual(oldGroups, newGroups);
        }

        //Создание группы с недопустимым названием. Количество групп не изменилось
        [Test]
        public void BadNameGroupCreationTest()
        {
            GroupData group = new GroupData("a'a");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Create(group);
            //app.Auth.Logout();

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Sort();
            newGroups.Sort();
            //Сравниваем количество групп. Количество групп не изменилось, поэтому: Старое значение = новое значение
            Assert.AreEqual(oldGroups.Count, newGroups.Count);
        }
    }
}