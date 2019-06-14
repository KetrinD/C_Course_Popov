using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 37. Ограничения обобщений в языке программирования C#

    class Transaction_modul_37<T> where T: Account_modul_37  // обмеження визначається так -->   where T: Account_modul_37    -->   параметр Т, який обмежуємо. Account_modul_37 - тип, яким обмежуємо.
    {


        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }  // сума переводу
    
        //виконуємо перевід
        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -=  Sum;
                ToAccount.Sum +=  Sum;
                Console.WriteLine($"{FromAccount.Id}: {FromAccount.Sum}  \n" +
                    $"{ToAccount.Id} : {ToAccount.Sum}");
            };
        }
    
    }

    
    class Account_modul_37
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public Account_modul_37(int id)
        {
            Id = id;
        }
    }

    class DemandAccount: Account_modul_37
    {
           public DemandAccount(int id): base (id)
        {
        }
    }


}


