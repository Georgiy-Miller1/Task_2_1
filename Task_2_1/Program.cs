using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class Program
    {
        /*
         1-Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата 
           заполнения анкеты). 
         2-Поле дата заполнения анкеты должно быть проинициализировано только один раз 
           (при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
         3-Реализуйте вывод на экран информации о пользователе.
        */
        static void Main(string[] args)
        {
            
            User user = new User();
            Console.WriteLine(user.date.ToString());


        }
    }
}
