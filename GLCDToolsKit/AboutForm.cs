using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace GLCDToolsKit
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();


            VersionLbl.Text = Convert.ToString(Assembly.GetExecutingAssembly().GetName().Version);
           
            
        }

        private void AboutOKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(siteLink.Text);
        }
    }
}
