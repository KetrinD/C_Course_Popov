using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 23. Объекты классов как параметры методов в языке C#

    class Person
    {
        public int age;
        public string name;

        // static void ChangePerson(Person person)  // --> параметр ссилочного типу передається в метод ChangePerson по значенню (обєкт класу) - метод отримує КОПІЮ ССИЛКИ на обєкт. І копія ссилки і вихідна ссилка посилаються на один обєкт в кучі
        //{
        //    person.name = "Ketrin";
        //    person.age = 25;
        //    person = new Person { name = "Ira", age = 32 }; // при передачі параметру ссилочного типу по значенню метод отримує копію ссилки, по цій ссилці змінює обєкт в кучі. Aле коли ми використовуємо конструктор для створення обєкта - в кучі створюється НОВИЙ обєкт.
        //    // тому параметр person буде вказуввати на НОВИЙ обєект в кучі, а змінна person1 буде вказувати на старий обєкт в кучі
        //} 

        public static void ChangePerson(ref Person person) // --> параметр ссилочного типу передається в метод ChangePerson по ссилці (обєкт класу) - метод отримує саму ССИЛКУ на обєкт, а не копію ссилки.

        {
            person.name = "Ketrin";
            person.age = 25;
            person = new Person { name = "Ira", age = 32 };
        }

    }
}
