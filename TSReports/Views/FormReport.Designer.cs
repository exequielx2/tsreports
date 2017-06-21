namespace TSReports.Views
{
    partial class FormReport
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
            this._fromReport_panel1 = new System.Windows.Forms.Panel();
            this._fromReport_panel2 = new System.Windows.Forms.Panel();
            this._fromReport_dataGridView = new System.Windows.Forms.DataGridView();
            this._fromReport_panel3 = new System.Windows.Forms.Panel();
            this._fromReport_labelStatus = new System.Windows.Forms.Label();
            this._fromReport_labelCantidad = new System.Windows.Forms.Label();
            this._fromReport_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._fromReport_dataGridView)).BeginInit();
            this._fromReport_panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _fromReport_panel1
            // 
            this._fromReport_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this._fromReport_panel1.Location = new System.Drawing.Point(0, 0);
            this._fromReport_panel1.Name = "_fromReport_panel1";
            this._fromReport_panel1.Size = new System.Drawing.Size(556, 31);
            this._fromReport_panel1.TabIndex = 0;
            // 
            // _fromReport_panel2
            // 
            this._fromReport_panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fromReport_panel2.Controls.Add(this._fromReport_dataGridView);
            this._fromReport_panel2.Location = new System.Drawing.Point(0, 38);
            this._fromReport_panel2.Name = "_fromReport_panel2";
            this._fromReport_panel2.Size = new System.Drawing.Size(556, 388);
            this._fromReport_panel2.TabIndex = 1;
            // 
            // _fromReport_dataGridView
            // 
            this._fromReport_dataGridView.AllowUserToOrderColumns = true;
            this._fromReport_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fromReport_dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this._fromReport_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._fromReport_dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this._fromReport_dataGridView.Location = new System.Drawing.Point(4, 4);
            this._fromReport_dataGridView.Name = "_fromReport_dataGridView";
            this._fromReport_dataGridView.Size = new System.Drawing.Size(549, 381);
            this._fromReport_dataGridView.TabIndex = 0;
            // 
            // _fromReport_panel3
            // 
            this._fromReport_panel3.Controls.Add(this._fromReport_labelStatus);
            this._fromReport_panel3.Controls.Add(this._fromReport_labelCantidad);
            this._fromReport_panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._fromReport_panel3.Location = new System.Drawing.Point(0, 432);
            this._fromReport_panel3.Name = "_fromReport_panel3";
            this._fromReport_panel3.Size = new System.Drawing.Size(556, 29);
            this._fromReport_panel3.TabIndex = 2;
            // 
            // _fromReport_labelStatus
            // 
            this._fromReport_labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._fromReport_labelStatus.AutoSize = true;
            this._fromReport_labelStatus.Location = new System.Drawing.Point(3, 7);
            this._fromReport_labelStatus.Name = "_fromReport_labelStatus";
            this._fromReport_labelStatus.Size = new System.Drawing.Size(10, 13);
            this._fromReport_labelStatus.TabIndex = 1;
            this._fromReport_labelStatus.Text = "-";
            // 
            // _fromReport_labelCantidad
            // 
            this._fromReport_labelCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this._fromReport_labelCantidad.AutoSize = true;
            this._fromReport_labelCantidad.Location = new System.Drawing.Point(499, 7);
            this._fromReport_labelCantidad.Name = "_fromReport_labelCantidad";
            this._fromReport_labelCantidad.Size = new System.Drawing.Size(13, 13);
            this._fromReport_labelCantidad.TabIndex = 0;
            this._fromReport_labelCantidad.Text = "0";
            this._fromReport_labelCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 461);
            this.Controls.Add(this._fromReport_panel3);
            this.Controls.Add(this._fromReport_panel2);
            this.Controls.Add(this._fromReport_panel1);
            this.Name = "FormReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReport_Load);
            this._fromReport_panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._fromReport_dataGridView)).EndInit();
            this._fromReport_panel3.ResumeLayout(false);
            this._fromReport_panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _fromReport_panel1;
        private System.Windows.Forms.Panel _fromReport_panel2;
        private System.Windows.Forms.Panel _fromReport_panel3;
        private System.Windows.Forms.Label _fromReport_labelCantidad;
        private System.Windows.Forms.DataGridView _fromReport_dataGridView;
        private System.Windows.Forms.Label _fromReport_labelStatus;
    }
}