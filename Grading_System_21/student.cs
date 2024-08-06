using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grading_System_21.Classes;

namespace Grading_System_21
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
      void read()
        {
            Student s = new Student();
            dataGridView1.DataSource = s.read();
        }
        private void student_Load(object sender, EventArgs e)
        {
            read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name =textBox1.Text;
            s.Age = Convert.ToInt32( textBox2.Text);
            s.Phone=textBox3.Text;
            s.Email =textBox4.Text;
            s.Password =textBox5.Text;
            s.bid.Bid =5;

            s.create();
            read();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.Age = Convert.ToInt32(textBox2.Text);
            s.Phone = textBox3.Text;
            s.Email = textBox4.Text;
            s.Password = textBox5.Text;
            s.bid.Bid = 5;

            s.update(id);
            read();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.delete(id);
            read();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          int i=  e.RowIndex;
            id= Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            read();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
