using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13_1
{
    internal class Employee
    {

        private string name;
        private string position;
        private int salary;
        private string acceptDate;

        public string Name { get; set; }
        public string Position { get; set; }
        public int Salary {
            get { return salary; }
            set {
                if (value > 0) { salary = value; }
                else { salary = 0; }
            }
        }
        public string AcceptDate { get; set; }

        public Employee(string name, string position, int salary, string acceptDate){
            this.Name = name;
            this.Position = position;
            this.Salary = salary;
            this.AcceptDate = acceptDate;
        }

    }
}
