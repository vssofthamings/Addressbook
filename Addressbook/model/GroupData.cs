using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        public GroupData(string name)
        {
            Name = name;
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

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        //Возвращает строковое представление объектов типа GroupData
        public override string ToString()
        {
            return "name=" + Name;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return Name.CompareTo(other.Name);
        }

        public string Name { get; set; }

        public string Header { get; set; }

        public string Footer { get; set; }

        public string Id { get; set; }
    }
}
