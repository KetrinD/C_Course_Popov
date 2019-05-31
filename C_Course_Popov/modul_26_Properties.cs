using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Course_Popov
{
    //Модуль 26. Свойства в языке программирования C#

    //свойства представлять собою спеціальні методи доступу через які ми можемо звертатися до полів класу або структури

    class Person_Properties
    {
        private string firstName;
        public string FirstName          // властивість - property. Кожна властивість може оприділяти два блоки - блок get і  блок set / управляє доступом до змінної firstName
        {
            get { return firstName; }         // цей блок вертає значення
            set { firstName = value; }        // у цьому блоці відбувається встановлення значення
        }


        //public int Age { get; set ; }   // - буде створюватися неявна змінна, і до неї буде звертатися властивість Age 

        private int age;
        public int Age
        {
            get { return age; }         // цей блок вертає значення age
            set
            {                       // у цьому блоці відбувається встановлення значення age
                if (value >= 0 && value < 99)
                    age = value;
            }
        }

        // ** variant#2 **
        //private int age;
        //public int Age
        //{
        //    get { return age; }                 // цей блок вертає значення age
        //    private set {  age = value; }       // у цьому блоці відбувається встановлення значення age. через модифікатор private значення встановлюється лише в межах класу Person_Properties. Зовні ми не можемо встановити значення age
        //}

        private string lastName;
        public string LastName        
        {
            set { lastName = value; }        // у цьому блоці відбувається встановлення значення (блок set). Через те, що немає блоку get - ми не можемо отримати значення перемінної lastName
        }

        
        public string FullName                           // властивість FullName - не привязана конкретно до якоїсь змінної
        {
            get { return $"{firstName} {lastName}"; }    // у цьому блоці відбувається отримання значення (блок get). Через те, що немає блоку set - ми не можемо встановити значення для FullName
        }
    }
}
