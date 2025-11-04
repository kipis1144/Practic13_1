using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13_1
{
    internal class Manager : Employee
    {
        private int teamSize;
        public int TeamSize { 
            get { return teamSize; }
            set {
                if (value >= 0) { teamSize = value; }
                else { teamSize = 0; }
            }
        }
        public Manager(string name, string position, int salary, string acceptDate, int teamSize) : base(name, position, salary, acceptDate)
        {
            this.TeamSize = teamSize;
        }

        public void HoldMeeting() {
            Console.WriteLine($"Менеджер {Name} провел собрание с командой из {TeamSize} человек");
        }
    }
}
