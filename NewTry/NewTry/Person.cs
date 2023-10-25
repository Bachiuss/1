using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTry
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }

        public Person(int age, string name)
        {
            _age = age;
            Name = name;
        }

        public string Introduction()
        {
            return "Hi I'm" + Name + " and I'm" + _age + " Years old";
        }
    }
}
