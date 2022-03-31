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
                button3.Visible = true;
                button4.Visible = true;
            }
            else
            {
                MessageBox.Show("Login or password is incorrectly");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formatkaA = new Formatka2();
            formatkaA.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formatkaB = new Formatka3();
            formatkaB.ShowDialog();
        }
    }
}
