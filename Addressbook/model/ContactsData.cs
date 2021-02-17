using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactsData
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";

        public ContactsData(string firstname)
        {
            this.firstname = firstname;
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
