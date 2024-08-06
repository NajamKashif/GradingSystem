using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
    class Admin:Person
    {
        dbconnection db = new dbconnection();
        public override void create()
        {
            string query = "";
            db.executequery(query,true);
        }
        public override DataTable read()
        {
            string query = "";
         return   db.executequery(query,false);
        }
        public override void update(int id)
        {
            string query = "";
            db.executequery(query,true);
        }
        public override void delete(int id)
        {
            string query = "";
            db.executequery(query,false);
        }
    }
}
