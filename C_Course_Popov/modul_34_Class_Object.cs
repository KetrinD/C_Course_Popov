using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 34. Класс Object и его методы в языке программирования C#

    // всі класи які ми викормистовуємо в С#, в тючю і які ми створюємо - неявно наслідуються від класу Object
    // Equals, GetHashCode, GetType, ToString - ці методи представляють базовий клас Object, від якого наслідуються неявно всі інші класи

    // ToString - вертає рядкове представлення обєкта
    // GetHashCode - цей метод повертає певне число, яке буде унікальним чином представляти даний обєкт - числове значення, яке унікально ідентифікує обєкт
    // GetType - метод дозволяє отримати тип обєкту. Цей метод НЕ перевизначається, ми його НЕ можемо перевизначити
    // Equals - метод дозволяє порівняти два обєкти. Щсобливість методу в тому, що він отримує в якості параметру порівнюваний обєкт, при  цьому обєкт передається як обєкт типу object


    class Clock
    {
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public int Seconds { set; get; }

        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
    }

    class Person_Object_modul
    {
        public string Name { set; get; }
        public override string ToString()
        {
            if (String.IsNullOrEmpty(Name))
                return base.ToString();
            return Name;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();    // число яке генерується з методу GetHashCode для типу String (в даному випадку Name)
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
                return false;

            Person_Object_modul person = (Person_Object_modul)obj;
            return this.Name == person.Name;
        }
    }

}

