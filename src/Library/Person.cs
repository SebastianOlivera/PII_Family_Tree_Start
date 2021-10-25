using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        private int age;
        
        private string name;

        private List<Person> children = new List<Person>();

        public int Age {
            get
            {
                return this.age;
            }
        }
        public string Name {
            get
            {
                return this.name;
            }
        }

        public ReadOnlyCollection<Person> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void AddChildren(Person n)
        {
            this.children.Add(n);
        }
        
    }
}
