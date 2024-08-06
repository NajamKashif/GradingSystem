using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
 abstract   class Person
    {
        int id;//9
        string name;
        int age;
        string phone;
        string email;
        string password;

        public int ID//9
        {
            set
            {
                if (value <= 0)
                {
                    //throw exception
                    throw new Exception("Id Cannt <=0 ");
                }
                id = value;//9
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                if (value == null || value == "")
                {
                    throw new Exception("Please Provide Name");
                }
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public abstract void create();
        public abstract DataTable read();
        public abstract void update(int id);
        public abstract void delete(int id);
    }
}
