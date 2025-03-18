using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace test
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public int Number { get; set; }
            public string Street { get; set; }

            public Person(string name, int number, string street)
            {
                Name = name;
                Number = number;  // Исправлено присваивание
                Street = street;  // Исправлено присваивание
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Имя: {Name}\nНомер: {Number}\nУлица: {Street}");
            }
        }

        class Customer : Person
        {
            public bool Wish { get; set; }
            public string CustomerNumber { get; set; }

            public Customer(string name, int number, string street, bool wish, string customerNumber)
                : base(name, number, street)
            {
                Wish = wish;  // Исправлено присваивание
                CustomerNumber = customerNumber;  // Исправлено присваивание
            }

            public void DisplayInfoCust()
            {
                Console.WriteLine($"Номер клиента: {CustomerNumber}");
                Console.WriteLine($"Участвует ли в рассылке: {Wish}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите ваш номер: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите улицу: ");
            string street = Console.ReadLine();

            Console.WriteLine("Номер клиента:");
            string customerNumber = Console.ReadLine();

            Console.WriteLine("Хотите ли участвовать в рассылке? (да/нет): ");
            string mailing = Console.ReadLine();
            bool wish = false;

            if (mailing.ToLower() == "да")
            {
                wish = true;
            }

            Customer customer = new Customer(name, number, street, wish, customerNumber);

            Console.WriteLine();
            customer.DisplayInfo();  // Выводим информацию о человеке
            customer.DisplayInfoCust();  // Выводим информацию о клиенте
        }
    }
}
