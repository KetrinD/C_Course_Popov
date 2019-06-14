using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    // Модуль 39. Интерфейсы. Видеокурс по языку C#

    // Інтерфейси дозволяють визначити певний функціонал - властивості і методи ,які не мають конкретної реалізації.
    // потім цей функціонал реалізують класи, які застосовують дані інтерфейси.
    // Інтерфейси починаються всі з букви "І"
    // перевагами інтерфейсів є те, що в класі ми можемо реалізувати одразу декілька інтерфейсів
    // інтерфейси також можуть наслідуватися від інших інтерфейсів, і на відміну відк класів які можуть наслідувати лише один клас, інтерфейси можуть наслідувтися від багатьох інтерфейсів
    // якщо при наслідуванні ми можемо наслідуватися клас лише від одного класу - то інтрефесів ми можемо реалізувати багато

    interface IAccount
    {
        int CurrentSum { get; }    // не використовуємо тут модифікатори доступу. По замовчуванню коли клас буде реалізувати ці властивості/методи ,вони будуть мти модифікатор  public
        void Put(int sum);
        void Withdraw(int sum);
    }

    interface IClient
    {
        string Name { get; set; }   
    }

    interface IClientAccount: IAccount, IClient // інтерфейси теж можуть наслідуватися один від одного. Але якщо інтерфейс IClientAccount буде реалізовуватися класом ,то клас повинен реалізувати як метод GetIncome, так і всі методи і властивості які визначені інтерфейсом IAccount та IClient  
    {
        void GetIncome();
    }


    class VipClient : IClientAccount    // клас реалізє як метод GetIncome з IClientAccount, так і всі методи і властивості які визначені інтерфейсами IAccount та IClient
    {
        public int CurrentSum => throw new NotImplementedException();

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetIncome()
        {
            throw new NotImplementedException();
        }

        public void Put(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }
    }


    class Client_39 : IAccount, IClient
    {
        int _sum;

        public string Name { get; set; } // реалізація інтерфесу  IClient

        public Client_39(string name, int sum)  // коструктор
        {
            Name = name;
            _sum = sum;
        }

        public int CurrentSum { get { return _sum; } }   // реалізували властивість CurrentSum яка визначена в інтрефейсі // реалізація інтерфесу  IAccount

        public void Put(int sum)
        {
            _sum += sum;
        }

        public void Withdraw(int sum)
        {
           if(_sum > sum) _sum -= sum;
        }
    }


}


