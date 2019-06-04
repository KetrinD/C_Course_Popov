using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace C_Course_Popov
{
    //Модуль 32. Полиморфизм и переопределение методов.

    // поліморфізм передбачає визначення поліморфного інтрерфейсу 
    // поліморфного інтрерфейс - це набір членів базового класу, тобто набір властивостей та методів, які можуть бути  перевизначені в класі-насліднику
    // щоб властивості та методи базового класу можна було перевизначити, вони мають мати модифікатор (virtual)


    // Стратегія#1
    // наслідувати функціонал так як він визначений в базовому класі і нічого в ньому не міняти, не перевизначати

    //Стратегія#2  - переоприділення віртуальних (virtual) методів та властивостей за допомогою кючового слова (override)
    // для переоприділення використовується ключове слово (override)
    // переоприділення віртуальних (virtual) методів та властивостей буде працювати по всьому ланцбгу наслідування

    // заборона перевизначати функціонал - для цього використовується ключове слово (sealed)


    //Стратегія#3 - представляє собою "приховування"
    // "приховування" передбачає собою приховування в класі-насліднику функціоналу базового класу


    class Person_Polimorfizm
    {
        private string _firstName;
        private string _lastName;

        public Person_Polimorfizm(string name, string surname)        // конструктор
        {
            _firstName = name;
            _lastName = surname;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public virtual string LastName      // модифікатор virtual ставиться перед повертаємим типом. Властивіть LastName зможе перевизначатися в класах-наслідникх
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public virtual void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }


    class Employee_Polimorfizm : Person_Polimorfizm
    {

        public Employee_Polimorfizm(string name, string surname, string comp)        // конструктор Employee_Polimorfizm який викликає конструктор класу Person_Polimorfizm         
           : base(name, surname)
        {
            Company = comp;
        }

        private string _company;

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public override sealed void Display()      // для переоприділення методу Display з батьківського методу - використовується ключове слово override
                                                   // sealed - забороняє перевизначати метод. класами-нслідниками. Має йти в парі з ключ. словом override
        {
            //Console.WriteLine(FirstName + " " + LastName + " works in " + Company);  // перевизначили метод Display
            // або
            base.Display();
            Console.WriteLine("Works in " + Company);
        }

        //метод №3 - "приховування"
        // "приховування" функціоналу методу Display, який є в базовому касі Person_Polimorfizm
        //public new void Display()       // при оприділенні методу Display використовується ключове слово new -> цей метод приховує реалізацію методу Display класу Person_Polimorfizm
        //{ 
        //    Console.WriteLine("Works in " + Company);
        //}
    }


    // перевизначення віртуальних(virtual) методів та властивостей буде працювати по всьому ланцюгу наслідування - тобто по всьому ланцюгу ми можемо перевизначати методи/властивості
    // ланцюг наслідування:    Person_Polimorfizm -> Employee_Polimorfizm -> Manager

    class Manager : Employee_Polimorfizm
    {
        public Manager(string name, string surname, string comp)       
           : base(name, surname, comp)
        {

        }

        //public override void Display()      // для переоприділення методу Display з батьківського методу - використовується ключове слово override
        //{
        //    Console.WriteLine("This is Manager");  // перевизначили метод Display

        //}
    }


}