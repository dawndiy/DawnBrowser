using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DawnBrowser
{
    public partial class TimeForm : Form
    {
        public TimeForm()
        {
            InitializeComponent();
        }


        int s = 0;

        private void TimeForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "当前时间：" + DateTime.Now.Hour + "时" + DateTime.Now.Minute + "分" + DateTime.Now.Second + "秒";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp=1;
            if (comboBox1.Text.Equals("秒"))
            {
                temp = 1;
            }
            else if (comboBox1.Text.Equals("分"))
            {
                temp = 60;
            }
            else if (comboBox1.Text.Equals("时"))
            {
                temp = 3600;
            }

            s = temp * int.Parse(textBox2.Text.ToString());

            timer2.Enabled = true;
            this.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s--==0)
            {
                this.TopMost = true;
                this.Show();
            }
            
        }
    }
}
