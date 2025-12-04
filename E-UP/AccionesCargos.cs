using E_UP.ModeloEF;
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
    public partial class AccionesCargos : UserControl
    {
        private ModeloEF.EupEntities1 _context = new ModeloEF.EupEntities1();
        public AccionesCargos()
        {
            InitializeComponent();
            txtCargo.MaxLength = 100;
            txtCargoUpdate.MaxLength = 100;
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCargoUpdate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDupdate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIDeliminar_KeyPress(object sender, KeyPressEventArgs e)
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
            if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("El campo Nombre del Cargo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ModeloEF.Cargo nuevoCargo = new ModeloEF.Cargo
            {
                NombreCargo = txtCargo.Text,
                Activo = true

            };
            _context.Cargo.Add(nuevoCargo);

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Cargo agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCargo.Clear();
            }
            else
            {
                MessageBox.Show("No se pudo agregar el cargo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Insertar un cargo",
                Tabla = "Cargos",
                RegistroID = nuevoCargo.CargoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
        }

        private void iconUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCargoUpdate.Text))
            {
                MessageBox.Show("El campo Nombre del Cargo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtIDupdate.Text))
            {
                MessageBox.Show("El campo ID del Cargo es obligatorio para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cargoID = Convert.ToInt32(txtIDupdate.Text);

            var cargoExistente = _context.Cargo.FirstOrDefault(q => q.CargoID.Equals(cargoID));

            if (cargoExistente == null)
            {

                MessageBox.Show("El Cargo no existe.");
                return;
            }
            if (!cargoExistente.Activo)
            {
                MessageBox.Show("No se puede modificar un cargo desactivado. Solo puede reactivarse.");
                return;
            }
            cargoExistente.NombreCargo = txtCargoUpdate.Text;

            int rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Se ha actualizado el carrgo en la base de datos.");
            }
            //this.cargarDatos();
            txtCargoUpdate.Clear();
            txtIDupdate.Clear();

            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Actualizar un cargo",
                Tabla = "Cargos",
                RegistroID = cargoExistente.CargoID,
                FechaAccion = DateTime.Now,
            };


            _context.Auditoria.Add(auditoria);

            int rowsAffectedAuditoria = _context.SaveChanges();
            if (rowsAffectedAuditoria > 0)
            {
                MessageBox.Show("Se ha capturado la acción para auditar.");
            }
        }

        private void iconDelete_Click(object sender, EventArgs e)
        {
           
            int cargoID = Convert.ToInt32(txtIDeliminar.Text);
            ModeloEF.Cargo cargo = _context.Cargo.FirstOrDefault(q => q.CargoID.Equals(cargoID));

            if (cargo == null)
            {
                MessageBox.Show("El cargo no existe.");
                return;
            }

            bool usado = _context.Empleados.Any(c => c.CargoID == cargoID);

            if (usado)
            {
                cargo.Activo = false; // marcar como desactivado
                txtIDeliminar.Clear();

                // Registrar Acción en Auditoría
                ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
                {
                    Usuario = "Administrador",
                    Accion = "Desactivar un cargo",
                    Tabla = "Cargos",
                    RegistroID = cargo.CargoID,
                    FechaAccion = DateTime.Now,
                };


                _context.Auditoria.Add(auditoria);

                int rowsAffectedAuditoria = _context.SaveChanges();
                if (rowsAffectedAuditoria > 0)
                {
                    MessageBox.Show("Se ha desactivado el Cargo, ya que es utilizado en la tabla Empleados.");

                    MessageBox.Show("Se ha capturado la acción para auditar.");
                }
            }
            else
            {
                _context.Cargo.Remove(cargo); // eliminar físicamente

                txtIDeliminar.Clear();

                // Registrar Acción en Auditoría
                ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
                {
                    Usuario = "Administrador",
                    Accion = "Eliminar un cargo",
                    Tabla = "Cargos",
                    RegistroID = cargo.CargoID,
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int cargoID = Convert.ToInt32(txtReactivarCargoID.Text);
            ModeloEF.Cargo cargo = _context.Cargo.FirstOrDefault(q => q.CargoID.Equals(cargoID));

            if (cargo == null)
            {
                MessageBox.Show("El cargo no existe.");
                return;
            }

            cargo.Activo = true; // volver a activar
            _context.SaveChanges();

            MessageBox.Show("El cargo ha sido reactivado correctamente.");

            txtReactivarCargoID.Clear();

            // Registrar Acción en Auditoría
            ModeloEF.Auditoria auditoria = new ModeloEF.Auditoria()
            {
                Usuario = "Administrador",
                Accion = "Reactivar un cargo",
                Tabla = "Cargos",
                RegistroID = cargo.CargoID,
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

