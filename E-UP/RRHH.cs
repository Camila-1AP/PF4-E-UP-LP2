using E_UP.Modelo;
using E_UP.ModeloEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_UP
{
    public partial class RRHH : Form
    {
        private EupEntities1 _context = new EupEntities1();
        // Variable global para guardar la ruta seleccionada
        private string rutaImagenSeleccionada;
        private byte[] fotoEmpleado;
        private string extensionImagen;
        public RRHH()
        {
            InitializeComponent();
        }

        private void cargarDatos()
        {
           
        }
        private void iconButtonUpdateAdmin_Click(object sender, EventArgs e)
        {
          
            iconInsert.Visible = true;
            iconInsert.Enabled = false;
            panelColor3.Visible = false;
            panelColor.Visible = true;

            lblFechaFin.Visible = false;
            dateFin.Visible = false;
            iconFechaFin.Visible = false;
        
            iconUpdate.Enabled = true;
            iconUpdate.Visible = true;

            groupImagenEmpleado.Visible = true;
            groupIngresarEmpleado.Visible = true;
            groupIngresarEmpleado.Text = "Actualizar Empleado";
            iconIDempleado.Visible = true;

            
            txtEmpleadoUpdate.Visible = true;

            lblIDupdate.Visible = true;

            txtEmpleadoUpdate.Visible = true;
            txtEmpleadoUpdate.Enabled = true;
            iconUser.IconColor = Color.FromArgb(42, 35, 54);
            iconSalario.IconColor = Color.FromArgb(42, 35, 54);
            iconFechaInicio.IconColor = Color.FromArgb(42, 35, 54);
            iconEstado.IconColor = Color.FromArgb(42, 35, 54);
            iconDepaID.IconColor = Color.FromArgb(42, 35, 54);
            iconCargoID.IconColor = Color.FromArgb(42, 35, 54);
            iconIDempleado.IconColor = Color.FromArgb(42, 35, 54);
            iconFechaFin.IconColor = Color.FromArgb(42, 35,54 );

            //---
            panelColor.BackColor = Color.FromArgb(42, 35, 54);
            panelColor1.BackColor = Color.FromArgb(42, 35, 54);
            panelColor2.BackColor = Color.FromArgb(42, 35, 54);
            panelColor3.BackColor = Color.FromArgb(42, 35, 54);
            panelColor4.BackColor = Color.FromArgb(42, 35, 54);
            panelColor5.BackColor = Color.FromArgb(42, 35, 54);
            panelColor6.BackColor = Color.FromArgb(42, 35, 54);


        }

        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
          
        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
           
        }

        private void iconButtonMostrar_Click(object sender, EventArgs e)
        {
            iconUpdate.Visible = false;
            groupImagenEmpleado.Visible = false;
            groupIngresarEmpleado.Visible = false;
            iconInsert.Visible = false;

            lblFechaFin.Visible = false;
            dateFin.Visible = false;
            iconFechaFin.Visible = false;

        }

        private void iconButtonCrearAdmin_Click(object sender, EventArgs e)
        {
            groupIngresarEmpleado.Text = "Ingresar Empleado";
            iconUpdate.Enabled = false;
            iconUpdate.Visible = true;
            iconInsert.Visible = true;
            iconInsert.Enabled = true;
            panelColor.Visible = false;
            lblIDupdate.Visible = false;


            lblFechaFin.Visible = false;
            dateFin.Visible = false;
            iconFechaFin.Visible = false;

        
            groupImagenEmpleado.Visible = true;
            groupIngresarEmpleado.Visible = true;

            iconIDempleado.Visible = false;
            txtEmpleadoUpdate.Visible = false;

            panelColor3.Visible = false;
           
        

            iconUser.IconColor = Color.FromArgb(217, 210, 208);
            iconSalario.IconColor = Color.FromArgb(217, 210, 208);
            iconFechaInicio.IconColor = Color.FromArgb(217, 210, 208);
            iconEstado.IconColor = Color.FromArgb(217, 210, 208);
            iconDepaID.IconColor = Color.FromArgb(217, 210, 208);
            iconCargoID.IconColor = Color.FromArgb(217, 210, 208);
            iconFechaFin.IconColor = Color.FromArgb(217, 210, 208);
            //iconIDempleado.IconColor = Color.FromArgb(42, 35, 54);

            //217, 210, 208


            //---
            panelColor.BackColor = Color.FromArgb(217, 210, 208);
            panelColor1.BackColor = Color.FromArgb(217, 210, 208);
            panelColor2.BackColor = Color.FromArgb(217, 210, 208);
            panelColor3.BackColor = Color.FromArgb(217, 210, 208);
            panelColor4.BackColor = Color.FromArgb(217, 210, 208);
            panelColor5.BackColor = Color.FromArgb(217, 210, 208);
            panelColor6.BackColor = Color.FromArgb(217, 210, 208);
        }

        private void iconButtonBar_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu2()
        {

            if (this.panelMenuAdmin.Width > 200)
            {
                panelMenuAdmin.Width = 150;
                pictureBox1.Visible = false;
                iconButtonBar.Dock = DockStyle.Top;
                //panelBarPublico.Visible = false;


                foreach (Button menuButton in panelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0, 10, 0, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleCenter;


                }
            }
        }

        private void CollapseMenu()
        {

            if (this.panelMenuAdmin.Width > 200)
            {
                panelMenuAdmin.Width = 150;
                pictureBox1.Visible = false;
                iconButtonBar.Dock = DockStyle.Top;
                //panelBarPublico.Visible = false;


                foreach (Button menuButton in panelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0, 10, 0, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleCenter;

                }
            }
            else
            {
                panelMenuAdmin.Width = 444;
                pictureBox1.Visible = true;
                iconButtonBar.Dock = DockStyle.Top;



                foreach (Button menuButton in panelMenuAdmin.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 20, 0);
                    iconButtonBar.ImageAlign = ContentAlignment.MiddleLeft;



                }

            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(dateInicio.Text))
            {
                MessageBox.Show("El campo de fecha esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtDepaID.Text))
            {
                MessageBox.Show("El campo del departamento ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCargoID.Text))
            {
                MessageBox.Show("El campo de cargo ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("El campo de salario esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dateInicio.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de inicio no puede ser futura.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario > 99999999.99m)
            {
                MessageBox.Show("El salario excede el límite permitido (máx. 99,999,999.99).");
                return;
            }
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("El salario debe ser un número positivo.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (radioNoVigente.Checked && dateFin.Value < dateInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radioNoVigente.Checked && dateFin.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de fin no puede ser futura.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtEmpleadoUpdate.Visible &&  string.IsNullOrEmpty(txtEmpleadoUpdate.Text))
            {
                MessageBox.Show("El campo de Empleado ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!radioVigente.Checked && !radioNoVigente.Checked)
            {
                MessageBox.Show("Por favor seleccione el estado del empleado (Vigente o No Vigente).", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            // Ruta hacia tu archivo ONNX
            string rutaModelo = Path.Combine(Application.StartupPath, "Models", "yolov5s.onnx");

            // Validar solo si hay imagen cargada
            if (pictureBox1.Image != null)
            {
                var detector = new YoloDetector(rutaModelo);
                bool esPersona = detector.DetectaPersona((Bitmap)pictureBox1.Image);

                if (!esPersona)
                {
                    MessageBox.Show("La imagen cargada no contiene una persona. No se puede guardar el registro.",
                                    "Validación de foto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; // detener guardado si la foto no es válida
                }

            }

            int cargoID = Convert.ToInt32(txtCargoID.Text);
            var cargoExiste = _context.Cargo.Any(c => c.CargoID == cargoID && c.Activo);
            if (!cargoExiste)
            {
                MessageBox.Show("El Cargo ingresado no existe o está desactivado.");
                return;
            }

            int departamentoID = Convert.ToInt32(txtDepaID.Text);
            var departamentoExiste = _context.Departamento.Any(d => d.DepartamentoID == departamentoID && d.Activo);
            if (!departamentoExiste)
            {
                MessageBox.Show("El Departamento ingresado no existe o está desactivado.");
                return;
            }
            //MessageBox.Show("Persona detectada correctamente.");
            Empleados empleado = new Empleados()
            {
                Nombre = txtNombre.Text,
                DepartamentoID = Convert.ToInt32(txtDepaID.Text),
                CargoID = Convert.ToInt32(txtCargoID.Text),
                FechaInicio = dateInicio.Value,
                SueldoBruto = Convert.ToDecimal(txtSalario.Text),
                Estado = radioVigente.Checked ? true : false,
                FechaFin = radioNoVigente.Checked ? (DateTime?)dateFin.Value : null,
                FotoEmpleado = fotoEmpleado,          // imagen en binario
                ExtensionImagen = extensionImagen     // extensión del archivo

            };


            _context.Empleados.Add(empleado);

                int rowsAffected = _context.SaveChanges();
                if (rowsAffected > 0)
                {
                    _context.Entry(empleado).Reload();
                    MessageBox.Show("Se ha insertado el empleado en la base de datos.");
                }
                this.cargarDatos();
                txtNombre.Clear();
                txtDepaID.Clear();
                txtCargoID.Clear();
                txtSalario.Clear();
                radioVigente.Checked = false;
                radioNoVigente.Checked = false;
               // MessageBox.Show("Persona detectada correctamente.");
                

               

            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "RRHH",
                Accion = "Insertar un empleado",
                Tabla = "Empleados",
                RegistroID = empleado.EmpleadoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
            this.cargarDatos();

        }
        

        private void RRHH_Load(object sender, EventArgs e)
        {
            cargarDatos();
            panelCentral.Visible = true;
            lblFechaFin.Visible = false;
            dateFin.Visible = false;
            iconFechaFin.Visible = false;


            txtNombre.MaxLength = 100;
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir dígitos, coma, punto y retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // bloquea el carácter
            }
            /*if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }*/
        }

        private void txtDepaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCargoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEmpleadoUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void radioNoVigente_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaFin.Visible = true;
            dateFin.Visible = true;
            iconFechaFin.Visible = true;
            panelColor3.Visible = true;

        }

        private void radioVigente_CheckedChanged(object sender, EventArgs e)
        {
            lblFechaFin.Visible = false;
            dateFin.Visible = false;
            iconFechaFin.Visible = false;
            panelColor3.Visible= false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen primero.");
                return;
            }

            // Ruta hacia tu archivo ONNX
            string rutaModelo = Path.Combine(Application.StartupPath, "Models", "yolov5s.onnx");

            var detector = new YoloDetector(rutaModelo);

            bool esPersona = detector.DetectaPersona((Bitmap)pictureBox1.Image);

            if (!esPersona)
            {
                MessageBox.Show("La imagen NO contiene una persona.");
            }
            else
            {
                MessageBox.Show("Persona detectada correctamente.");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar imagen";
                ofd.Filter = "Imágenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenSeleccionada = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(rutaImagenSeleccionada);

                    extensionImagen = Path.GetExtension(rutaImagenSeleccionada);
                    fotoEmpleado = File.ReadAllBytes(rutaImagenSeleccionada);


                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                     
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo de nombre esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(dateInicio.Text))
            {
                MessageBox.Show("El campo de fecha esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtDepaID.Text))
            {
                MessageBox.Show("El campo del departamento ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtCargoID.Text))
            {
                MessageBox.Show("El campo de cargo ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("El campo de salario esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario > 99999999.99m)
            {
                MessageBox.Show("El salario excede el límite permitido (máx. 99,999,999.99).");
                return;
            }
            if (!decimal.TryParse(txtSalario.Text, out salario) || salario < 0)
            {
                MessageBox.Show("El salario debe ser un número positivo.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (dateInicio.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de inicio no puede ser futura.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radioNoVigente.Checked && dateFin.Value < dateInicio.Value)
            {
                MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (radioNoVigente.Checked && dateFin.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de fin no puede ser futura.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtEmpleadoUpdate.Visible && string.IsNullOrEmpty(txtEmpleadoUpdate.Text))
            {
                MessageBox.Show("El campo de Empleado ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!radioVigente.Checked && !radioNoVigente.Checked)
            {
                MessageBox.Show("Por favor seleccione el estado del empleado (Vigente o No Vigente).", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(txtEmpleadoUpdate.Text))
            {
                MessageBox.Show("El campo de Empleado ID esta vacío o es incorrecto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (string.IsNullOrWhiteSpace(txtEmpleadoUpdate.Text))
            {
                MessageBox.Show("Debe ingresar un ID de empleado válido.");
                return;
            }

            int EmpleadoID = Convert.ToInt32(txtEmpleadoUpdate.Text);

            Empleados empleados = _context.Empleados.FirstOrDefault(q => q.EmpleadoID.Equals(EmpleadoID));
            if (empleados == null)
            {
                MessageBox.Show("El Empleado no existe.");
                return;
            }
            int cargoID = Convert.ToInt32(txtCargoID.Text);
            var cargoExiste = _context.Cargo.Any(c => c.CargoID == cargoID && c.Activo);
            if (!cargoExiste)
            {
                MessageBox.Show("El Cargo ingresado no existe o está desactivado.");
                return;
            }

            int departamentoID = Convert.ToInt32(txtDepaID.Text);
            var departamentoExiste = _context.Departamento.Any(d => d.DepartamentoID == departamentoID && d.Activo);
            if (!departamentoExiste)
            {
                MessageBox.Show("El Departamento ingresado no existe o está desactivado.");
                return;
            }

            // Ruta hacia tu archivo ONNX
            string rutaModelo = Path.Combine(Application.StartupPath, "Models", "yolov5s.onnx");

            // Validar solo si hay imagen cargada
            if (pictureBox1.Image != null)
            {
                var detector = new YoloDetector(rutaModelo);
                bool esPersona = detector.DetectaPersona((Bitmap)pictureBox1.Image);

                if (!esPersona)
                {
                    MessageBox.Show("La nueva imagen no contiene una persona. No se puede actualizar.",
                                    "Validación de foto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return; // detener guardado si la foto no es válida
                }

            }


            empleados.Nombre = txtNombre.Text;
            empleados.DepartamentoID = Convert.ToInt32(txtDepaID.Text);
            empleados.CargoID = Convert.ToInt32(txtCargoID.Text);
            empleados.FechaInicio = dateInicio.Value;
            empleados.SueldoBruto = Convert.ToDecimal(txtSalario.Text);
            empleados.Estado = radioVigente.Checked ? true : false;
            empleados.FechaFin = radioNoVigente.Checked ? (DateTime?)dateFin.Value : null;
            // Solo actualiza la foto si se seleccionó una nueva
            if (fotoEmpleado != null && fotoEmpleado.Length > 0)
            {
                empleados.FotoEmpleado = fotoEmpleado;
                empleados.ExtensionImagen = extensionImagen;
            }
            

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado el empleado en la base de datos.");
            }

            this.cargarDatos();
            txtNombre.Clear();
            txtDepaID.Clear();
            txtCargoID.Clear();
            txtSalario.Clear();
            radioVigente.Checked = false;
            radioNoVigente.Checked = false;


            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "RRHH",
                Accion = "Actualizar un empleado",
                Tabla = "Empleados",
                RegistroID = empleados.EmpleadoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
            this.cargarDatos();

        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





