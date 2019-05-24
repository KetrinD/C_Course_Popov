using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 28. Модификатор static. Статические классы и члены классов

    class Account
    {
        // !!!! якщо клас має певні спільні стани у вигляді змінних і властивомтей, які розділяються всіма обєктами даного класу, 
        // то ці змінні і властивості мають мати модифікатор static

        //мінімальна допустима сума для всіх рахунків
        private static decimal minSum = 100;                     // загальний стан - представляє стан не окремого обєкта Account, а ВСІХ обєктів -  мінімальна допустима сума буде спільною для всіх ОБЄКТІВ класу Account
        public Account(decimal sum, decimal rate)        // конструктор, який приймає два параметри - суму на рахунок, і процентну ставку
        {
            if (sum < MinSum) throw new Exception("Недопустима сума");
            Sum = sum;
            Rate = rate;
        }

        public static decimal MinSum    // властивість через яку ми можемо управляти доступом до minSum - представляє стан не окремого обєкта Account, а ВСІХ обєктів
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        public decimal Sum { get; private set; }      //властивість - сума на рахунку. Зберігає окреме значення кожного обєкта Account
        public decimal Rate { get; private set; }     //властивість - процентна ставка. Зберігає окреме значення кожного обєкта Account


        //підрахунок суми на рахунку через визнчений період по визначеній ставці
        public static decimal GetSum(decimal sum, decimal rate, int period)    // представляє спільну поведінку для всіх обєктів класу Account, тому він теж буде static
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;

        }
    
    }
}
 