namespace E_UP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeTool = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorTool = new System.Windows.Forms.ToolStripMenuItem();
            this.RRHHTool = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoTool = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCredenciales = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.iconCargoID = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconBTNenter = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelCredenciales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCargoID)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeTool,
            this.administradorTool,
            this.RRHHTool,
            this.auditoriaTool,
            this.tablaTool,
            this.departamentoTool,
            this.cargoTool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1639, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // homeTool
            // 
            this.homeTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.homeTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.homeTool.Name = "homeTool";
            this.homeTool.Size = new System.Drawing.Size(82, 32);
            this.homeTool.Text = "Home";
            this.homeTool.Click += new System.EventHandler(this.homeTool_Click);
            this.homeTool.MouseEnter += new System.EventHandler(this.homeTool_MouseEnter);
            this.homeTool.MouseLeave += new System.EventHandler(this.homeTool_MouseLeave);
            this.homeTool.MouseHover += new System.EventHandler(this.homeTool_MouseHover);
            // 
            // administradorTool
            // 
            this.administradorTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.administradorTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administradorTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.administradorTool.Name = "administradorTool";
            this.administradorTool.Size = new System.Drawing.Size(162, 32);
            this.administradorTool.Text = "Administrador";
            this.administradorTool.Visible = false;
            this.administradorTool.Click += new System.EventHandler(this.administradorTool_Click);
            // 
            // RRHHTool
            // 
            this.RRHHTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.RRHHTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RRHHTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.RRHHTool.Name = "RRHHTool";
            this.RRHHTool.Size = new System.Drawing.Size(82, 32);
            this.RRHHTool.Text = "RRHH";
            this.RRHHTool.Visible = false;
            this.RRHHTool.Click += new System.EventHandler(this.RRHHTool_Click);
            // 
            // auditoriaTool
            // 
            this.auditoriaTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.auditoriaTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditoriaTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.auditoriaTool.Name = "auditoriaTool";
            this.auditoriaTool.Size = new System.Drawing.Size(115, 32);
            this.auditoriaTool.Text = "Auditoría";
            this.auditoriaTool.Visible = false;
            this.auditoriaTool.Click += new System.EventHandler(this.auditoríaTool_Click);
            // 
            // tablaTool
            // 
            this.tablaTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.tablaTool.Name = "tablaTool";
            this.tablaTool.Size = new System.Drawing.Size(163, 32);
            this.tablaTool.Text = "Tabla de datos";
            this.tablaTool.Visible = false;
            this.tablaTool.Click += new System.EventHandler(this.tablaTool_Click);
            // 
            // departamentoTool
            // 
            this.departamentoTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentoTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.departamentoTool.Name = "departamentoTool";
            this.departamentoTool.Size = new System.Drawing.Size(164, 32);
            this.departamentoTool.Text = "Departamento";
            this.departamentoTool.Visible = false;
            this.departamentoTool.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // cargoTool
            // 
            this.cargoTool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargoTool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.cargoTool.Name = "cargoTool";
            this.cargoTool.Size = new System.Drawing.Size(81, 32);
            this.cargoTool.Text = "Cargo";
            this.cargoTool.Visible = false;
            this.cargoTool.Click += new System.EventHandler(this.cargoToolStripMenuItem_Click);
            // 
            // panelCredenciales
            // 
            this.panelCredenciales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCredenciales.Controls.Add(this.label1);
            this.panelCredenciales.Controls.Add(this.iconPictureBox1);
            this.panelCredenciales.Controls.Add(this.label6);
            this.panelCredenciales.Controls.Add(this.iconCargoID);
            this.panelCredenciales.Controls.Add(this.iconBTNenter);
            this.panelCredenciales.Controls.Add(this.panel1);
            this.panelCredenciales.Controls.Add(this.panel2);
            this.panelCredenciales.Location = new System.Drawing.Point(1031, 36);
            this.panelCredenciales.Name = "panelCredenciales";
            this.panelCredenciales.Size = new System.Drawing.Size(608, 733);
            this.panelCredenciales.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(0, -9);
            this.txtPass.MaxLength = 6;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '◉';
            this.txtPass.Size = new System.Drawing.Size(278, 30);
            this.txtPass.TabIndex = 68;
            // 
            // txtRol
            // 
            this.txtRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRol.Location = new System.Drawing.Point(0, -5);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(345, 30);
            this.txtRol.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(93, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Contraseña";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(23, 661);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(64, 60);
            this.iconPictureBox1.TabIndex = 65;
            this.iconPictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(93, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "Rol";
            // 
            // iconCargoID
            // 
            this.iconCargoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCargoID.BackColor = System.Drawing.Color.Transparent;
            this.iconCargoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconCargoID.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconCargoID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.iconCargoID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconCargoID.IconSize = 60;
            this.iconCargoID.Location = new System.Drawing.Point(23, 550);
            this.iconCargoID.Name = "iconCargoID";
            this.iconCargoID.Size = new System.Drawing.Size(64, 60);
            this.iconCargoID.TabIndex = 63;
            this.iconCargoID.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.txtRol);
            this.panel1.Location = new System.Drawing.Point(193, 562);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 36);
            this.panel1.TabIndex = 69;
            // 
            // iconBTNenter
            // 
            this.iconBTNenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconBTNenter.BackColor = System.Drawing.Color.Transparent;
            this.iconBTNenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconBTNenter.FlatAppearance.BorderSize = 0;
            this.iconBTNenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBTNenter.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconBTNenter.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            this.iconBTNenter.IconColor = System.Drawing.Color.DimGray;
            this.iconBTNenter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBTNenter.IconSize = 100;
            this.iconBTNenter.Location = new System.Drawing.Point(217, 39);
            this.iconBTNenter.Name = "iconBTNenter";
            this.iconBTNenter.Size = new System.Drawing.Size(206, 105);
            this.iconBTNenter.TabIndex = 62;
            this.iconBTNenter.UseVisualStyleBackColor = false;
            this.iconBTNenter.Click += new System.EventHandler(this.iconBTNenter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.txtPass);
            this.panel2.Location = new System.Drawing.Point(260, 670);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 32);
            this.panel2.TabIndex = 70;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1639, 769);
            this.Controls.Add(this.panelCredenciales);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCredenciales.ResumeLayout(false);
            this.panelCredenciales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCargoID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeTool;
        private System.Windows.Forms.ToolStripMenuItem administradorTool;
        private System.Windows.Forms.ToolStripMenuItem RRHHTool;
        private System.Windows.Forms.ToolStripMenuItem auditoriaTool;
        private System.Windows.Forms.ToolStripMenuItem tablaTool;
        private System.Windows.Forms.ToolStripMenuItem departamentoTool;
        private System.Windows.Forms.ToolStripMenuItem cargoTool;
        private System.Windows.Forms.Panel panelCredenciales;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconPictureBox iconCargoID;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBTNenter;
        private System.Windows.Forms.Panel panel2;
    }
}