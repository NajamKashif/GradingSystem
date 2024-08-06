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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
         DataTable dt=   Authentication.login(textBox1.Text, textBox2.Text, comboBox1.Text);
         if(dt.Rows.Count==1)
            {
                if (comboBox1.Text == "student")
                {
                    studenthome s = new studenthome();
                    s.Show();
                }
                else if (comboBox1.Text == "teacher")
                {

                }
                else
                {
                    adminhome a = new adminhome();
                    a.Show();
                }
            }
              

        }
    }
}
