using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_dziedziczenie
{
    internal class Employee : Person
    {
        private string workPlace = "";
        private float ratePerWorkHour = 0;
        private ushort numberOfWorkHours = 0;

        public Employee() { }

        public Employee(string _firstName, string _lastName, float _height, float _weight, string _workPlace, float _ratePerWorkHour, ushort _numberOfWorkHours) : base(
            firstName, lastName, height, weight)
        {
            this.workPlace = _workPlace;
            this.ratePerWorkHour = _ratePerWorkHour;
            this.numberOfWorkHours = _numberOfWorkHours;
        }

        private float Salary()
        {
            return ratePerWorkHour * numberOfWorkHours;
        }

        private new string info()
        {
            return base.info() + ", pensja: " + Salary();
        }
    }
}
