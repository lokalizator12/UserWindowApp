using System;
using System.Windows.Forms;

namespace UserWindowApp
{
    public partial class Formatka2 : Form
    {
        public Formatka2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   listBox1.Items.Clear();
            string s = "" ;
            int n = 0;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter integer number");
            }
            if (n > 0)
            {
                int[,] matrix = new int[n, n];
             
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        matrix[i, j] = (i + (j % 2)) % 2;
                        s += matrix[i, j].ToString();
                    }
                   listBox1.Items.Add(s);
                    s = "";
                }
            }
            else if (n < 0)
            {
                MessageBox.Show("Please enter a > 0");
            }

        }
    }
}
