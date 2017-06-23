namespace TSReports.Views
{
    partial class FormPrincipal
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
            if (disposing && (components != null))
            {
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
            this._formPrincipal_textBox_search = new System.Windows.Forms.TextBox();
            this._formPrincipal_panel1 = new System.Windows.Forms.Panel();
            this._formPrincipal_button_delete = new System.Windows.Forms.Button();
            this._formPrincipal_button_add = new System.Windows.Forms.Button();
            this._formPrincipal_treeView_reportes = new System.Windows.Forms.TreeView();
            this._formPrincipal_panel2 = new System.Windows.Forms.Panel();
            this._formPrincipal_flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this._formPrincipal_button_aplicar = new System.Windows.Forms.Button();
            this._formPrincipal_panel1.SuspendLayout();
            this._formPrincipal_panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _formPrincipal_textBox_search
            // 
            this._formPrincipal_textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formPrincipal_textBox_search.Location = new System.Drawing.Point(58, 3);
            this._formPrincipal_textBox_search.Name = "_formPrincipal_textBox_search";
            this._formPrincipal_textBox_search.Size = new System.Drawing.Size(273, 20);
            this._formPrincipal_textBox_search.TabIndex = 1;
            this._formPrincipal_textBox_search.TextChanged += new System.EventHandler(this._formPrincipal_textBox_search_TextChanged);
            // 
            // _formPrincipal_panel1
            // 
            this._formPrincipal_panel1.Controls.Add(this._formPrincipal_button_delete);
            this._formPrincipal_panel1.Controls.Add(this._formPrincipal_button_add);
            this._formPrincipal_panel1.Controls.Add(this._formPrincipal_treeView_reportes);
            this._formPrincipal_panel1.Controls.Add(this._formPrincipal_textBox_search);
            this._formPrincipal_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this._formPrincipal_panel1.Location = new System.Drawing.Point(0, 0);
            this._formPrincipal_panel1.Name = "_formPrincipal_panel1";
            this._formPrincipal_panel1.Size = new System.Drawing.Size(337, 435);
            this._formPrincipal_panel1.TabIndex = 5;
            // 
            // _formPrincipal_button_delete
            // 
            this._formPrincipal_button_delete.BackgroundImage = global::TSReports.Properties.Resources.delete1;
            this._formPrincipal_button_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._formPrincipal_button_delete.Location = new System.Drawing.Point(31, 3);
            this._formPrincipal_button_delete.Name = "_formPrincipal_button_delete";
            this._formPrincipal_button_delete.Size = new System.Drawing.Size(24, 21);
            this._formPrincipal_button_delete.TabIndex = 4;
            this._formPrincipal_button_delete.Text = "-";
            this._formPrincipal_button_delete.UseVisualStyleBackColor = true;
            this._formPrincipal_button_delete.Click += new System.EventHandler(this._formPrincipal_button_delete_Click);
            // 
            // _formPrincipal_button_add
            // 
            this._formPrincipal_button_add.BackColor = System.Drawing.Color.Transparent;
            this._formPrincipal_button_add.BackgroundImage = global::TSReports.Properties.Resources.add1;
            this._formPrincipal_button_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._formPrincipal_button_add.Location = new System.Drawing.Point(4, 3);
            this._formPrincipal_button_add.Name = "_formPrincipal_button_add";
            this._formPrincipal_button_add.Size = new System.Drawing.Size(21, 21);
            this._formPrincipal_button_add.TabIndex = 3;
            this._formPrincipal_button_add.UseVisualStyleBackColor = false;
            this._formPrincipal_button_add.Click += new System.EventHandler(this._formPrincipal_button_add_Click);
            // 
            // _formPrincipal_treeView_reportes
            // 
            this._formPrincipal_treeView_reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formPrincipal_treeView_reportes.Location = new System.Drawing.Point(4, 30);
            this._formPrincipal_treeView_reportes.Name = "_formPrincipal_treeView_reportes";
            this._formPrincipal_treeView_reportes.Size = new System.Drawing.Size(330, 402);
            this._formPrincipal_treeView_reportes.TabIndex = 2;
            this._formPrincipal_treeView_reportes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._formPrincipal_treeView_reportes_AfterSelect);
            // 
            // _formPrincipal_panel2
            // 
            this._formPrincipal_panel2.Controls.Add(this._formPrincipal_flowLayout);
            this._formPrincipal_panel2.Controls.Add(this._formPrincipal_button_aplicar);
            this._formPrincipal_panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._formPrincipal_panel2.Location = new System.Drawing.Point(337, 0);
            this._formPrincipal_panel2.Name = "_formPrincipal_panel2";
            this._formPrincipal_panel2.Size = new System.Drawing.Size(363, 435);
            this._formPrincipal_panel2.TabIndex = 6;
            // 
            // _formPrincipal_flowLayout
            // 
            this._formPrincipal_flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formPrincipal_flowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this._formPrincipal_flowLayout.Location = new System.Drawing.Point(7, 4);
            this._formPrincipal_flowLayout.Name = "_formPrincipal_flowLayout";
            this._formPrincipal_flowLayout.Size = new System.Drawing.Size(344, 390);
            this._formPrincipal_flowLayout.TabIndex = 2;
            // 
            // _formPrincipal_button_aplicar
            // 
            this._formPrincipal_button_aplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._formPrincipal_button_aplicar.Location = new System.Drawing.Point(276, 400);
            this._formPrincipal_button_aplicar.Name = "_formPrincipal_button_aplicar";
            this._formPrincipal_button_aplicar.Size = new System.Drawing.Size(75, 23);
            this._formPrincipal_button_aplicar.TabIndex = 1;
            this._formPrincipal_button_aplicar.Text = "Aplicar";
            this._formPrincipal_button_aplicar.UseVisualStyleBackColor = true;
            this._formPrincipal_button_aplicar.Click += new System.EventHandler(this._formPrincipal_button_aplicar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 435);
            this.Controls.Add(this._formPrincipal_panel2);
            this.Controls.Add(this._formPrincipal_panel1);
            this.Name = "FormPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSReports";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this._formPrincipal_panel1.ResumeLayout(false);
            this._formPrincipal_panel1.PerformLayout();
            this._formPrincipal_panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox _formPrincipal_textBox_search;
        private System.Windows.Forms.Panel _formPrincipal_panel1;
        private System.Windows.Forms.TreeView _formPrincipal_treeView_reportes;
        private System.Windows.Forms.Button _formPrincipal_button_add;
        private System.Windows.Forms.Button _formPrincipal_button_delete;
        private System.Windows.Forms.Panel _formPrincipal_panel2;
        private System.Windows.Forms.Button _formPrincipal_button_aplicar;
        private System.Windows.Forms.FlowLayoutPanel _formPrincipal_flowLayout;
    }
}