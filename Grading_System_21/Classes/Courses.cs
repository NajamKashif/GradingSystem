using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
    class Courses
    {
        int courseid;
        string coursecode;
        string name;
        int totalmarks;
        dbconnection db;

        public int Courseid
        {
            get
            {
                return courseid;
            }

            set
            {
                courseid = value;
            }
        }

        public string Coursecode
        {
            get
            {
                return coursecode;
            }

            set
            {
                coursecode = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Totalmarks
        {
            get
            {
                return totalmarks;
            }

            set
            {
                totalmarks = value;
            }
        }
        public void create()
        {
            string query = "";
            db.executequery(query,true);
        }
        public void read()
        {
            string query = "";
            db.executequery(query,false);
        }
        public void delete()
        {
            string query = "";
            db.executequery(query,false);
        }
        public void update()
        {
            string query = "";
            db.executequery(query,true);
        }
    }
}
