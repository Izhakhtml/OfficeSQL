using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSQL
{
    class Employee
    {
        public string name;
        public string birthday;
        public string email;
        public int salary;

        public Employee(string name, string birthday, string email, int salary)
        {
            this.name = name;
            this.birthday = birthday;
            this.email = email;
            this.salary = salary;
        }
        public Employee() { }
    }
}
