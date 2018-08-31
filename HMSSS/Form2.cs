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
    public partial class Form2 : Form
    {
        double time;
        string path = "";
        public Form2()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer2.Interval = 5000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.path = openFileDialog1.FileName;
                //this.axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.URL = this.path;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.pause();
            time = this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = time;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            timer1.Interval = Convert.ToInt32(textBox1.Text) * 1000;
            timer2.Interval = Convert.ToInt32(textBox1.Text) * 1000;
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = time;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.pause();
            time = this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            timer2.Stop();
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 ob = new Form3();
            ob.Show();
        }
    }
}
