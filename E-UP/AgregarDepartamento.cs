using E_UP.ModeloEF;
using SixLabors.Fonts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace E_UP
{
    public partial class AgregarDepartamento : UserControl
    {
        private EupEntities1 _context = new EupEntities1();
        public AgregarDepartamento()
        {
            InitializeComponent();
            txtDepa.MaxLength = 100;
            txtDepaUpdate.MaxLength = 100;
        }

        private void txtDepaID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepa.Text))
            {
                MessageBox.Show("El campo Nombre del Departamento es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModeloEF.Departamento nuevoDepartamento = new ModeloEF.Departamento
            {
                NombreDepartamento = txtDepa.Text,
                Activo = true

            };
            _context.Departamento.Add(nuevoDepartamento);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Departamento agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDepa.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Insertar un departamento",
                Tabla = "Departamentos",
                RegistroID = nuevoDepartamento.DepartamentoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
            //this.cargarDatos();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDepaUpdate.Text))
            {
                MessageBox.Show("El campo Nombre del Departamento es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtIDupdate.Text))
            {
                MessageBox.Show("El campo ID del Departamento es obligatorio para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int departamentoID = Convert.ToInt32(txtIDupdate.Text);

            var departamentoExistente = _context.Departamento.FirstOrDefault(q => q.DepartamentoID.Equals(departamentoID));

            if (departamentoExistente == null) { 
            
                MessageBox.Show("El Empleado no existe.");
                return;
            }
            if (!departamentoExistente.Activo)
            {
                MessageBox.Show("No se puede modificar un departamento desactivado. Solo puede reactivarse.");
                return;
            }
            departamentoExistente.NombreDepartamento = txtDepaUpdate.Text;

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado el empleado en la base de datos.");
            }
            //this.cargarDatos();
            txtDepaUpdate.Clear();
            txtIDupdate.Clear();

            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Actualizar un departamento",
                Tabla = "Departamentos",
                RegistroID = departamentoExistente.DepartamentoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
            //this.cargarDatos();


        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtIDeliminar.Text))
            {
                MessageBox.Show("El campo ID del Departamento es obligatorio para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int departamentoID = Convert.ToInt32(txtIDeliminar.Text);

            ModeloEF.Departamento departamento = _context.Departamento.FirstOrDefault(q => q.DepartamentoID == departamentoID);

            if (departamento == null)
            {
                MessageBox.Show("El departamento no existe.");
                return;
            }

            bool usado = _context.Empleados.Any(d => d.DepartamentoID == departamentoID);

            if (usado)
            {
                departamento.Activo = false; // marcar como desactivado
                txtIDeliminar.Clear();

                // Registrar Acción en Auditoría
                ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
                {
                    Usuario = "Administrador",
                    Accion = "Desactivar un departamento",
                    Tabla = "Departamentos",
                    RegistroID = departamento.DepartamentoID,
                    FechaAccion = DateTime.Now,
                };


                _context.Auditoria.Add(auditoria);

                int rowsAffectedAuditoria = _context.SaveChanges();
                if (rowsAffectedAuditoria > 0)
                {
                    MessageBox.Show("Se ha desactivado el Departamento, ya que es utilizado en la tabla Empleados.");

                    MessageBox.Show("Se ha capturado la acción para auditar.");
                }
            }
            else
            {
                _context.Departamento.Remove(departamento); // eliminar físicamente

                txtIDeliminar.Clear();

                // Registrar Acción en Auditoría
                ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
                {
                    Usuario = "Administrador",
                    Accion = "Eliminar un departamento",
                    Tabla = "Departamentos",
                    RegistroID = departamento.DepartamentoID,
                    FechaAccion = DateTime.Now,
                };


                _context.Auditoria.Add(auditoria);

                int rowsAffectedAuditoria = _context.SaveChanges();
                if (rowsAffectedAuditoria > 0)
                {
                    MessageBox.Show("Se ha capturado la acción para auditar.");
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReactivarDepaID.Text))
            {
                MessageBox.Show("El campo Reactivar ID del Departamento es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int departamentoID = Convert.ToInt32(txtReactivarDepaID.Text);
            ModeloEF.Departamento departamento = _context.Departamento.FirstOrDefault(q => q.DepartamentoID.Equals(departamentoID));

            if (departamento == null)
            {
                MessageBox.Show("El departamento no existe.");
                return;
            }

            departamento.Activo = true; // volver a activar
            _context.SaveChanges();

            MessageBox.Show("El departamento ha sido reactivado correctamente.");

            txtReactivarDepaID.Clear();

            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Reactivar un departamento",
                Tabla = "Departamentos",
                RegistroID = departamento.DepartamentoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



