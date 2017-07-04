namespace TSReports.Views
{
    partial class FormAdd
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Cargando tablas...");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this._formAdd_treeViewReportes = new System.Windows.Forms.TreeView();
            this._formAdd_listBoxColumns = new System.Windows.Forms.ListBox();
            this._formAdd_panelPropColumns = new System.Windows.Forms.Panel();
            this._formAdd_checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._formAdd_radioButtonDesc = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this._formAdd_radioButtonAsc = new System.Windows.Forms.RadioButton();
            this._formAdd_textBoxFilter = new System.Windows.Forms.TextBox();
            this._formAdd_panelTop = new System.Windows.Forms.Panel();
            this._formAdd_comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this._formAdd_ButtonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._formAdd_textBoxNombre = new System.Windows.Forms.TextBox();
            this._formAdd_dataGridViewFilters = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._formAdd_buttonDelete = new System.Windows.Forms.Button();
            this._formAdd_buttonDownColumn = new System.Windows.Forms.Button();
            this._formAdd_buttonUpColumn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._formAdd_panelPropColumns.SuspendLayout();
            this._formAdd_panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._formAdd_dataGridViewFilters)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _formAdd_treeViewReportes
            // 
            this._formAdd_treeViewReportes.AllowDrop = true;
            this._formAdd_treeViewReportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._formAdd_treeViewReportes.Location = new System.Drawing.Point(6, 48);
            this._formAdd_treeViewReportes.Name = "_formAdd_treeViewReportes";
            treeNode2.Name = "Nodo0";
            treeNode2.Text = "Cargando tablas...";
            this._formAdd_treeViewReportes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this._formAdd_treeViewReportes.Size = new System.Drawing.Size(188, 325);
            this._formAdd_treeViewReportes.TabIndex = 0;
            this._formAdd_treeViewReportes.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this._formAdd_treeViewReportes_AfterCollapse);
            this._formAdd_treeViewReportes.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this._formAdd_treeViewReportes_AfterExpand);
            this._formAdd_treeViewReportes.DoubleClick += new System.EventHandler(this._formAdd_treeViewReportes_DoubleClick);
            // 
            // _formAdd_listBoxColumns
            // 
            this._formAdd_listBoxColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._formAdd_listBoxColumns.FormattingEnabled = true;
            this._formAdd_listBoxColumns.Location = new System.Drawing.Point(9, 19);
            this._formAdd_listBoxColumns.MultiColumn = true;
            this._formAdd_listBoxColumns.Name = "_formAdd_listBoxColumns";
            this._formAdd_listBoxColumns.Size = new System.Drawing.Size(178, 264);
            this._formAdd_listBoxColumns.TabIndex = 4;
            this._formAdd_listBoxColumns.SelectedIndexChanged += new System.EventHandler(this._formAdd_listBoxColumns_SelectedIndexChanged);
            this._formAdd_listBoxColumns.DoubleClick += new System.EventHandler(this._formAdd_listBoxColumns_DoubleClick);
            // 
            // _formAdd_panelPropColumns
            // 
            this._formAdd_panelPropColumns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._formAdd_panelPropColumns.Controls.Add(this._formAdd_checkBoxVisible);
            this._formAdd_panelPropColumns.Controls.Add(this.textBox1);
            this._formAdd_panelPropColumns.Controls.Add(this._formAdd_radioButtonDesc);
            this._formAdd_panelPropColumns.Controls.Add(this.label3);
            this._formAdd_panelPropColumns.Controls.Add(this._formAdd_radioButtonAsc);
            this._formAdd_panelPropColumns.Location = new System.Drawing.Point(9, 294);
            this._formAdd_panelPropColumns.Name = "_formAdd_panelPropColumns";
            this._formAdd_panelPropColumns.Size = new System.Drawing.Size(178, 79);
            this._formAdd_panelPropColumns.TabIndex = 6;
            this._formAdd_panelPropColumns.Visible = false;
            // 
            // _formAdd_checkBoxVisible
            // 
            this._formAdd_checkBoxVisible.AutoSize = true;
            this._formAdd_checkBoxVisible.Checked = true;
            this._formAdd_checkBoxVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this._formAdd_checkBoxVisible.ForeColor = System.Drawing.Color.Black;
            this._formAdd_checkBoxVisible.Location = new System.Drawing.Point(7, 57);
            this._formAdd_checkBoxVisible.Name = "_formAdd_checkBoxVisible";
            this._formAdd_checkBoxVisible.Size = new System.Drawing.Size(56, 17);
            this._formAdd_checkBoxVisible.TabIndex = 7;
            this._formAdd_checkBoxVisible.Text = "Visible";
            this._formAdd_checkBoxVisible.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 4;
            // 
            // _formAdd_radioButtonDesc
            // 
            this._formAdd_radioButtonDesc.AutoSize = true;
            this._formAdd_radioButtonDesc.ForeColor = System.Drawing.Color.Black;
            this._formAdd_radioButtonDesc.Location = new System.Drawing.Point(86, 33);
            this._formAdd_radioButtonDesc.Name = "_formAdd_radioButtonDesc";
            this._formAdd_radioButtonDesc.Size = new System.Drawing.Size(89, 17);
            this._formAdd_radioButtonDesc.TabIndex = 6;
            this._formAdd_radioButtonDesc.Text = "Descendente";
            this._formAdd_radioButtonDesc.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alias:";
            // 
            // _formAdd_radioButtonAsc
            // 
            this._formAdd_radioButtonAsc.AutoSize = true;
            this._formAdd_radioButtonAsc.Checked = true;
            this._formAdd_radioButtonAsc.ForeColor = System.Drawing.Color.Black;
            this._formAdd_radioButtonAsc.Location = new System.Drawing.Point(7, 33);
            this._formAdd_radioButtonAsc.Name = "_formAdd_radioButtonAsc";
            this._formAdd_radioButtonAsc.Size = new System.Drawing.Size(82, 17);
            this._formAdd_radioButtonAsc.TabIndex = 5;
            this._formAdd_radioButtonAsc.TabStop = true;
            this._formAdd_radioButtonAsc.Text = "Ascendente";
            this._formAdd_radioButtonAsc.UseVisualStyleBackColor = true;
            // 
            // _formAdd_textBoxFilter
            // 
            this._formAdd_textBoxFilter.Location = new System.Drawing.Point(5, 19);
            this._formAdd_textBoxFilter.Name = "_formAdd_textBoxFilter";
            this._formAdd_textBoxFilter.Size = new System.Drawing.Size(189, 20);
            this._formAdd_textBoxFilter.TabIndex = 8;
            this._formAdd_textBoxFilter.TextChanged += new System.EventHandler(this._formAdd_textBoxFilter_TextChanged);
            // 
            // _formAdd_panelTop
            // 
            this._formAdd_panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._formAdd_panelTop.Controls.Add(this._formAdd_comboBoxGrupo);
            this._formAdd_panelTop.Controls.Add(this._formAdd_ButtonSave);
            this._formAdd_panelTop.Controls.Add(this.label2);
            this._formAdd_panelTop.Controls.Add(this.label1);
            this._formAdd_panelTop.Controls.Add(this._formAdd_textBoxNombre);
            this._formAdd_panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._formAdd_panelTop.Location = new System.Drawing.Point(0, 0);
            this._formAdd_panelTop.Name = "_formAdd_panelTop";
            this._formAdd_panelTop.Size = new System.Drawing.Size(679, 30);
            this._formAdd_panelTop.TabIndex = 9;
            // 
            // _formAdd_comboBoxGrupo
            // 
            this._formAdd_comboBoxGrupo.FormattingEnabled = true;
            this._formAdd_comboBoxGrupo.Location = new System.Drawing.Point(259, 3);
            this._formAdd_comboBoxGrupo.Name = "_formAdd_comboBoxGrupo";
            this._formAdd_comboBoxGrupo.Size = new System.Drawing.Size(148, 21);
            this._formAdd_comboBoxGrupo.TabIndex = 3;
            // 
            // _formAdd_ButtonSave
            // 
            this._formAdd_ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._formAdd_ButtonSave.ForeColor = System.Drawing.Color.Black;
            this._formAdd_ButtonSave.Location = new System.Drawing.Point(440, 2);
            this._formAdd_ButtonSave.Name = "_formAdd_ButtonSave";
            this._formAdd_ButtonSave.Size = new System.Drawing.Size(75, 23);
            this._formAdd_ButtonSave.TabIndex = 10;
            this._formAdd_ButtonSave.Text = "Guardar";
            this._formAdd_ButtonSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(214, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // _formAdd_textBoxNombre
            // 
            this._formAdd_textBoxNombre.Location = new System.Drawing.Point(56, 3);
            this._formAdd_textBoxNombre.Name = "_formAdd_textBoxNombre";
            this._formAdd_textBoxNombre.Size = new System.Drawing.Size(144, 20);
            this._formAdd_textBoxNombre.TabIndex = 0;
            // 
            // _formAdd_dataGridViewFilters
            // 
            this._formAdd_dataGridViewFilters.AllowUserToAddRows = false;
            this._formAdd_dataGridViewFilters.AllowUserToDeleteRows = false;
            this._formAdd_dataGridViewFilters.AllowUserToOrderColumns = true;
            this._formAdd_dataGridViewFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._formAdd_dataGridViewFilters.BackgroundColor = System.Drawing.SystemColors.Control;
            this._formAdd_dataGridViewFilters.CausesValidation = false;
            this._formAdd_dataGridViewFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._formAdd_dataGridViewFilters.Location = new System.Drawing.Point(6, 7);
            this._formAdd_dataGridViewFilters.MultiSelect = false;
            this._formAdd_dataGridViewFilters.Name = "_formAdd_dataGridViewFilters";
            this._formAdd_dataGridViewFilters.Size = new System.Drawing.Size(659, 385);
            this._formAdd_dataGridViewFilters.TabIndex = 11;
            this._formAdd_dataGridViewFilters.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._formAdd_dataGridViewFilters_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 424);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Campos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(442, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 379);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tablas";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 79);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alias:";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 19);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 264);
            this.listBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(192, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(192, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this._formAdd_buttonDelete);
            this.groupBox2.Controls.Add(this._formAdd_listBoxColumns);
            this.groupBox2.Controls.Add(this._formAdd_buttonDownColumn);
            this.groupBox2.Controls.Add(this._formAdd_panelPropColumns);
            this.groupBox2.Controls.Add(this._formAdd_buttonUpColumn);
            this.groupBox2.Location = new System.Drawing.Point(214, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 379);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columnas";
            // 
            // _formAdd_buttonDelete
            // 
            this._formAdd_buttonDelete.BackgroundImage = global::TSReports.Properties.Resources.delete1;
            this._formAdd_buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._formAdd_buttonDelete.Location = new System.Drawing.Point(193, 96);
            this._formAdd_buttonDelete.Name = "_formAdd_buttonDelete";
            this._formAdd_buttonDelete.Size = new System.Drawing.Size(23, 23);
            this._formAdd_buttonDelete.TabIndex = 15;
            this._formAdd_buttonDelete.UseVisualStyleBackColor = true;
            this._formAdd_buttonDelete.Click += new System.EventHandler(this._formAdd_buttonDelete_Click);
            // 
            // _formAdd_buttonDownColumn
            // 
            this._formAdd_buttonDownColumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_formAdd_buttonDownColumn.BackgroundImage")));
            this._formAdd_buttonDownColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this._formAdd_buttonDownColumn.Location = new System.Drawing.Point(193, 48);
            this._formAdd_buttonDownColumn.Name = "_formAdd_buttonDownColumn";
            this._formAdd_buttonDownColumn.Size = new System.Drawing.Size(23, 23);
            this._formAdd_buttonDownColumn.TabIndex = 14;
            this._formAdd_buttonDownColumn.UseVisualStyleBackColor = true;
            this._formAdd_buttonDownColumn.Click += new System.EventHandler(this._formAdd_buttonDownColumn_Click);
            // 
            // _formAdd_buttonUpColumn
            // 
            this._formAdd_buttonUpColumn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_formAdd_buttonUpColumn.BackgroundImage")));
            this._formAdd_buttonUpColumn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._formAdd_buttonUpColumn.Location = new System.Drawing.Point(193, 19);
            this._formAdd_buttonUpColumn.Name = "_formAdd_buttonUpColumn";
            this._formAdd_buttonUpColumn.Size = new System.Drawing.Size(23, 23);
            this._formAdd_buttonUpColumn.TabIndex = 13;
            this._formAdd_buttonUpColumn.UseVisualStyleBackColor = true;
            this._formAdd_buttonUpColumn.Click += new System.EventHandler(this._formAdd_buttonUpColumn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._formAdd_treeViewReportes);
            this.groupBox1.Controls.Add(this._formAdd_textBoxFilter);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 379);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origen";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._formAdd_dataGridViewFilters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filtros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(671, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(563, 354);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 454);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._formAdd_panelTop);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSReports";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this._formAdd_panelPropColumns.ResumeLayout(false);
            this._formAdd_panelPropColumns.PerformLayout();
            this._formAdd_panelTop.ResumeLayout(false);
            this._formAdd_panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._formAdd_dataGridViewFilters)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView _formAdd_treeViewReportes;
        private System.Windows.Forms.ListBox _formAdd_listBoxColumns;
        private System.Windows.Forms.Panel _formAdd_panelPropColumns;
        private System.Windows.Forms.TextBox _formAdd_textBoxFilter;
        private System.Windows.Forms.Panel _formAdd_panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _formAdd_textBoxNombre;
        private System.Windows.Forms.ComboBox _formAdd_comboBoxGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _formAdd_ButtonSave;
        private System.Windows.Forms.DataGridView _formAdd_dataGridViewFilters;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _formAdd_buttonDelete;
        private System.Windows.Forms.Button _formAdd_buttonDownColumn;
        private System.Windows.Forms.Button _formAdd_buttonUpColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox _formAdd_checkBoxVisible;
        private System.Windows.Forms.RadioButton _formAdd_radioButtonDesc;
        private System.Windows.Forms.RadioButton _formAdd_radioButtonAsc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}