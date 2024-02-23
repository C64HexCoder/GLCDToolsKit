using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Microsoft.Win32;

namespace GLCDToolsKit
{
    public partial class Registration : Form
    {
        RegistryKey glcdkey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\GLCD Tollskit");
        SKGL.Validate skgl = new SKGL.Validate();

        public Registration()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            if (txtPassword.Text.Length != 0)
            {
                
                //this.DialogResult = DialogResult.OK;
                skgl.Key = txtSerialKey.Text;
                skgl.secretPhase = txtPassword.Text;
                

                if (skgl.IsValid)
                {
                    //Aes myAes = Aes.Create();
                    txtStatus.Text = "Serial key VALID! \r\n" + "Days Left: " + skgl.DaysLeft.ToString();
                    glcdkey.SetValue("Serial Key", txtSerialKey.Text);
                    //byte[] EncriptedPassword = mic
                    glcdkey.SetValue("Password", txtPassword.Text);
                    txtPassword.Enabled = false;

                    DialogResult = DialogResult.Yes;


                }
                else
                    MessageBox.Show("Serial Key Or passward is not valid!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
               
              
            }
              else
                    MessageBox.Show("Please enter password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {
    
        }

        private void Registration_Activated(object sender, EventArgs e)
        {
            String SerialKey;

            try
            {
                if ((SerialKey = glcdkey.GetValue("Serial Key").ToString()) != null)
                {
                    String Password = glcdkey.GetValue("Password").ToString();

                    skgl.Key = SerialKey;
                    skgl.secretPhase = Password;

                    if (skgl.IsValid && !skgl.IsExpired)
                    {
                        txtStatus.Text = "Serial key VALID! \r\n" + "Days Left: " + skgl.DaysLeft.ToString();
                        btnValidate.Enabled = false;

                        txtSerialKey.Text = SerialKey;
                        txtSerialKey.Enabled = false;

                        txtPassword.Text = Password;
                        txtPassword.Enabled = false;

                        txtStatus.Enabled = false;
                    }
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
