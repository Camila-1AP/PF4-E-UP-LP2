namespace E_UP
{
    partial class Departamento
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconTabla = new FontAwesome.Sharp.IconButton();
            this.iconButtonCSV = new FontAwesome.Sharp.IconButton();
            this.iconButtonCrearAdmin = new FontAwesome.Sharp.IconButton();
            this.iconButtonExcel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelContenedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1766, 672);
            this.panel1.TabIndex = 58;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.dgv);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1766, 672);
            this.panelContenedor.TabIndex = 11;
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1766, 672);
            this.dgv.TabIndex = 11;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.iconTabla);
            this.panel2.Controls.Add(this.iconButtonCSV);
            this.panel2.Controls.Add(this.iconButtonCrearAdmin);
            this.panel2.Controls.Add(this.iconButtonExcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1766, 95);
            this.panel2.TabIndex = 57;
            // 
            // iconTabla
            // 
            this.iconTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconTabla.FlatAppearance.BorderSize = 0;
            this.iconTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconTabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconTabla.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconTabla.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconTabla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTabla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconTabla.Location = new System.Drawing.Point(1372, 11);
            this.iconTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconTabla.Name = "iconTabla";
            this.iconTabla.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconTabla.Size = new System.Drawing.Size(382, 76);
            this.iconTabla.TabIndex = 14;
            this.iconTabla.Tag = "Tabla Departamentos";
            this.iconTabla.Text = "Tabla Departamentos";
            this.iconTabla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconTabla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconTabla.UseVisualStyleBackColor = true;
            this.iconTabla.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonCSV
            // 
            this.iconButtonCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCSV.FlatAppearance.BorderSize = 0;
            this.iconButtonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCSV.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonCSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iconButtonCSV.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonCSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.Location = new System.Drawing.Point(1043, 15);
            this.iconButtonCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCSV.Name = "iconButtonCSV";
            this.iconButtonCSV.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonCSV.Size = new System.Drawing.Size(298, 71);
            this.iconButtonCSV.TabIndex = 11;
            this.iconButtonCSV.Tag = "Exportar .CSV";
            this.iconButtonCSV.Text = "Exportar .CSV";
            this.iconButtonCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCSV.UseVisualStyleBackColor = true;
            this.iconButtonCSV.Click += new System.EventHandler(this.iconButtonCSV_Click);
            // 
            // iconButtonCrearAdmin
            // 
            this.iconButtonCrearAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCrearAdmin.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonCrearAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconButtonCrearAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonCrearAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCrearAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCrearAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconButtonCrearAdmin.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonCrearAdmin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconButtonCrearAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCrearAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCrearAdmin.Location = new System.Drawing.Point(3, 11);
            this.iconButtonCrearAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCrearAdmin.Name = "iconButtonCrearAdmin";
            this.iconButtonCrearAdmin.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonCrearAdmin.Size = new System.Drawing.Size(723, 78);
            this.iconButtonCrearAdmin.TabIndex = 13;
            this.iconButtonCrearAdmin.Tag = "Crear";
            this.iconButtonCrearAdmin.Text = "Acciones";
            this.iconButtonCrearAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCrearAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCrearAdmin.UseVisualStyleBackColor = false;
            this.iconButtonCrearAdmin.Click += new System.EventHandler(this.iconButtonCrearAdmin_Click);
            // 
            // iconButtonExcel
            // 
            this.iconButtonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExcel.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonExcel.FlatAppearance.BorderSize = 0;
            this.iconButtonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonExcel.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconButtonExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.iconButtonExcel.IconColor = System.Drawing.Color.OliveDrab;
            this.iconButtonExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.Location = new System.Drawing.Point(732, 16);
            this.iconButtonExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonExcel.Name = "iconButtonExcel";
            this.iconButtonExcel.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonExcel.Size = new System.Drawing.Size(291, 71);
            this.iconButtonExcel.TabIndex = 12;
            this.iconButtonExcel.Tag = "Exportar Excel";
            this.iconButtonExcel.Text = "Exportar Excel";
            this.iconButtonExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExcel.UseVisualStyleBackColor = false;
            this.iconButtonExcel.Click += new System.EventHandler(this.iconButtonExcel_Click);
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1766, 767);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.Load += new System.EventHandler(this.Departamento_Load);
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButtonExcel;
        private FontAwesome.Sharp.IconButton iconButtonCrearAdmin;
        private FontAwesome.Sharp.IconButton iconButtonCSV;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.DataGridView dgv;
        private FontAwesome.Sharp.IconButton iconTabla;
    }
}