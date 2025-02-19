using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_1
{


    class Employee
    {
        // Атрибуты класса Employee
        public string Name { get; set; }
        public string Id { get; set; }

        // Конструктор
        public Employee(string name, string id)
        {
            Name = name;
            Id = id;
        }

        // Метод для отображения информации о сотруднике
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, ID: {Id}");
        }
    }

    class ShiftSupervisor : Employee
    {
        // Атрибуты класса ShiftSupervisor
        public decimal AnnualSalary { get; set; }
        public decimal AnnualBonus { get; set; }

        // Конструктор
        public ShiftSupervisor(string name, string id, decimal annualSalary, decimal annualBonus)
            : base(name, id)
        {
            AnnualSalary = annualSalary;
            AnnualBonus = annualBonus;
        }

        // Переопределение метода для отображения информации о начальнике смены
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Годовой оклад: {AnnualSalary:C}, Годовая премия: {AnnualBonus:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта ShiftSupervisor
            ShiftSupervisor supervisor = new ShiftSupervisor("Иван Иванов", "12345", 60000m, 5000m);

            // Отображение информации о начальнике смены
            supervisor.DisplayInfo();

            Console.ReadLine(); // Ожидание ввода для завершения программы
        }
    }
}

