using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Person
    {
        public string Name { get; set; }

        public string FirstName { get; set; }
        public int Age { get; set; }

        private int salary;
        public string FullName;


        public void setSalary()
        {
            salary = 33000;
        }

        public int getSalary()
        {
            return salary;
        }

        public string getFullName()
        {
            FullName = Name + FirstName;
            return FullName;
        }
    }
}
