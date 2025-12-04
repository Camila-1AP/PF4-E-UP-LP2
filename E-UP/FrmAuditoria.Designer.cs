namespace E_UP
{
    partial class FrmAuditoria
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonExcel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAuditoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 933);
            this.panel1.TabIndex = 56;
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditoria.Location = new System.Drawing.Point(0, 0);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.Size = new System.Drawing.Size(1638, 933);
            this.dgvAuditoria.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButtonExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1638, 75);
            this.panel2.TabIndex = 55;
            // 
            // iconButtonExcel
            // 
            this.iconButtonExcel.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonExcel.FlatAppearance.BorderSize = 0;
            this.iconButtonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExcel.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconButtonExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButtonExcel.IconColor = System.Drawing.Color.OliveDrab;
            this.iconButtonExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.Location = new System.Drawing.Point(12, 0);
            this.iconButtonExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonExcel.Name = "iconButtonExcel";
            this.iconButtonExcel.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonExcel.Size = new System.Drawing.Size(382, 70);
            this.iconButtonExcel.TabIndex = 12;
            this.iconButtonExcel.Tag = "Exportar Excel";
            this.iconButtonExcel.Text = "Exportar Excel";
            this.iconButtonExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExcel.UseVisualStyleBackColor = false;
            this.iconButtonExcel.Click += new System.EventHandler(this.iconButtonExcel_Click);
            // 
            // FrmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1008);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmAuditoria";
            this.Text = "TablaDatos";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonExcel;
    }
}