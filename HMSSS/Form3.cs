using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMSSS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private static int c = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "rahul123" && textBox2.Text == "123456")
            {

            }
            else
            {
                if (c == 3)
                    Application.Exit();
                else
                {
                    MessageBox.Show("invalid user name.");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    c++;
                }
                   
            }
        }
    }
}
