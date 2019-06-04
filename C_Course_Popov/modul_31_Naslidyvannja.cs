using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Course_Popov
{
    //Модуль 31. Наследование в языке программирования C#

    //  суть наслідування полягає в тому, що ми можемо розширити функціональність вже існуючих класів за рахунок додавання нового функціоналу або за рхунок змінит старого фунціоналу
    // C# не підтримує множинне наслідуваня - ми можемо наслідувати клас лише від одного класу
    // !!! при наслідуванні від класу_А конструктори цього класу НЕ наслідуються по замовчуванню - Якщо в базовому класі оприділений конструктор, який приймає параметри - то нам треба обовязвоко треба викликати цей конструктор в похідному класі

    // sealed class Person_Nasliduvannja - заборона наслідування від певного класу - використовується ключове слово sealed


    class Person_Nasliduvannja
    {
        private string _firstName;
        private string _lastName;

        public Person_Nasliduvannja(string name, string surname)        // конструктор
        {
            _firstName = name;
            _lastName = surname;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public void Display()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    class Employee : Person_Nasliduvannja    //наслідування класу Employee від класу Person_Nasliduvannja
                                             // Person_Nasliduvannja буде називатися базовим класом або супер-класом, або батьківським класом
                                             // Employee буде називатися похідним класом або класом-наслідником
    {
        //private string _firstName;          - треба видалити після оприділення наслідування, оск ці поля та властивості наслідуються з батьківського класу
        //private string _lastName;

        public Employee(string name, string surname, string comp)                 // конструктор Employee який викликає конструктор класу Person_Nasliduvannja
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

        //public string FirstName                - треба видалити після оприділення наслідування, оск ці поля та властивості наслідуються з батьківського класу
        //{
        //    get { return _firstName; }
        //    set { _firstName = value; }
        //}

        //public string LastName
        //{
        //    get { return _lastName; }
        //    set { _lastName = value; }
        //}

        //public void Display()
        //{
        //    Console.WriteLine(FirstName + " " + LastName);
        //}

    }

}




 