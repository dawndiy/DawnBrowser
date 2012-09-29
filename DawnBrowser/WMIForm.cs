using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace DawnBrowser
{
    public partial class WMIForm : Form
    {
        public WMIForm()
        {
            InitializeComponent();
        }

        private void WMIForm_Load(object sender, EventArgs e)
        {
            SelectQuery sq = new SelectQuery("Win32_OperatingSystem");
            ManagementObjectSearcher mos = new ManagementObjectSearcher(sq);
            ManagementObjectCollection moc = mos.Get();
            foreach (ManagementObject mo in moc)
            {
                foreach (PropertyData pd in mo.Properties)
                {
                    richTextBox1.AppendText(pd.Name + ":" + pd.Value + "\n");
                }
            }
            moc.Dispose();
            mos.Dispose();
            sq = null;
        }
    }
}
