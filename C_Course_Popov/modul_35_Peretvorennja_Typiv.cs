using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 35. Преобразование типов в языке программирования C#

         abstract class Person_35
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person_35(string name, string surname)  //конструктор
        {
            FirstName = name;
            LastName = surname;
        }

        public abstract void Display();    
    }

    class Employee_35 : Person_35
    {
        public string Company { get; set; }

        public Employee_35(string name, string surname, string comp)
            : base(name, surname)
        {
            Company = comp;
        }

        public override void Display()     
        {
            Console.WriteLine($"Employee {FirstName} {LastName} працює в компанії {Company}");
        }

    }


    class Client_35 : Person_35
    {
        public int Sum { get; set; }
        public string  Bank { get; set; }

        public Client_35(string name, string surname, string bank, int sum)
            : base(name, surname)
        {
            Bank = bank;
            Sum = sum;
        }

        public override void Display()      
        {
            Console.WriteLine($"Client {FirstName} {LastName} має рахунок в банку {Bank} " + $"на суму {Sum}");
        }
    }
}


