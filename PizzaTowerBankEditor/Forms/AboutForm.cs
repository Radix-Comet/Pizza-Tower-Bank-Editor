using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaTowerBankEditor.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void deltomCarrdLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            deltomCarrdLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://deltomx3.carrd.co/") { UseShellExecute = true });
        }

        private void radixCometLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            radixCometLinkLabel.LinkVisited = true;

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://twitter.com/RadixComet") { UseShellExecute = true });
        }
    }
}
