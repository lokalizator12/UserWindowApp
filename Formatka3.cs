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
    public partial class Formatka3 : Form
    {
        public Formatka3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string s = "";
            int a = 0;
            try
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter integer number");
            }
            if (a > 0)
            {
                for (int y = 1; y <= a; y++)
                {
                    for (int x = 0; x < y; x++)
                    {
                        s += Convert.ToString(y) + " ";
                    }
                    listBox1.Items.Add(s);
                    s = "";
                }
            }
            else if (a < 0)
            {
                MessageBox.Show("Please enter a > 0");
            }
        }
    }
}
