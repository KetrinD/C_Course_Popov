using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 30. Перегрузка операций преобразования типов в языке C#
    
    class Counter_Modul_30
    {
        public int Seconds { set; get; }

        // explicit - явне перетворення
        // implicit - НЕявне перетворення
        public static implicit operator Counter_Modul_30(int x)   // після operator йде той тип, ДО якого ми хочемо виконати перетворення. в якості параметру передається той тип, яким ми хочемо претворити
        {
            return new Counter_Modul_30 { Seconds = x };
        }

        public static explicit operator int(Counter_Modul_30 x)   // після operator йде той тип, ДО якого ми хочемо виконати перетворення. в якості параметру передається той тип, яким ми хочемо претворити
        {
            return x.Seconds;
        }

        public static explicit operator Counter_Modul_30(Timer Timer)   
        {
            int h = Timer.Hours * 3600;
            int m = Timer.Minutes * 60;
            return new Counter_Modul_30 { Seconds = h + m + Timer.Seconds };
        }

        public static explicit operator Timer(Counter_Modul_30 counter)   
        {
            int h = counter.Seconds / 3600;
            int m = (counter.Seconds - h * 3600 ) / 60;
            int s = counter.Seconds - h * 3600 - m * 60;
            return new Timer { Hours = h, Minutes = m, Seconds = s };
        }

    }
    
    class Timer
    {
        public int Hours { set; get; }
        public int Minutes { set; get; }
        public int Seconds { set; get; }
    }

}
 