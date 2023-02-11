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

            //вывод время созданания обьекта user 
            Console.WriteLine(user.date.ToString());

            //Вывод фамилии на экран
            Console.WriteLine(user.Family);

            //присвоение логина пользователя
            Console.WriteLine("Введите логин пользователя...");
            user.Login = Convert.ToString(Console.ReadLine());

            //вводи имени 
            Console.WriteLine("Введите имя пользователя...");
            user.Name = Convert.ToString(Console.ReadLine());

            //ввод фамилии
            Console.WriteLine("Введие фамилию пользователя...");
            user.Family = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Дата создания анкеты:{user.date.ToString()}");
            Console.WriteLine($"Логин:{user.Login},Имя:{user.Name},Фамилия:{user.Family}");

            Console.WriteLine(new string('-',30));

            User user2 = new User("djd", "dfdf", "edde", 34);
            Console.WriteLine(user2.date.ToString(),user2.Name,user2.Family,user2.Login);

            Console.ReadKey();
        }
    }
}
