using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
    class User
    {
        //1-Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
        string login, name, family;
        int age;
        public readonly DateTime date;

        public User()
        {
            this.date = DateTime.Now;
        }
        public User(string login,string name,string family,int age)
        {
            this.login = login;
            this.name = name;
            this.family = family;
            this.date = DateTime.Now;
        }

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                {
                    return "поле не заполнено";
                }
                else return login;
            }
        }

        public string Name
        {
            set { name = value; }
            get 
            {   if (name == null)
                    return "поле не заполнено";
                return name;             
            }
        }

        public string Family
        {
            set { family = value; }
            get
            {
                if (family == null)
                    return "поле не заполнено";
                return family;
            }
        }

        public int Age
        {
            set { age = value; }
            get
            {
                if ( age < 18)
                {
                    return 18 ;
                }
                else
                {
                    return age;
                }
            }
        }
    }
}
