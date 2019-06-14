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



            //Модуль 31.Наследование в языке программирования C#

            Person_Nasliduvannja person_1 = new Person_Nasliduvannja("Bill", "Gates");
            Employee employee_1 = new Employee("Ilon", "Mask", "SpaceX");

            person_1.Display();
            employee_1.Display();



            //Модуль 32.Полиморфизм и переопределение методов.

            Person_Polimorfizm per_1 = new Person_Polimorfizm("Bill", "Gates");
            per_1.Display();

            Person_Polimorfizm empl_1 = new Employee_Polimorfizm("Ilon", "Mask", "SpaceX");     // обєкт класу Person_Polimorfizm, для створення якого використовується конструктор класу Employee_Polimorfizm 
            empl_1.Display();
            
            Employee_Polimorfizm empl_2 = new Employee_Polimorfizm("Steve", "Jobs", "Apple");
            empl_2.Display();



            //Модуль 33. Абстрактные классы и методы в языке программирования C#

            Person_Abstract_Modul client = new Client("Tom", "Smith", 500);                                  // для створення обекту Employee_Abstract_Modul використовується конструктор класу Client
            Person_Abstract_Modul employee_abs = new Employee_Abstract_Modul("Jerry", "Alba", "Manager");    // для створення обекту Employee_Abstract_Modul використовується конструктор класу Employee_Abstract_Modul

            client.Display();
            employee_abs.Display();


            //Модуль 34.Класс Object и его методы в языке программирования C#

            Person_Object_modul person_obj = new Person_Object_modul();
            Console.WriteLine(person_obj);   // ToString вертає рядяк (строку)

            Person_Object_modul person_obj_1 = new Person_Object_modul {Name = "SARAH"};
            Console.WriteLine(person_obj_1);   // ToString вертає рядяк (строку)

            Clock clock = new Clock { Hours = 1, Minutes = 34, Seconds = 23};
            Console.WriteLine(clock);


            Person_Object_modul person_obj_2 = new Person_Object_modul { Name = "Ketrin" };
            Console.WriteLine(person_obj_2.GetHashCode());
            Console.WriteLine(person_obj_2.GetType());                                         // GetType - метод дозволяє отримати тип обєкту 

            Person_Object_modul person_obj_3 = new Person_Object_modul { Name = "Ketrin" };   // для обєкту person_obj_2 та обєкту person_obj_3  GetHashCode співпадає, так як імена також співпадали
            Console.WriteLine(person_obj_3.GetHashCode());

            Person_Object_modul person_obj_4 = new Person_Object_modul { Name = "Julja" };
            Console.WriteLine(person_obj_4.GetHashCode());       


            Console.WriteLine(person_obj_1.Equals(person_obj_2));   // true  or false. поточний обєкт person_obj_1, для якого викликається метод Equals. Тобто це обєкт this в методі Equals. Обєкт person_obj_2 передається в якості параметру
            Console.WriteLine(person_obj_2.Equals(person_obj_3));   // true  or false



            //Модуль 35. Преобразование типов в языке программирования C#

            // перетворення "висхідне" - від похідних класів до базового
            Person_35 person_35_1 = new Employee_35 ( "Ketrin", "Sh","SpaceX" );        // змінна person_35_1 представляє тип Person_35, проте зберігає посилання на обєкт класу Employee_35.. перетворення з типу Employee_35 в тип Person_35 робиться автоматично компілятором, оск клас Employee_35 є похідним від класу Person_35. такі перетворення ще називають "висхідними"
            Person_35 person_35_2 = new Client_35("Ilon", "Mask","Lviv", 10000000);      // змінна person_35_2 представляє тип Person_35, проте зберігає посилання на обєкт класу Client_35

            //****
            // перетворення "спадне" - від базових класів до похідних  -
            // 1) через приведення типів
            // 2) через оператор as

            int sum = ((Client_35)person_35_2).Sum;      //мінна person_35_1 представляє тип Person_35, тому вона немає доступу до фунціоналу/властивостей/полів класу Employee_35ю Щоб отримати доступ до функціоналу Employee_35 треба привести змінну person_35_2 до типу Client_35:  ((Client_35)person_35_2)
            Console.WriteLine(sum);

            string company = ((Employee_35)person_35_1).Company;
            Console.WriteLine(company);

            // Спосіб #1 -  оператор as

            // ** невдале перетворення - ми не можемо перетворити змінну person_35_1 яка представляє тип Person_35 (і має ссилку на обєкт Employee_35) до класу Client_35

            Client_35 client_35_1 = person_35_1 as Client_35;     // перетворюємо person_35_1 яка представляє тип Person_35 (і має ссилку на обєкт Employee_35) до класу Client_35.  Якщо перетворення успішне, то змінна client_35_1 буде мати ссилку на обєкт даного типу (Client_35). Якшо перетворення не успішне, то змінна client_35_1 буде мати значення NULL
            if (client_35_1 != null)
            {
                int sum_2 = client_35_1.Sum;
                Console.WriteLine(sum_2);
            }
            else
            {
                Console.WriteLine("Перетворення завершилось невдало - оператор as");
            }

            // ** вдале перетворення - ми можемо перетворити змінну person_35_2 яка представляє тип Person_35 (і має ссилку на обєкт Client_35) до класу Client_35

            Client_35 client_35_2 = person_35_2 as Client_35;     // перетворюємо person_35_1 яка представляє тип Person_35 (і має ссилку на обєкт Employee_35) до класу Client_35.  Якщо перетворення успішне, то змінна client_35_1 буде мати ссилку на обєкт даного типу (Client_35). Якшо перетворення не успішне, то змінна client_35_1 буде мати значення NULL
            if (client_35_2 != null)
            {
                int sum_2 = client_35_2.Sum;
                Console.WriteLine(sum_2);
            }
            else
            {
                Console.WriteLine("Перетворення завершилось невдало");
            }

            // Спосіб #2 зловити помилки перетворення -  конструкція try-catch

            try
            {
                Client_35 client_35_3 = (Client_35)person_35_1;      // перетворюємо person_35_1 яка представляє тип Person_35 (і має ссилку на обєкт Employee_35) - буде викинуто помилку 
                int sum_3 = client_35_3.Sum;
                Console.WriteLine($"{sum_3} -  конструкція try-catch");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Перетворення завершилось невдало - конструкція try-catch");
            }

            // Спосіб #3 зловити помилки перетворення -  оператор is

            if (person_35_1 is Client_35)
            {
                Client_35 client_35_4 = (Client_35)person_35_1;      // перетворюємо person_35_1 яка представляє тип Person_35 (і має ссилку на обєкт Employee_35) - буде викинуто помилку 
                int sum_4 = client_35_4.Sum;
                Console.WriteLine($"{sum_4} -  оператор is");
            }
            else
            {
                Console.WriteLine("Перетворення завершилось невдало - оператор is");
            }


            

            //Модуль 36. Обобщения (generics) в языке программирования C#

            //  ** Узагальнені (generics) класи  **

            // коли було: class Account_generics та public int Id { get; set; }

            // Account_generics obj_gen_1 = new Account_generics();
            // Account_generics obj_gen_2 = new Account_generics();

            // проблема №1 - упаковка / розпаковка

            //obj_gen_1.Id = 45;   // коли було  - public int Id { get; set; } --> упаковка (boxing)  - представляє перетворення обєкта значимого типу (в даному випадку типу int) до типу object ( obj_gen_1.Id ). Тобто тип int пакується в тип object
            //obj_gen_2.Id = "586";

            //int intId = (int)obj_gen_1.Id;  // розпаковка (unboxing) - представляє перетворення обєкта значимого типу object до значимого типу (в даному випадку до типу int)
            //string strId = (string)obj_gen_2.Id;

            // проблема полягає в тому, що ми можемо точно не знати, яке значення зберігаються і передаються в властивості Id
            //int intId_2 = (int)obj_gen_2.Id;  // - викине помилку -  ми пробуємо получити значення з властивості obj_gen_2.Id (яка є string) в змінну типу int

            //Console.WriteLine($" int id: {intId}");
            //Console.WriteLine($" string id: {strId}");


            //**********************//
            // коли стало: class Account_generics <T> та - public T Id { get; set; }

            Account_generics<int> obj_gen_1 = new Account_generics<int>();                       // для пешого обєкта замість параметра Т буде паредаватися тип int. Властивість Id буде ориділятися як тип int
            Account_generics<string> obj_gen_2 = new Account_generics<string>();                // для другого обєкта замість параметра Т буде паредаватися тип string. Властивість Id буде ориділятися як тип string

            Account_generics<int> obj_gen_3 =  new Account_generics<int>();

            obj_gen_1.Id = 45;   // коли стало  - public T Id { get; set; }
            obj_gen_2.Id = "586";

            long intId = obj_gen_1.Id;          // тут вже немає розпаковки, нам не треба використовувати операцію приведння типів  - (long)obj_gen_1.Id
            string strId = obj_gen_2.Id;         // тут вже немає розпаковки, нам не треба використовувати операцію приведння типів  - (string)obj_gen_2.Id

            Console.WriteLine($" acc1: {intId}  acc2 {strId}");


            Transaction<Account_generics<int>, string> operation = new Transaction<Account_generics<int>, string>()     // ми можемо отипізувати обєкт іншим узагальненим типом - Account_generics<int> -передається замість параметра U
            {
                FromAccount = obj_gen_1,
                ToAccount = obj_gen_3,
                Code = "44555"
            };


            Transaction<int, string> operation2 = new Transaction<int, string>()     // ми можемо отипізувати обєкт іншим узагальненим типом - Account_generics<int> -передається замість параметра U
            {
                FromAccount = 8845,
                ToAccount = 1245,
                Code = "333521"
            };


            //  ** Узагальнені (generics) методи **

            int z = 34;
            int y = 6;
            Swap<int>(ref z, ref y);

            Console.WriteLine($"z: {z}  y:{y}");

            string s1 = "Tom";
            string s2 = "Jerry";
            Swap<string>(ref s1, ref s2);

            Console.WriteLine($"s1: {s1}  s2:{s2}");



            // Модуль 37. Ограничения обобщений в языке программирования C#


            Account_modul_37 acc1 = new Account_modul_37(23) { Sum = 4500 };
            Account_modul_37 acc2 = new Account_modul_37(55) { Sum = 5000 };

            DemandAccount demand_acc1 = new DemandAccount(102) { Sum = 4000 };
            DemandAccount demand_acc2 = new DemandAccount(125) { Sum = 3000 };


            Transaction_modul_37<Account_modul_37> t1 = new Transaction_modul_37<Account_modul_37>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 700
            };


            Transaction_modul_37<DemandAccount> t2 = new Transaction_modul_37<DemandAccount>
            {
                FromAccount = demand_acc1,
                ToAccount = demand_acc2,
                Sum = 700
            };
            
            t1.Execute();
            t2.Execute();


            //(generics) метод 
            Transact<Account_modul_37>(acc1, acc2, 900);




            //Модуль 38. Null и типы Nullable в языке программирования C#

            // значення Null вказує, що значення змінної не визначене - по суті змінна не має ніякого значення. Значення Null можуть мати змінні лише ссилочного типу
            // Значення Nullable  можуть мати змінні лише значимого типу

            //string name_38 = "Ketrin";
            // int age = null;       - змінна типу int є значимого типу, тому вона не може мати значення Null
            int? age = null;         // треба визначити цю змінну як змінну типу Nullable від int. Для цього після назви int ставиться ?  -->  (int?)

            // System.Nullable<int> age2 = null;    // int?  являється скороченням типу System.Nullable<int>

            //double? d_23 = null;
            //Country countryNull = null;

             // State? stateNullable = null;
            State? stateNullable2 = null; //  new State { Name = "Narnia"};   // виведе stateNullable2 is equel to null
            if (stateNullable2.HasValue == true)
            {
                State state = stateNullable2.Value;
                Console.WriteLine(state.Name);
            }
            else
            {
                Console.WriteLine("stateNullable2 is equel to null");
            }


            State? stateNullable3 =  new State { Name = "Narnia"};    // виведе Narnia
            if (stateNullable3.HasValue == true)
            {
                State state3 = stateNullable3.Value;
                Console.WriteLine(state3.Name);
            }
            else
            {
                Console.WriteLine("stateNullable2 is equel to null");
            }


            // метод  GetValueOrDefault  - даний метод повертає значення, якшо значення змінної визначено, або ж вертає значення по замовчуванню

            int? age3 = 5;
            int p = age3.Value;
            Console.WriteLine($"metod Value: age3 = {age3}");   // 5

            // int? age4 = null;
            // int p2 = age4.Value;       // System.InvalidOperationException: 'Nullable object must have a value.' буде на  int p2 = age4.Value;   немає доступу то методу Valu, оск = null
            // Console.WriteLine($"age4 = {age4}");   
            
            int? age5 = 15;
            int q_1 = age5.GetValueOrDefault();
            Console.WriteLine($"метод GetValueOrDefault: має значення: q_1 = {q_1}");    // 15
            
            int? age6 = null;
            int q_2 = age6.GetValueOrDefault();
            Console.WriteLine($"метод GetValueOrDefault: null:  q_2 = {q_2}");    // 0


            // null обєднання -->   ??  
            // Даний оператор приймає два операнди.
            // Перший операнд - має допускати значення null - може бути змінна яка представляє тип Nullable, або ж змінна ссилочного типу
            // Другий операнд  - має представляти якесь конкретне значення яке вертається в тому випадку, якшо перший операнд дорівнює null

            int? age7 = null;
            int q_3 = age7 ?? 10;
            Console.WriteLine($"оператор ??: q_3 = {q_3}");    // якщо змінна age7 буе мати значення, вернеться значення. Якщо змінна age7 = null, вернеться значення 10




            //  Модуль 39.Интерфейсы.Видеокурс по языку C#

            IAccount сlient = new Client_39("Tom", 3000);  // оприділити змінну типу IAccount  і присвоєти їй обєкти типу Client_39
            сlient.Put(500);
            Console.WriteLine(сlient.CurrentSum);

            сlient.Withdraw(600);
            Console.WriteLine(сlient.CurrentSum);


            Client_39 сlient_2 = (Client_39)сlient; // перетворення від базового типу (від інтерфейсу IAccount) до похідного Client_39
            string name_39 = ((Client_39)сlient).Name;
            Console.WriteLine(name_39);

            //або приведення через as
            Client_39 сlient_3 = сlient as Client_39; // перетворення від базового типу (від інтерфейсу IAccount) до похідного Client_39
            string name_39_2 = сlient_3.Name;
            Console.WriteLine(name_39_2);
            
            Console.WriteLine(name_39);



            // Модуль 40.Делегаты.Видеокурс по C#
            // делегат визначає новий тип і може бути створений обект цього типу

            Message message;    // визначаємо змінну message типу делегату Message

            // змінній message передаємо метод Display_40 (який відповідає типу цього делегату) на який буде вказувати змінна
            message = Display_40;    // метод Display_40 визначений в межах класу Program в файлі modul_20,23 

            //або можемо передати іншим способом - створити обєкт делегата Message, і в його коннструктор передати метод Display_40
            Message message_2;
            message_2 = new Message (Display_40);

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


        // **** Модуль 36. Обобщения (generics) в языке программирования C# ****

        //  Узагальнені (generics) методи 

        // метод буде обмінювати значення параметрів, які використовуються в цьому методі

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }


        //(generics) метод 
        public static void Transact<T>(T acc1, T acc2, int sum) where T: Account_modul_37
        {
            if (acc1.Sum > sum)
            {
                acc1.Sum -= sum;
                acc2.Sum += sum;
                Console.WriteLine($"{acc1.Id}: {acc1.Sum}  \n" +
                    $"{acc2.Id} : {acc2.Sum}");
            };
        }


        // **** Модуль 40.Делегаты.Видеокурс по C#

        static void Display_40()
        {
            Console.WriteLine("Hello");
        }


    }
}
