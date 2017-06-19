using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSReports.Services;
using TSReports.Utils.Exceptions;
using TSReports.Views;

namespace TSReports
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void _formLogin_button_login_Click(object sender, EventArgs e)
        {
            try {
                LoginService login_service = new LoginService();
                byte[] encodedPassword = new UTF8Encoding().GetBytes(_formLogin_textBox_password.Text);
                byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
                string password_md5 = BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();

                var response = login_service.Login(_formLogin_textBox_username.Text, password_md5);
                dynamic resp = JObject.Parse(response.Content);
                if (resp.code == 1) {
                    this.Hide();
                    var _formPrincipal = new FormPrincipal();
                    _formPrincipal.Closed += (s, args) => this.Close();
                    _formPrincipal.Show();
                } else {
                    MessageBox.Show((String)resp.msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            } catch (CustomException cex) { 
                throw cex;
            } catch (Exception ex) {
                throw new CustomException(ex);
            }
        }

    }
}
