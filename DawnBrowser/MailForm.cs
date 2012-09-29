using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace DawnBrowser
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text=="")
            {
                MessageBox.Show("请选择邮箱!");
            }else if (textBox1.Text=="")
            {
                MessageBox.Show("请填写用户名!");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("请填写密码!");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("请填目标邮箱!");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("请填主题!");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("请填内容!");
            }
            else { 



            string smtp = "smtp."+comboBox1.Text;
            string name= textBox1.Text;
            string fadd = name + "@" + comboBox1.Text;
            string pwd = textBox2.Text;
            string tadd = textBox3.Text;
            string item = textBox4.Text;
            string msgtext = textBox5.Text;



            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(fadd);
            msg.To.Add(new MailAddress(tadd));
            msg.Subject = item;
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = msgtext;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Host = smtp;
            //client.Port = 25;
            client.Credentials = new System.Net.NetworkCredential(name, pwd);

            try
            {
                client.Send(msg);
                MessageBox.Show("OK!发送成功!");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                MessageBox.Show(ex.Message, "发送邮件出错");
            }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
