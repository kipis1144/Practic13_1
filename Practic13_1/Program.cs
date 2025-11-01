using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic13_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Inna = new Employee("Инна", "Уборщица", 20000, "01.05.2023");
            Manager Boris = new Manager("Борис", "Менеджер", 76000, "01.03.2022", 2);
            Developer Artem = new Developer("Артем", "Разработчик", 130000, "27.10.2024", "C#");
            Director Denis = new Director("Денис Игоревич", "CEO", 76000, "01.01.2022", "Разработка десктопного ПО");

            Denis.AcceptBudget();
            Boris.HoldMeeting();
            Artem.WriteCode();
            Artem.WriteCode();
            Artem.WriteCode();

        }
    }
}
