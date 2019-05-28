using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 29. Перегрузка операторов в языке программирования C#


    class Counter
    {
        public int Value { get; set; }

        // перегрузка операторів - представляє собою метод

        public static Counter operator +(Counter c1, Counter c2)  // модифікатори - public static, тип для повернення  - Counter, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це +
        {
            return new Counter { Value = c1.Value + c2.Value };
        }

        public static bool operator >(Counter c1, Counter c2)  // модифікатори - public static, тип для повернення  - bool, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це >
        {
            if (c1.Value > c2.Value)
                return true;
            else
                return false;
        }

        public static bool operator <(Counter c1, Counter c2)  // модифікатори - public static, тип для повернення  - bool, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це >
        {
             if (c1.Value < c2.Value)
              return true;
             else
                return false;
        }

    }


}
 