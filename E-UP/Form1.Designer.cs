namespace E_UP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelMenuAdmin = new System.Windows.Forms.Panel();
            this.iconButtonSalir = new FontAwesome.Sharp.IconButton();
            this.iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            this.iconButtonUpdateAdmin = new FontAwesome.Sharp.IconButton();
            this.iconButtonCrearAdmin = new FontAwesome.Sharp.IconButton();
            this.panelFoto = new System.Windows.Forms.Panel();
            this.iconButtonBar = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.iconBTNenter = new FontAwesome.Sharp.IconButton();
            this.iconIDeliminar = new FontAwesome.Sharp.IconPictureBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.groupIngresarEmpleado = new System.Windows.Forms.GroupBox();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.txtIDUpdate = new System.Windows.Forms.TextBox();
            this.iconFechaFin = new FontAwesome.Sharp.IconPictureBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblIDupdate = new System.Windows.Forms.Label();
            this.radioNoVigente = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargoID = new System.Windows.Forms.TextBox();
            this.iconCargoID = new FontAwesome.Sharp.IconPictureBox();
            this.txtDepaID = new System.Windows.Forms.TextBox();
            this.iconIDempleado = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioVigente = new System.Windows.Forms.RadioButton();
            this.iconDepaID = new FontAwesome.Sharp.IconPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.iconEstado = new FontAwesome.Sharp.IconPictureBox();
            this.iconSalario = new FontAwesome.Sharp.IconPictureBox();
            this.iconFechaInicio = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelColor5 = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.panelColor4 = new System.Windows.Forms.Panel();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.panelColor3 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelColor6 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupImagenEmpleado = new System.Windows.Forms.GroupBox();
            this.iconValidarFoto = new FontAwesome.Sharp.IconButton();
            this.iconCargarFoto = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconUpdate = new FontAwesome.Sharp.IconButton();
            this.iconInsert = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenuAdmin.SuspendLayout();
            this.panelFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIDeliminar)).BeginInit();
            this.groupIngresarEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCargoID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIDempleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDepaID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.panelColor5.SuspendLayout();
            this.panelColor4.SuspendLayout();
            this.panelColor6.SuspendLayout();
            this.groupImagenEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelMenuAdmin
            // 
            this.panelMenuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panelMenuAdmin.Controls.Add(this.iconButtonSalir);
            this.panelMenuAdmin.Controls.Add(this.iconButtonEliminar);
            this.panelMenuAdmin.Controls.Add(this.iconButtonUpdateAdmin);
            this.panelMenuAdmin.Controls.Add(this.iconButtonCrearAdmin);
            this.panelMenuAdmin.Controls.Add(this.panelFoto);
            this.panelMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenuAdmin.Name = "panelMenuAdmin";
            this.panelMenuAdmin.Size = new System.Drawing.Size(516, 1055);
            this.panelMenuAdmin.TabIndex = 4;
            // 
            // iconButtonSalir
            // 
            this.iconButtonSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonSalir.FlatAppearance.BorderSize = 0;
            this.iconButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSalir.ForeColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconButtonSalir.IconColor = System.Drawing.Color.White;
            this.iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSalir.Location = new System.Drawing.Point(0, 993);
            this.iconButtonSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSalir.Name = "iconButtonSalir";
            this.iconButtonSalir.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconButtonSalir.Size = new System.Drawing.Size(516, 62);
            this.iconButtonSalir.TabIndex = 6;
            this.iconButtonSalir.Tag = "Salir";
            this.iconButtonSalir.Text = "Salir";
            this.iconButtonSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSalir.UseVisualStyleBackColor = true;
            this.iconButtonSalir.Click += new System.EventHandler(this.iconButtonSalir_Click);
            // 
            // iconButtonEliminar
            // 
            this.iconButtonEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonEliminar.FlatAppearance.BorderSize = 0;
            this.iconButtonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.iconButtonEliminar.IconColor = System.Drawing.Color.White;
            this.iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEliminar.Location = new System.Drawing.Point(0, 396);
            this.iconButtonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonEliminar.Name = "iconButtonEliminar";
            this.iconButtonEliminar.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonEliminar.Size = new System.Drawing.Size(516, 66);
            this.iconButtonEliminar.TabIndex = 3;
            this.iconButtonEliminar.Tag = "Eliminar";
            this.iconButtonEliminar.Text = "Eliminar";
            this.iconButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonEliminar.UseVisualStyleBackColor = true;
            this.iconButtonEliminar.Click += new System.EventHandler(this.iconButtonEliminar_Click);
            // 
            // iconButtonUpdateAdmin
            // 
            this.iconButtonUpdateAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonUpdateAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonUpdateAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUpdateAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUpdateAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonUpdateAdmin.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.iconButtonUpdateAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonUpdateAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUpdateAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUpdateAdmin.Location = new System.Drawing.Point(0, 328);
            this.iconButtonUpdateAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonUpdateAdmin.Name = "iconButtonUpdateAdmin";
            this.iconButtonUpdateAdmin.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonUpdateAdmin.Size = new System.Drawing.Size(516, 68);
            this.iconButtonUpdateAdmin.TabIndex = 2;
            this.iconButtonUpdateAdmin.Tag = "Actualizar";
            this.iconButtonUpdateAdmin.Text = "Actualizar";
            this.iconButtonUpdateAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonUpdateAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonUpdateAdmin.UseVisualStyleBackColor = true;
            this.iconButtonUpdateAdmin.Click += new System.EventHandler(this.iconButtonUpdateAdmin_Click);
            // 
            // iconButtonCrearAdmin
            // 
            this.iconButtonCrearAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCrearAdmin.FlatAppearance.BorderSize = 0;
            this.iconButtonCrearAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCrearAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCrearAdmin.ForeColor = System.Drawing.Color.White;
            this.iconButtonCrearAdmin.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButtonCrearAdmin.IconColor = System.Drawing.Color.White;
            this.iconButtonCrearAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCrearAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCrearAdmin.Location = new System.Drawing.Point(0, 250);
            this.iconButtonCrearAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCrearAdmin.Name = "iconButtonCrearAdmin";
            this.iconButtonCrearAdmin.Padding = new System.Windows.Forms.Padding(11, 15, 0, 0);
            this.iconButtonCrearAdmin.Size = new System.Drawing.Size(516, 78);
            this.iconButtonCrearAdmin.TabIndex = 1;
            this.iconButtonCrearAdmin.Tag = "Crear";
            this.iconButtonCrearAdmin.Text = "Crear";
            this.iconButtonCrearAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCrearAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCrearAdmin.UseVisualStyleBackColor = true;
            this.iconButtonCrearAdmin.Click += new System.EventHandler(this.iconButtonCrearAdmin_Click);
            // 
            // panelFoto
            // 
            this.panelFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.panelFoto.Controls.Add(this.iconButtonBar);
            this.panelFoto.Controls.Add(this.pictureBox2);
            this.panelFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFoto.Location = new System.Drawing.Point(0, 0);
            this.panelFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(516, 250);
            this.panelFoto.TabIndex = 0;
            // 
            // iconButtonBar
            // 
            this.iconButtonBar.FlatAppearance.BorderSize = 0;
            this.iconButtonBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonBar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonBar.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButtonBar.IconColor = System.Drawing.Color.White;
            this.iconButtonBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBar.IconSize = 42;
            this.iconButtonBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBar.Location = new System.Drawing.Point(3, 2);
            this.iconButtonBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonBar.Name = "iconButtonBar";
            this.iconButtonBar.Padding = new System.Windows.Forms.Padding(11, 0, 0, 10);
            this.iconButtonBar.Size = new System.Drawing.Size(60, 81);
            this.iconButtonBar.TabIndex = 3;
            this.iconButtonBar.Tag = "";
            this.iconButtonBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBar.UseVisualStyleBackColor = true;
            this.iconButtonBar.Click += new System.EventHandler(this.iconButtonBar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupIngresarEmpleado);
            this.panel1.Controls.Add(this.groupImagenEmpleado);
            this.panel1.Controls.Add(this.iconUpdate);
            this.panel1.Controls.Add(this.iconInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(516, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 1055);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(821, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 1055);
            this.panel2.TabIndex = 50;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtEliminar);
            this.panel3.Controls.Add(this.iconBTNenter);
            this.panel3.Controls.Add(this.iconIDeliminar);
            this.panel3.Controls.Add(this.lblEliminar);
            this.panel3.Location = new System.Drawing.Point(17, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 439);
            this.panel3.TabIndex = 52;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.txtEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.txtEliminar.Location = new System.Drawing.Point(29, 211);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(339, 34);
            this.txtEliminar.TabIndex = 50;
            this.txtEliminar.Visible = false;
            this.txtEliminar.TextChanged += new System.EventHandler(this.txtEliminar_TextChanged);
            this.txtEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEliminar_KeyPress);
            // 
            // iconBTNenter
            // 
            this.iconBTNenter.BackColor = System.Drawing.Color.Transparent;
            this.iconBTNenter.FlatAppearance.BorderSize = 2;
            this.iconBTNenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBTNenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBTNenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.iconBTNenter.IconChar = FontAwesome.Sharp.IconChar.PersonCircleXmark;
            this.iconBTNenter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.iconBTNenter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBTNenter.IconSize = 70;
            this.iconBTNenter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconBTNenter.Location = new System.Drawing.Point(29, 302);
            this.iconBTNenter.Name = "iconBTNenter";
            this.iconBTNenter.Size = new System.Drawing.Size(339, 84);
            this.iconBTNenter.TabIndex = 51;
            this.iconBTNenter.Text = "Eliminar";
            this.iconBTNenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBTNenter.UseVisualStyleBackColor = false;
            this.iconBTNenter.Click += new System.EventHandler(this.iconBTNenter_Click);
            // 
            // iconIDeliminar
            // 
            this.iconIDeliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconIDeliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconIDeliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.iconIDeliminar.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconIDeliminar.IconColor = System.Drawing.SystemColors.Control;
            this.iconIDeliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconIDeliminar.IconSize = 83;
            this.iconIDeliminar.Location = new System.Drawing.Point(157, 42);
            this.iconIDeliminar.Name = "iconIDeliminar";
            this.iconIDeliminar.Size = new System.Drawing.Size(83, 93);
            this.iconIDeliminar.TabIndex = 50;
            this.iconIDeliminar.TabStop = false;
            this.iconIDeliminar.Visible = false;
            // 
            // lblEliminar
            // 
            this.lblEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblEliminar.Location = new System.Drawing.Point(119, 147);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(164, 29);
            this.lblEliminar.TabIndex = 50;
            this.lblEliminar.Text = "ID Empleado";
            this.lblEliminar.Visible = false;
            // 
            // groupIngresarEmpleado
            // 
            this.groupIngresarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupIngresarEmpleado.Controls.Add(this.dateFin);
            this.groupIngresarEmpleado.Controls.Add(this.txtIDUpdate);
            this.groupIngresarEmpleado.Controls.Add(this.iconFechaFin);
            this.groupIngresarEmpleado.Controls.Add(this.lblFechaFin);
            this.groupIngresarEmpleado.Controls.Add(this.lblIDupdate);
            this.groupIngresarEmpleado.Controls.Add(this.radioNoVigente);
            this.groupIngresarEmpleado.Controls.Add(this.label2);
            this.groupIngresarEmpleado.Controls.Add(this.txtCargoID);
            this.groupIngresarEmpleado.Controls.Add(this.iconCargoID);
            this.groupIngresarEmpleado.Controls.Add(this.txtDepaID);
            this.groupIngresarEmpleado.Controls.Add(this.iconIDempleado);
            this.groupIngresarEmpleado.Controls.Add(this.label1);
            this.groupIngresarEmpleado.Controls.Add(this.radioVigente);
            this.groupIngresarEmpleado.Controls.Add(this.iconDepaID);
            this.groupIngresarEmpleado.Controls.Add(this.label5);
            this.groupIngresarEmpleado.Controls.Add(this.iconEstado);
            this.groupIngresarEmpleado.Controls.Add(this.iconSalario);
            this.groupIngresarEmpleado.Controls.Add(this.iconFechaInicio);
            this.groupIngresarEmpleado.Controls.Add(this.label4);
            this.groupIngresarEmpleado.Controls.Add(this.iconUser);
            this.groupIngresarEmpleado.Controls.Add(this.lblNombre);
            this.groupIngresarEmpleado.Controls.Add(this.label3);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor5);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor4);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor3);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor2);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor1);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor);
            this.groupIngresarEmpleado.Controls.Add(this.panelColor6);
            this.groupIngresarEmpleado.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIngresarEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(35)))), ((int)(((byte)(54)))));
            this.groupIngresarEmpleado.Location = new System.Drawing.Point(6, 12);
            this.groupIngresarEmpleado.Name = "groupIngresarEmpleado";
            this.groupIngresarEmpleado.Size = new System.Drawing.Size(1212, 508);
            this.groupIngresarEmpleado.TabIndex = 46;
            this.groupIngresarEmpleado.TabStop = false;
            this.groupIngresarEmpleado.Text = "Ingresar Empleado";
            // 
            // dateFin
            // 
            this.dateFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Location = new System.Drawing.Point(399, 451);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(410, 30);
            this.dateFin.TabIndex = 59;
            this.dateFin.Visible = false;
            // 
            // txtIDUpdate
            // 
            this.txtIDUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUpdate.Location = new System.Drawing.Point(889, 402);
            this.txtIDUpdate.Name = "txtIDUpdate";
            this.txtIDUpdate.Size = new System.Drawing.Size(317, 30);
            this.txtIDUpdate.TabIndex = 48;
            this.txtIDUpdate.Visible = false;
            this.txtIDUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDUpdate_KeyPress);
            // 
            // iconFechaFin
            // 
            this.iconFechaFin.BackColor = System.Drawing.SystemColors.Control;
            this.iconFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconFechaFin.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconFechaFin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconFechaFin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconFechaFin.IconSize = 60;
            this.iconFechaFin.Location = new System.Drawing.Point(25, 442);
            this.iconFechaFin.Name = "iconFechaFin";
            this.iconFechaFin.Size = new System.Drawing.Size(64, 60);
            this.iconFechaFin.TabIndex = 60;
            this.iconFechaFin.TabStop = false;
            this.iconFechaFin.Visible = false;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblFechaFin.Location = new System.Drawing.Point(96, 456);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(213, 25);
            this.lblFechaFin.TabIndex = 58;
            this.lblFechaFin.Text = "Fecha Desactivación";
            this.lblFechaFin.Visible = false;
            // 
            // lblIDupdate
            // 
            this.lblIDupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIDupdate.AutoSize = true;
            this.lblIDupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblIDupdate.Location = new System.Drawing.Point(980, 338);
            this.lblIDupdate.Name = "lblIDupdate";
            this.lblIDupdate.Size = new System.Drawing.Size(135, 25);
            this.lblIDupdate.TabIndex = 48;
            this.lblIDupdate.Text = "ID Empleado";
            this.lblIDupdate.Visible = false;
            // 
            // radioNoVigente
            // 
            this.radioNoVigente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioNoVigente.AutoSize = true;
            this.radioNoVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNoVigente.ForeColor = System.Drawing.Color.DimGray;
            this.radioNoVigente.Location = new System.Drawing.Point(369, 369);
            this.radioNoVigente.Name = "radioNoVigente";
            this.radioNoVigente.Size = new System.Drawing.Size(140, 29);
            this.radioNoVigente.TabIndex = 40;
            this.radioNoVigente.TabStop = true;
            this.radioNoVigente.Text = "No Vigente";
            this.radioNoVigente.UseVisualStyleBackColor = true;
            this.radioNoVigente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(980, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "CargoID";
            // 
            // txtCargoID
            // 
            this.txtCargoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCargoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargoID.Location = new System.Drawing.Point(889, 260);
            this.txtCargoID.Name = "txtCargoID";
            this.txtCargoID.Size = new System.Drawing.Size(311, 30);
            this.txtCargoID.TabIndex = 32;
            this.txtCargoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargoID_KeyPress);
            // 
            // iconCargoID
            // 
            this.iconCargoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconCargoID.BackColor = System.Drawing.SystemColors.Control;
            this.iconCargoID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconCargoID.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconCargoID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconCargoID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconCargoID.IconSize = 60;
            this.iconCargoID.Location = new System.Drawing.Point(883, 178);
            this.iconCargoID.Name = "iconCargoID";
            this.iconCargoID.Size = new System.Drawing.Size(64, 60);
            this.iconCargoID.TabIndex = 30;
            this.iconCargoID.TabStop = false;
            // 
            // txtDepaID
            // 
            this.txtDepaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepaID.Location = new System.Drawing.Point(889, 124);
            this.txtDepaID.Name = "txtDepaID";
            this.txtDepaID.Size = new System.Drawing.Size(311, 30);
            this.txtDepaID.TabIndex = 29;
            this.txtDepaID.TextChanged += new System.EventHandler(this.txtDepaID_TextChanged);
            this.txtDepaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepaID_KeyPress);
            // 
            // iconIDempleado
            // 
            this.iconIDempleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconIDempleado.BackColor = System.Drawing.SystemColors.Control;
            this.iconIDempleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconIDempleado.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconIDempleado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconIDempleado.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconIDempleado.IconSize = 60;
            this.iconIDempleado.Location = new System.Drawing.Point(883, 324);
            this.iconIDempleado.Name = "iconIDempleado";
            this.iconIDempleado.Size = new System.Drawing.Size(64, 60);
            this.iconIDempleado.TabIndex = 48;
            this.iconIDempleado.TabStop = false;
            this.iconIDempleado.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(980, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "DepartamentoID";
            // 
            // radioVigente
            // 
            this.radioVigente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioVigente.AutoSize = true;
            this.radioVigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioVigente.ForeColor = System.Drawing.Color.OliveDrab;
            this.radioVigente.Location = new System.Drawing.Point(218, 369);
            this.radioVigente.Name = "radioVigente";
            this.radioVigente.Size = new System.Drawing.Size(107, 29);
            this.radioVigente.TabIndex = 39;
            this.radioVigente.TabStop = true;
            this.radioVigente.Text = "Vigente";
            this.radioVigente.UseVisualStyleBackColor = true;
            this.radioVigente.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // iconDepaID
            // 
            this.iconDepaID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconDepaID.BackColor = System.Drawing.SystemColors.Control;
            this.iconDepaID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconDepaID.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconDepaID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconDepaID.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconDepaID.IconSize = 60;
            this.iconDepaID.Location = new System.Drawing.Point(883, 42);
            this.iconDepaID.Name = "iconDepaID";
            this.iconDepaID.Size = new System.Drawing.Size(64, 60);
            this.iconDepaID.TabIndex = 27;
            this.iconDepaID.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(96, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Estado";
            // 
            // iconEstado
            // 
            this.iconEstado.BackColor = System.Drawing.SystemColors.Control;
            this.iconEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconEstado.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconEstado.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconEstado.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconEstado.IconSize = 60;
            this.iconEstado.Location = new System.Drawing.Point(24, 359);
            this.iconEstado.Name = "iconEstado";
            this.iconEstado.Size = new System.Drawing.Size(64, 60);
            this.iconEstado.TabIndex = 47;
            this.iconEstado.TabStop = false;
            // 
            // iconSalario
            // 
            this.iconSalario.BackColor = System.Drawing.SystemColors.Control;
            this.iconSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconSalario.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconSalario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconSalario.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconSalario.IconSize = 60;
            this.iconSalario.Location = new System.Drawing.Point(25, 162);
            this.iconSalario.Name = "iconSalario";
            this.iconSalario.Size = new System.Drawing.Size(64, 60);
            this.iconSalario.TabIndex = 49;
            this.iconSalario.TabStop = false;
            // 
            // iconFechaInicio
            // 
            this.iconFechaInicio.BackColor = System.Drawing.SystemColors.Control;
            this.iconFechaInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconFechaInicio.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconFechaInicio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconFechaInicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconFechaInicio.IconSize = 60;
            this.iconFechaInicio.Location = new System.Drawing.Point(25, 260);
            this.iconFechaInicio.Name = "iconFechaInicio";
            this.iconFechaInicio.Size = new System.Drawing.Size(64, 60);
            this.iconFechaInicio.TabIndex = 48;
            this.iconFechaInicio.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(95, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Salario";
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconUser.IconSize = 60;
            this.iconUser.Location = new System.Drawing.Point(24, 55);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(64, 60);
            this.iconUser.TabIndex = 47;
            this.iconUser.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.lblNombre.Location = new System.Drawing.Point(95, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(96, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fecha Inicio";
            // 
            // panelColor5
            // 
            this.panelColor5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor5.Controls.Add(this.txtSalario);
            this.panelColor5.Location = new System.Drawing.Point(218, 173);
            this.panelColor5.Name = "panelColor5";
            this.panelColor5.Size = new System.Drawing.Size(591, 30);
            this.panelColor5.TabIndex = 62;
            // 
            // txtSalario
            // 
            this.txtSalario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(16, 0);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(575, 30);
            this.txtSalario.TabIndex = 42;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // panelColor4
            // 
            this.panelColor4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor4.Controls.Add(this.dateInicio);
            this.panelColor4.Location = new System.Drawing.Point(270, 274);
            this.panelColor4.Name = "panelColor4";
            this.panelColor4.Size = new System.Drawing.Size(539, 30);
            this.panelColor4.TabIndex = 63;
            // 
            // dateInicio
            // 
            this.dateInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicio.Location = new System.Drawing.Point(16, 0);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(523, 30);
            this.dateInicio.TabIndex = 41;
            // 
            // panelColor3
            // 
            this.panelColor3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor3.Location = new System.Drawing.Point(382, 451);
            this.panelColor3.Name = "panelColor3";
            this.panelColor3.Size = new System.Drawing.Size(427, 30);
            this.panelColor3.TabIndex = 64;
            this.panelColor3.Visible = false;
            // 
            // panelColor2
            // 
            this.panelColor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor2.Location = new System.Drawing.Point(871, 124);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(329, 30);
            this.panelColor2.TabIndex = 65;
            // 
            // panelColor1
            // 
            this.panelColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor1.Location = new System.Drawing.Point(871, 260);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(329, 30);
            this.panelColor1.TabIndex = 66;
            // 
            // panelColor
            // 
            this.panelColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor.Location = new System.Drawing.Point(871, 402);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(335, 30);
            this.panelColor.TabIndex = 60;
            this.panelColor.Visible = false;
            // 
            // panelColor6
            // 
            this.panelColor6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColor6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(210)))), ((int)(((byte)(208)))));
            this.panelColor6.Controls.Add(this.txtNombre);
            this.panelColor6.Location = new System.Drawing.Point(218, 73);
            this.panelColor6.Name = "panelColor6";
            this.panelColor6.Size = new System.Drawing.Size(591, 30);
            this.panelColor6.TabIndex = 61;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(16, 0);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(575, 30);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // groupImagenEmpleado
            // 
            this.groupImagenEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupImagenEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.groupImagenEmpleado.Controls.Add(this.iconValidarFoto);
            this.groupImagenEmpleado.Controls.Add(this.iconCargarFoto);
            this.groupImagenEmpleado.Controls.Add(this.pictureBox1);
            this.groupImagenEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupImagenEmpleado.Location = new System.Drawing.Point(847, 559);
            this.groupImagenEmpleado.Name = "groupImagenEmpleado";
            this.groupImagenEmpleado.Size = new System.Drawing.Size(370, 413);
            this.groupImagenEmpleado.TabIndex = 47;
            this.groupImagenEmpleado.TabStop = false;
            this.groupImagenEmpleado.Enter += new System.EventHandler(this.groupImagenEmpleado_Enter);
            // 
            // iconValidarFoto
            // 
            this.iconValidarFoto.FlatAppearance.BorderSize = 0;
            this.iconValidarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconValidarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconValidarFoto.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconValidarFoto.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconValidarFoto.IconColor = System.Drawing.Color.OliveDrab;
            this.iconValidarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconValidarFoto.IconSize = 60;
            this.iconValidarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconValidarFoto.Location = new System.Drawing.Point(41, 330);
            this.iconValidarFoto.Name = "iconValidarFoto";
            this.iconValidarFoto.Size = new System.Drawing.Size(286, 77);
            this.iconValidarFoto.TabIndex = 44;
            this.iconValidarFoto.Text = "Validar Foto";
            this.iconValidarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconValidarFoto.UseVisualStyleBackColor = true;
            this.iconValidarFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // iconCargarFoto
            // 
            this.iconCargarFoto.BackColor = System.Drawing.Color.Transparent;
            this.iconCargarFoto.FlatAppearance.BorderSize = 0;
            this.iconCargarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconCargarFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconCargarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.iconCargarFoto.IconChar = FontAwesome.Sharp.IconChar.PhotoVideo;
            this.iconCargarFoto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(108)))));
            this.iconCargarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCargarFoto.IconSize = 60;
            this.iconCargarFoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconCargarFoto.Location = new System.Drawing.Point(44, 6);
            this.iconCargarFoto.Name = "iconCargarFoto";
            this.iconCargarFoto.Size = new System.Drawing.Size(283, 69);
            this.iconCargarFoto.TabIndex = 45;
            this.iconCargarFoto.Text = "Cargar Foto";
            this.iconCargarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconCargarFoto.UseVisualStyleBackColor = false;
            this.iconCargarFoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // iconUpdate
            // 
            this.iconUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconUpdate.BackColor = System.Drawing.Color.Transparent;
            this.iconUpdate.Enabled = false;
            this.iconUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconUpdate.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconUpdate.IconChar = FontAwesome.Sharp.IconChar.PenNib;
            this.iconUpdate.IconColor = System.Drawing.Color.OliveDrab;
            this.iconUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconUpdate.IconSize = 74;
            this.iconUpdate.Location = new System.Drawing.Point(18, 565);
            this.iconUpdate.Name = "iconUpdate";
            this.iconUpdate.Size = new System.Drawing.Size(823, 140);
            this.iconUpdate.TabIndex = 57;
            this.iconUpdate.UseVisualStyleBackColor = false;
            this.iconUpdate.Click += new System.EventHandler(this.iconUpdate_Click);
            // 
            // iconInsert
            // 
            this.iconInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconInsert.BackColor = System.Drawing.Color.Transparent;
            this.iconInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconInsert.ForeColor = System.Drawing.Color.OliveDrab;
            this.iconInsert.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.iconInsert.IconColor = System.Drawing.Color.OliveDrab;
            this.iconInsert.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconInsert.IconSize = 74;
            this.iconInsert.Location = new System.Drawing.Point(18, 744);
            this.iconInsert.Name = "iconInsert";
            this.iconInsert.Size = new System.Drawing.Size(823, 228);
            this.iconInsert.TabIndex = 56;
            this.iconInsert.UseVisualStyleBackColor = false;
            this.iconInsert.Click += new System.EventHandler(this.iconInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 1055);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuAdmin.ResumeLayout(false);
            this.panelFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconIDeliminar)).EndInit();
            this.groupIngresarEmpleado.ResumeLayout(false);
            this.groupIngresarEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCargoID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconIDempleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDepaID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSalario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.panelColor5.ResumeLayout(false);
            this.panelColor5.PerformLayout();
            this.panelColor4.ResumeLayout(false);
            this.panelColor6.ResumeLayout(false);
            this.panelColor6.PerformLayout();
            this.groupImagenEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelMenuAdmin;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonUpdateAdmin;
        private FontAwesome.Sharp.IconButton iconButtonCrearAdmin;
        private System.Windows.Forms.Panel panelFoto;
        private FontAwesome.Sharp.IconButton iconButtonBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.RadioButton radioNoVigente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioVigente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCargoID;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconPictureBox iconCargoID;
        private System.Windows.Forms.TextBox txtDepaID;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconDepaID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private FontAwesome.Sharp.IconButton iconValidarFoto;
        private FontAwesome.Sharp.IconButton iconCargarFoto;
        private System.Windows.Forms.GroupBox groupIngresarEmpleado;
        private FontAwesome.Sharp.IconPictureBox iconEstado;
        private FontAwesome.Sharp.IconPictureBox iconSalario;
        private FontAwesome.Sharp.IconPictureBox iconFechaInicio;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.GroupBox groupImagenEmpleado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblIDupdate;
        private FontAwesome.Sharp.IconPictureBox iconIDempleado;
        private System.Windows.Forms.TextBox txtIDUpdate;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBTNenter;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private FontAwesome.Sharp.IconPictureBox iconIDeliminar;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconInsert;
        private FontAwesome.Sharp.IconButton iconUpdate;
        private System.Windows.Forms.DateTimePicker dateFin;
        private FontAwesome.Sharp.IconPictureBox iconFechaFin;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Panel panelColor6;
        private System.Windows.Forms.Panel panelColor5;
        private System.Windows.Forms.Panel panelColor4;
        private System.Windows.Forms.Panel panelColor3;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor;
    }
}

