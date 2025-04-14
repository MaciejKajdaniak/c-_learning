using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_dziedziczenie
{
    internal class Person
    {
        public string firstName = "";
        public string lastName = "";
        public float height = 0f;
        public float weight = 0f;

        public Person() { }

        public Person(string _firstName, string _lastName)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
        }

        public Person(string _firstName, string _lastName, float _height, float _weight)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            this.weight = _weight;
            this.height = _height;
        }

        public string info()
        {
            return "Imię i nazwisko osoby: " + firstName + " " + lastName + ", Waga: " + weight + ", wzrost: " + height + " ";
        }

    }
}
