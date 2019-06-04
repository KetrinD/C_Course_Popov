using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 33. Абстрактные классы и методы в языке программирования C#

    //щоб визначити клас як абстрактний нам потрібно використовувати ключове слово (abstract)
    // головна відмінність абстрактного класу від просто заключається в тому, що ми не можемо напряму викликати конструктор абстрактного класу для створення обєкту
    //



    abstract class Human
    {
        public string Name { get; set; }
    }

    //спільну функціональність (FirstName, LastName, метод Display) для класу Client та класу Employee_Abstract_Modul винесемо в окремий клас Person_Abstract_Modul

    abstract class Person_Abstract_Modul
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person_Abstract_Modul(string name, string surname)
        {
            FirstName = name;
            LastName = surname;
        }

        public abstract void Display();    // абстрактний метод Display. Абстрактний метод не повинен мати нічкого тіла, тобто не повинен визначати ніяких дій. Післ списку параметрів ставиться ;  і все
        // абстрактний метод або властивості не можуть бути приватними (private)
        // ми не можемо визначити в звичайному класі абстрактні методи або абстрактні властивості
    }

    // якщо в базовому класі визначений абстрактниц метод чи абстрактні властивості, то класи-наслідники обовязвоко мають реалізувати такі методи чи властивлості
    // абстрактні методи і властивості також являються частиною поліморфного інтерфейсу, тому в похідних класах ми їх можемо переіизначити за допомогою ключового слова (ovrerride)


    class Client : Person_Abstract_Modul
    {
        //public string FirstName { get; set; } -  спільні властивості для двох класів - тому виносимо в базовий клас
        //public string LastName { get; set; }
        public int Sum { get; set; }

        public Client(string name, string surname, int sum)
            : base(name, surname)
        {
            Sum = sum;
        }

        public override void Display()      //перевизначаємо метод Display базового класу Person_Abstract_Modul
        {
            Console.WriteLine($"Client {FirstName} {LastName}");
        }
        //public void Display()   - спільний метод для двох класів - тому виносимо в базовий клас
        //{
        //    Console.WriteLine($"{FirstName} {LastName}");
        //}
    }

    class Employee_Abstract_Modul : Person_Abstract_Modul
    {
        //public string FirstName { get; set; }   - спільні властивості для двох класів - тому виносимо в базовий клас
        //public string LastName { get; set; }
        public string Position { get; set; }

        public Employee_Abstract_Modul(string name, string surname, string position)
            : base(name, surname)
        {
            Position = position;
        }

        public override void Display()      //перевизначаємо метод Display базового класу Person_Abstract_Modul
        {
            Console.WriteLine($"Employee {FirstName} {LastName}");
        }



        //public void Display()   - спільний метод для двох класів - тому виносимо в базовий клас
        //{
        //    Console.WriteLine($"{FirstName} {LastName}");

        //}
    }
}

