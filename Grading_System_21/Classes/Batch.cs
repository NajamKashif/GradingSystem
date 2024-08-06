using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
    class Batch
    {
        int bid;
        string session;
        int year;
        string department;
        dbconnection db;

        public int Bid
        {
            get
            {
                return bid;
            }

            set
            {
                bid = value;
            }
        }

        public string Session
        {
            get
            {
                return session;
            }

            set
            {
                session = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
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
    }
}
