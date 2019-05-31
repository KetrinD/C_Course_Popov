using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Course_Popov
{
    class Program
    {
        static void Main(string[] args)
        {

            // ***** Модуль 20. Переменные-ссылки и получение ссылки в языке C#

            //--Переменные-ссылки--

            //int x = 5;
            //ref int xRef = ref x;

            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"Refx={xRef}");

            //xRef = 185;

            //Console.WriteLine($"x={x}");
            //Console.WriteLine($"Refx={xRef}");

        
                   // --Получение ссылки с метода--

            //int[] numbers1 = { 1, 2, 3, 4, 5, 6 };
            //ref int nRef = ref Find(numbers1, 5); // 4
            //Console.WriteLine(numbers1[4]); //5

            //nRef = 150;
     
            //Console.WriteLine(numbers1[4]); // 150

            
                      
            //  ***** Модуль 23. Объекты классов как параметры методов в языке C#

            //User user1 = new User {name = "Tom", age = 36};
            ////User.ChangeUser(user1);          // параметр user1 передається в метод ChangeUser по значенню => метод отримує КОПІЮ обєкту, тому всі дії методу не впливають на обєкт user1
            //User.ChangeUser(ref user1);        // параметр user1 передається в метод ChangeUser по ссилці => метод отримує ссилку на обєкт user1, тому всі дії методу ВПЛИВАЮТЬ на обєкт user1                          
            //Console.WriteLine($"name = {user1.name} age = {user1.age}");

            Person person1 = new Person { name = "Olga", age = 29 }; // змінна person1 збергігає ССИЛКУ на обєкт в кучі
            // Person.ChangePerson(person1);         // параметр person1 передається в метод ChangePerson по значенню => метод отримує КОПІЮ ССИЛКИ на обєкт
            Person.ChangePerson(ref person1);         // параметр person1 передається в метод ChangePerson по ссилці => метод отримує саму ССИЛКУ на обєктю а не її копію
            Console.WriteLine($"name = {person1.name} age = {person1.age}");

            int r = MathLib.T; // константа

            MathLib m = new MathLib(); // для доступу до readonly поля для читання треба створити обєкт класу MathLib. і через обєкт доступитися до поля р
            int u = m.p;

                        

            //   ***** Модуль 26. Свойства в языке программирования C#  *****

            Person_Properties person = new Person_Properties();
            person.FirstName = "Jerry";             // тут спрацьовує блок set / значення "Jerry" буде передватаися через ключове слово value
            string name = person.FirstName;         // тут спрацьовує блок get
            Console.WriteLine(person.FirstName);    // тут спрацьовує блок get

            person.Age = 18;                        // тут спрацьовує блок set
            Console.WriteLine(person.Age);          // тут спрацьовує блок get // 18

            person.Age = -26;                       // значення поза умовою дозволених
            Console.WriteLine(person.Age);          // 18


            person.LastName = "Simson";
            //Console.WriteLine(person.LastName);   - LastName має лише блок set, тому не може бути виведеним, оск блоку get немає
            Console.WriteLine(person.FullName);   // Jerry Simson 



            //   ***** Модуль 28. Модификатор static. Статические классы и члены классов в языке C#  *****

            Account.MinSum = 200;
            decimal d = Account.GetSum(1000, 10, 5);
            Console.WriteLine(d);

            UserStatic userStatic1 = new UserStatic();
            UserStatic userStatic2 = new UserStatic();
            UserStatic userStatic3 = new UserStatic();
            UserStatic userStatic4 = new UserStatic();
            UserStatic userStatic5 = new UserStatic();

            Console.WriteLine(userStatic1.Id);
            Console.WriteLine(userStatic3.Id);
            Console.WriteLine(userStatic4.Id);
             
            UserStatic.Display();  // виведе число 5 - створено 5 обєктів


            // Модуль 29. Перегрузка операторов в языке программирования C#

            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };
            Counter c4 = new Counter { Value = 36 };

            bool result = c1 > c2;
            Console.WriteLine(result);

            Counter c3 = c2 + c1;
            Console.WriteLine(c3.Value);

            Counter c5 = c2 + c4;
            Console.WriteLine(c5.Value);

            int c6 = c2 + 23;
            Console.WriteLine(c6);


            // Модуль 30. Перегрузка операций преобразования типов в языке C#

            Counter_Modul_30 counter1 = new Counter_Modul_30 { Seconds = 115 };
            int x = (int)counter1;
            Counter_Modul_30 counter2 = x;

            Timer timer1 = (Timer)counter1;                //1:55
            Console.WriteLine($"{timer1.Hours}:{timer1.Minutes}:{timer1.Seconds}");

            Counter_Modul_30 counter3 = (Counter_Modul_30)timer1;     //115 
            Console.WriteLine($"{counter3.Seconds}");

            Console.ReadKey();
        }







        // ***** Модуль 20. Переменные-ссылки и получение ссылки в языке C#

        static ref int Find(int[] numbers, int number)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    return ref numbers[i];    // получение ссылки из метода
                }
            }
            throw new Exception("число не знайдено");
        }

      
    }
}
