using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData : IEquatable<GroupData>
    {
        private string name;
        private string header = "";
        private string footer = "";

        public GroupData(string name)
        {
            this.name = name;
        }
        //Сравниваем объекты. Стандартные проверки
        public bool Equals(GroupData other)
        {
            //Если текущий равен NULL ==> FALSE
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            //Если две ссылки указывают на один и тот же объект
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            //Проверка по смыслу. Берем имя группы (для контактов взять имя+фамилия)
            return Name == other.Name;
        }

        public int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }
        public string Footer
        {
            get
            {
                return footer;
            }
            set
            {
                footer = value;
            }
        }
    }
}
