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
    public partial class Cargo : Form
    {
        private EupEntities1 _context = new EupEntities1();
        public Cargo()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {

            var listaCargos = _context.Cargo

                  .Select(c => new {
                      ID = c.CargoID,
                      Cargo = c.NombreCargo,
                      Estado = c.Activo ? "Activo" : "Desactivado",

                      // Foto_Empleado = e.FotoEmpleado,


                  }).ToList();

            dgv.DataSource = listaCargos;
        }


        private void iconButtonCrearAdmin_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            AccionesCargos control = new AccionesCargos();

            control.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(control);
        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            dgv.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(dgv);
            cargarDatos();

        }

        public void ExportarExcel()
        {


            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show($"Ruta del escritorio detectada:\n{escritorio}");
            string carpeta = Path.Combine(escritorio, "CargosE_UPexcel");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);


            string ruta = Path.Combine(carpeta, $"Cargo_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

            var workbook = new ClosedXML.Excel.XLWorkbook();
            var hoja = workbook.Worksheets.Add("CargoE_UP");

            hoja.Cell(1, 1).Value = "Cargo_ID";
            hoja.Cell(1, 2).Value = "Cargo";
            hoja.Cell(1, 3).Value = "Activo";
            

            // Obtener datos desde la base
            var listaCargos = _context.Cargo.ToList();

            int fila = 2;
            foreach (ModeloEF.Cargo cargo in listaCargos)
            {
                hoja.Cell(fila, 1).Value = cargo.CargoID;
                hoja.Cell(fila, 2).Value = cargo.NombreCargo;
                hoja.Cell(fila, 3).Value = cargo.Activo ? "Activo" : "Desactivado";
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

            var listaCargos = _context.Cargo.ToList();
            if (listaCargos.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay Cargos para exportar.");
                return;
            }
            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato Excel", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExportarExcel();

            }

        }
        public void ExportarCSV()

        {

            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string carpeta = Path.Combine(escritorio, "Cargo_E-UP_CSV");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string ruta = Path.Combine(carpeta, "Cargo_" + DateTime.Now.Ticks + ".csv");
            var listaCargos = _context.Cargo.ToList();

            using (StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                sw.WriteLine("Cargo_ID, Cargo, Activo ");

                foreach (ModeloEF.Cargo cargo in listaCargos)
                {
                    sw.WriteLine($"{cargo.CargoID}, {cargo.NombreCargo}, {(cargo.Activo ? "Activo" : "Desactivado")} ");
                }
            }

            System.Windows.Forms.MessageBox.Show("Exportación CSV completada:\n" + ruta, "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
            var listaCargos = _context.Cargo.ToList();
            if (listaCargos.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay Cargos para exportar.");
                return;
            }
            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato .CSV", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExportarCSV();

            }




        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv.Columns[e.ColumnIndex].Name == "Estado" && e.Value.ToString() == "Desactivado")
            {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }
    }

   



    }
