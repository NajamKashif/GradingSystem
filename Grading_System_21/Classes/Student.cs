using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_System_21.Classes
{
    class Student:Person
    {    
       public Batch bid=new Batch();
        dbconnection db=new dbconnection();
        public override void create()
        {
            string query = $@"insert into student
                (Name,Age,Phone,Email,Password,batchid)
                values('{this.Name}',{this.Age},'{this.Phone}'
                ,'{this.Email}','{this.Password}',{this.bid.Bid})";
            db.executequery(query,true);
        }
        public override DataTable read()
        {
            string query = "select * from student";
          return  db.executequery(query,false);
        }
        public override void update(int id)
        {
            string query = $@"update student
                set Name='{this.Name}',Age={this.Age},
        Phone='{this.Phone}',Email='{this.Email}',
        Password='{this.Password}',batchid={this.bid.Bid}
               where  StudentId={id}";
            db.executequery(query,true);
        }
        public override void delete(int id)
        {
            string query = $"delete from student where StudentId={id}";
            db.executequery(query,false);
        }
       
    }
}
