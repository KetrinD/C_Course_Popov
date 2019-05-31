using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 29. Перегрузка операторов в языке программирования C#

    // перегрузка операторів - представляє собою метод

    //можемо пергружати наступні операції:
    // -, !, ~, ++, --
    // +, -, *, /
    // ==, !=, >, <, >=, <=
    // &&, ||
    // +=, -=, *=

    // НЕ можемо пергружати наступні операції:
    // =, ?:

        
    class Counter
    {
        public int Value { get; set; }
              
        public static Counter operator +(Counter z1, Counter z2)  // модифікатори - public static, тип для повернення  - Counter, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це +
        {
            return new Counter { Value = z1.Value + z2.Value };
        }

        public static int operator +(Counter z1, int x)  
        {
            return z1.Value + x ;
        }

        // в операторах не повинні міняти ті обєкти, які передаються в якості параметрів

        public static Counter operator ++(Counter z1)  //-> буде діяти я префіксний і постфіксний інкремент
        { 
            //z1.Value = z1.Value + 1;
            //return z1;                 -> !!! це неправильне оприділення оператора, оск ми не повинні мвняти обєкти, які передаються в якості параметрів

            return new Counter { Value = z1.Value + 1 };
        }

        public static bool operator >(Counter z1, Counter z2)  // модифікатори - public static, тип для повернення  - bool, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це >
        {
            if (z1.Value > z2.Value)
                return true;
            else
                return false;
        }

        public static bool operator <(Counter z1, Counter z2)  // модифікатори - public static, тип для повернення  - bool, далі ключове слово operstor, а далі сам поператор який треба перегрузити -> в даному випадку це <
        {
             if (z1.Value < z2.Value)
              return true;
             else
                return false;
        }

    }


}
 