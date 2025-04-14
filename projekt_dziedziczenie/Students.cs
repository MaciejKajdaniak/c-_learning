using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_dziedziczenie
{
    internal class Students : Person
    {
        public Students() { }

        public Students(string _firstName, string _lastName, classesAtSchool _studentClass)
        {
            this.firstName = _firstName;
            this.lastName = _lastName;
            studentClass= _studentClass;
        }

        public enum classesAtSchool
        {
            _1Ti, _1Te, _1Tel,
            _2Ti
        }

        public classesAtSchool studentClass;

        public string info()
        {
            return "Imię i nazwisko osoby: " + firstName + " " + lastName + ", klasa: " + studentClass;
        }
    }
}
