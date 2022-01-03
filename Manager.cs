using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSQL
{
    class Manager
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string email;
        public string department;

        public Manager(string firstName, string lastName, string birthday, string email, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            this.email = email;
            this.department = department;
        }
    }
}
