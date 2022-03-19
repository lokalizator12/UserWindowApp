using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserWindowApp
{
    public partial class Form1 : Form
    {
        bool pass1 = true;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pass1)
            {
                textBox2.UseSystemPasswordChar = false;
                pass1 = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                pass1 = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "anatoli" && textBox2.Text == "fatsik")
            {
                Form form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login or password is incorrectly");
            }
        }
    }
}
