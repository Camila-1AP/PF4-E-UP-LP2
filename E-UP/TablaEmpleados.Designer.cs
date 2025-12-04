namespace E_UP
{
    partial class TablaEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablaEmpleados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButtonExcel = new FontAwesome.Sharp.IconButton();
            this.iconButtonCSV = new FontAwesome.Sharp.IconButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCargoFoto = new System.Windows.Forms.Label();
            this.lblNombreFoto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.lblEstadoFoto = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconButtonExcel);
            this.panel2.Controls.Add(this.iconButtonCSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1638, 75);
            this.panel2.TabIndex = 9;
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
            this.iconButtonExcel.IconSize = 45;
            this.iconButtonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.Location = new System.Drawing.Point(0, 0);
            this.iconButtonExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonExcel.Name = "iconButtonExcel";
            this.iconButtonExcel.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonExcel.Size = new System.Drawing.Size(303, 70);
            this.iconButtonExcel.TabIndex = 11;
            this.iconButtonExcel.Tag = "Exportar Excel";
            this.iconButtonExcel.Text = "Exportar Excel";
            this.iconButtonExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExcel.UseVisualStyleBackColor = false;
            this.iconButtonExcel.Click += new System.EventHandler(this.iconButtonExcel_Click);
            // 
            // iconButtonCSV
            // 
            this.iconButtonCSV.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonCSV.FlatAppearance.BorderSize = 0;
            this.iconButtonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCSV.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonCSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iconButtonCSV.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButtonCSV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCSV.IconSize = 45;
            this.iconButtonCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.Location = new System.Drawing.Point(350, 4);
            this.iconButtonCSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCSV.Name = "iconButtonCSV";
            this.iconButtonCSV.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonCSV.Size = new System.Drawing.Size(336, 66);
            this.iconButtonCSV.TabIndex = 11;
            this.iconButtonCSV.Tag = "Exportar .CSV";
            this.iconButtonCSV.Text = "Exportar .CSV";
            this.iconButtonCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCSV.UseVisualStyleBackColor = false;
            this.iconButtonCSV.Click += new System.EventHandler(this.iconButtonCSV_Click);
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
            this.dgv.Size = new System.Drawing.Size(1210, 933);
            this.dgv.TabIndex = 10;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.lblCargoFoto);
            this.panel4.Controls.Add(this.lblNombreFoto);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.iconPictureBox1);
            this.panel4.Controls.Add(this.iconPictureBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.iconPictureBox3);
            this.panel4.Controls.Add(this.lblEstadoFoto);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1210, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 933);
            this.panel4.TabIndex = 53;
            // 
            // lblCargoFoto
            // 
            this.lblCargoFoto.AutoSize = true;
            this.lblCargoFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCargoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCargoFoto.Location = new System.Drawing.Point(23, 742);
            this.lblCargoFoto.Name = "lblCargoFoto";
            this.lblCargoFoto.Size = new System.Drawing.Size(71, 25);
            this.lblCargoFoto.TabIndex = 55;
            this.lblCargoFoto.Text = "Cargo";
            // 
            // lblNombreFoto
            // 
            this.lblNombreFoto.AutoSize = true;
            this.lblNombreFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreFoto.Location = new System.Drawing.Point(19, 599);
            this.lblNombreFoto.Name = "lblNombreFoto";
            this.lblNombreFoto.Size = new System.Drawing.Size(87, 25);
            this.lblNombreFoto.TabIndex = 54;
            this.lblNombreFoto.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(104, 677);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cargo";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(28, 658);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 60);
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox2.IconSize = 60;
            this.iconPictureBox2.Location = new System.Drawing.Point(24, 517);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(64, 60);
            this.iconPictureBox2.TabIndex = 51;
            this.iconPictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(94, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(94, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 48;
            this.label8.Text = "Estado";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox3.IconSize = 60;
            this.iconPictureBox3.Location = new System.Drawing.Point(22, 382);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(64, 60);
            this.iconPictureBox3.TabIndex = 49;
            this.iconPictureBox3.TabStop = false;
            // 
            // lblEstadoFoto
            // 
            this.lblEstadoFoto.AutoSize = true;
            this.lblEstadoFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstadoFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoFoto.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEstadoFoto.Location = new System.Drawing.Point(25, 465);
            this.lblEstadoFoto.Name = "lblEstadoFoto";
            this.lblEstadoFoto.Size = new System.Drawing.Size(79, 25);
            this.lblEstadoFoto.TabIndex = 25;
            this.lblEstadoFoto.Text = "Estado";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(63, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(304, 314);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 933);
            this.panel1.TabIndex = 54;
            // 
            // TablaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1638, 1008);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "TablaEmpleados";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.Auditoria_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCargoFoto;
        private System.Windows.Forms.Label lblNombreFoto;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Label lblEstadoFoto;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonCSV;
        private FontAwesome.Sharp.IconButton iconButtonExcel;
    }
}