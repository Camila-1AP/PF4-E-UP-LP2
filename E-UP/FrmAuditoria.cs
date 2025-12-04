using E_UP.ModeloEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_UP
{
    public partial class FrmAuditoria : Form
    {
        private EupEntities1 _context = new EupEntities1();
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        private void Auditoria_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }
        private void cargarDatos()
        {
           
            var listaAuditoria = _context.Auditoria

                  .Select(a => new {
                      ID = a.AuditoriaID,
                      Usuario = a.Usuario,
                      Accion = a.Accion,
                      Tabla = a.Tabla,
                      Registo_ID = a.RegistroID,
                      Fecha_Accion = a.FechaAccion

                  }).ToList();

            dgvAuditoria.DataSource = listaAuditoria;
        }

        public void ExportarExcel()
        {



            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show($"Ruta del escritorio detectada:\n{escritorio}");
            string carpeta = Path.Combine(escritorio, "AuditoriaE_UPexcel");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);


            string ruta = Path.Combine(carpeta, $"Auditoría_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

            var workbook = new ClosedXML.Excel.XLWorkbook();
            var hoja = workbook.Worksheets.Add("AuditoríaE_UP");

            hoja.Cell(1, 1).Value = "Auditoría_ID";
            hoja.Cell(1, 2).Value = "Usuario";
            hoja.Cell(1, 3).Value = "Acción";
            hoja.Cell(1, 4).Value = "Tabla";
            hoja.Cell(1, 5).Value = "Registro_ID";
            hoja.Cell(1, 6).Value = "Fecha_Acción";

            // Obtener datos desde la base
            var listaAuditoria = _context.Auditoria.ToList();

            int fila = 2;
            foreach (Auditoria auditoria in listaAuditoria)
            {
                hoja.Cell(fila, 1).Value = auditoria.AuditoriaID;
                hoja.Cell(fila, 2).Value = auditoria.Usuario;
                hoja.Cell(fila, 3).Value = auditoria.Accion;
                hoja.Cell(fila, 4).Value = auditoria.Tabla;
                hoja.Cell(fila, 5).Value = auditoria.RegistroID;
                hoja.Cell(fila, 6).Value = auditoria.FechaAccion?.ToString("dd/MM/yyyy HH:mm"); ;
                fila++;
            }

            workbook.SaveAs(ruta);

            try
            {
                workbook.SaveAs(ruta);
                MessageBox.Show($"Exportación Excel completada:\n{ruta}", "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconButtonExcel_Click(object sender, EventArgs e)
        {
            var listaAuditoria = _context.Auditoria.ToList();
            if (listaAuditoria.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay Auditoría para exportar.");
                return;
            }
            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato Excel", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExportarExcel();
           
            }
        }
    }
}
