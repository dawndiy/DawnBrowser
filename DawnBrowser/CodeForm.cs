using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DawnBrowser
{
    public partial class CodeForm : Form
    {
        public CodeForm()
        {
            InitializeComponent();
        }

        public string Code
        {
            get
            {
                if (richTextBox1.Text != null)
                {
                    return (richTextBox1.Text);
                }
                else
                {
                    return ("");
                }
            }
            set
            {
                richTextBox1.Text = value;
            }
        }
    }
}
