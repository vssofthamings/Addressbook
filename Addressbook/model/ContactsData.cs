using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactsData : IEquatable<ContactsData>
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";

        public ContactsData(string firstname)
        {
            this.firstname = firstname;
        }

        //Сравниваем объекты. Стандартные проверки
        public bool Equals(ContactsData other)
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
            return Firstname == other.Firstname;
            //return Middlename == other.Middlename;
        }

        public int GetHashCode()
        {
            return Firstname.GetHashCode();
            //return Middlename.GetHashCode();
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Middlename
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

       /*
         public string Nickname { get; set; }
         public string Title { get; set; }
         public string Company { get; set; }
         public string Address { get; set; }
         public string Home { get; set; }
         public string Mobile { get; set; }
         public string Work { get; set; }
         public string Fax { get; set; }
         public string Email { get; set; }
         public string Email2 { get; set; }
         public string Email3 { get; set; }
         public string Homepage { get; set; }
         public string Byear { get; set; }
         public string Ayear { get; set; }
         public string Address2 { get; set; }
         public string Phone2 { get; set; }
         public string Notes { get; set; }
       */
    }
    
}
