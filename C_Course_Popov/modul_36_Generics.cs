using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 36. Обобщения (generics) в языке программирования C#

    //  Узагальнені (generics) класи 

    class Account_generics <T>    // універсальний праметр <T> - замість нього можна предати будь який тип
    {
        public T Id { get; set; }
        public int Sum { get; set; }

    }

    class Transaction<U, V>
    {
        public U FromAccount { get; set; }
        public U ToAccount { get; set; }
        public V Code { get; set; }
    }


    //  Узагальнені (generics) методи 
    // розписані в -->  modul_20,23 

}


