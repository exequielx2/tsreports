namespace TSReports
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this._formLogin_groupBox1 = new System.Windows.Forms.GroupBox();
            this._formLogin_label_password = new System.Windows.Forms.Label();
            this._formLogin_label_username = new System.Windows.Forms.Label();
            this._formLogin_button_login = new System.Windows.Forms.Button();
            this._formLogin_textBox_password = new System.Windows.Forms.TextBox();
            this._formLogin_textBox_username = new System.Windows.Forms.TextBox();
            this._formLogin_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _formLogin_groupBox1
            // 
            this._formLogin_groupBox1.BackColor = System.Drawing.Color.Transparent;
            this._formLogin_groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._formLogin_groupBox1.Controls.Add(this._formLogin_label_password);
            this._formLogin_groupBox1.Controls.Add(this._formLogin_label_username);
            this._formLogin_groupBox1.Controls.Add(this._formLogin_button_login);
            this._formLogin_groupBox1.Controls.Add(this._formLogin_textBox_password);
            this._formLogin_groupBox1.Controls.Add(this._formLogin_textBox_username);
            this._formLogin_groupBox1.Location = new System.Drawing.Point(12, 12);
            this._formLogin_groupBox1.Name = "_formLogin_groupBox1";
            this._formLogin_groupBox1.Size = new System.Drawing.Size(251, 139);
            this._formLogin_groupBox1.TabIndex = 0;
            this._formLogin_groupBox1.TabStop = false;
            this._formLogin_groupBox1.Text = "Login";
            // 
            // _formLogin_label_password
            // 
            this._formLogin_label_password.AutoSize = true;
            this._formLogin_label_password.Location = new System.Drawing.Point(3, 68);
            this._formLogin_label_password.Name = "_formLogin_label_password";
            this._formLogin_label_password.Size = new System.Drawing.Size(56, 13);
            this._formLogin_label_password.TabIndex = 4;
            this._formLogin_label_password.Text = "Password:";
            // 
            // _formLogin_label_username
            // 
            this._formLogin_label_username.AutoSize = true;
            this._formLogin_label_username.Location = new System.Drawing.Point(3, 35);
            this._formLogin_label_username.Name = "_formLogin_label_username";
            this._formLogin_label_username.Size = new System.Drawing.Size(58, 13);
            this._formLogin_label_username.TabIndex = 3;
            this._formLogin_label_username.Text = "Username:";
            // 
            // _formLogin_button_login
            // 
            this._formLogin_button_login.Location = new System.Drawing.Point(6, 106);
            this._formLogin_button_login.Name = "_formLogin_button_login";
            this._formLogin_button_login.Size = new System.Drawing.Size(236, 23);
            this._formLogin_button_login.TabIndex = 2;
            this._formLogin_button_login.Text = "Ingresar";
            this._formLogin_button_login.UseVisualStyleBackColor = true;
            this._formLogin_button_login.Click += new System.EventHandler(this._formLogin_button_login_Click);
            // 
            // _formLogin_textBox_password
            // 
            this._formLogin_textBox_password.Location = new System.Drawing.Point(67, 65);
            this._formLogin_textBox_password.MaxLength = 30;
            this._formLogin_textBox_password.Name = "_formLogin_textBox_password";
            this._formLogin_textBox_password.PasswordChar = '*';
            this._formLogin_textBox_password.Size = new System.Drawing.Size(175, 20);
            this._formLogin_textBox_password.TabIndex = 1;
            this._formLogin_textBox_password.UseSystemPasswordChar = true;
            // 
            // _formLogin_textBox_username
            // 
            this._formLogin_textBox_username.Location = new System.Drawing.Point(67, 35);
            this._formLogin_textBox_username.MaxLength = 30;
            this._formLogin_textBox_username.Name = "_formLogin_textBox_username";
            this._formLogin_textBox_username.Size = new System.Drawing.Size(175, 20);
            this._formLogin_textBox_username.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AcceptButton = this._formLogin_button_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(274, 166);
            this.Controls.Add(this._formLogin_groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRReports";
            this.TopMost = true;
            this._formLogin_groupBox1.ResumeLayout(false);
            this._formLogin_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _formLogin_groupBox1;
        private System.Windows.Forms.Button _formLogin_button_login;
        private System.Windows.Forms.TextBox _formLogin_textBox_password;
        private System.Windows.Forms.TextBox _formLogin_textBox_username;
        private System.Windows.Forms.Label _formLogin_label_password;
        private System.Windows.Forms.Label _formLogin_label_username;
    }
}

