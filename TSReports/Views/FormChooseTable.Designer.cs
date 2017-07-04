namespace TSReports.Views
{
    partial class FormChooseTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._formChoseColumns_buttonOk = new System.Windows.Forms.Button();
            this._formChoseColumns_listBoxDestinos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._formChoseColumns_listBoxCampos = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _formChoseColumns_buttonOk
            // 
            this._formChoseColumns_buttonOk.Location = new System.Drawing.Point(269, 300);
            this._formChoseColumns_buttonOk.Name = "_formChoseColumns_buttonOk";
            this._formChoseColumns_buttonOk.Size = new System.Drawing.Size(75, 23);
            this._formChoseColumns_buttonOk.TabIndex = 0;
            this._formChoseColumns_buttonOk.Text = "Aceptar";
            this._formChoseColumns_buttonOk.UseVisualStyleBackColor = true;
            this._formChoseColumns_buttonOk.Click += new System.EventHandler(this._formChoseColumns_buttonOk_Click);
            // 
            // _formChoseColumns_listBoxDestinos
            // 
            this._formChoseColumns_listBoxDestinos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formChoseColumns_listBoxDestinos.FormattingEnabled = true;
            this._formChoseColumns_listBoxDestinos.Location = new System.Drawing.Point(6, 19);
            this._formChoseColumns_listBoxDestinos.Name = "_formChoseColumns_listBoxDestinos";
            this._formChoseColumns_listBoxDestinos.Size = new System.Drawing.Size(320, 121);
            this._formChoseColumns_listBoxDestinos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._formChoseColumns_listBoxDestinos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 144);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relación:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._formChoseColumns_listBoxCampos);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 132);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos:";
            // 
            // _formChoseColumns_listBoxCampos
            // 
            this._formChoseColumns_listBoxCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formChoseColumns_listBoxCampos.FormattingEnabled = true;
            this._formChoseColumns_listBoxCampos.Location = new System.Drawing.Point(6, 18);
            this._formChoseColumns_listBoxCampos.Name = "_formChoseColumns_listBoxCampos";
            this._formChoseColumns_listBoxCampos.Size = new System.Drawing.Size(320, 108);
            this._formChoseColumns_listBoxCampos.TabIndex = 2;
            // 
            // FormChoseTable
            // 
            this.AcceptButton = this._formChoseColumns_buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._formChoseColumns_buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChoseTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Destino";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _formChoseColumns_buttonOk;
        private System.Windows.Forms.ListBox _formChoseColumns_listBoxDestinos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox _formChoseColumns_listBoxCampos;
    }
}