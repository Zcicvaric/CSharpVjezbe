using System;
using System.Collections.Generic;
using System.Text;

namespace Vjezba_6
{
    class Person
    {
        String _name { get; set; }
        String _lastName { get; set; }
        String _city { get; set; }
        int _age { get; set; }

        public Person(String name, String lastName, String city, int age)
        {
            this._name = name;
            this._lastName = lastName;
            this._city = city;
            this._age = age;
        }


    }
}
