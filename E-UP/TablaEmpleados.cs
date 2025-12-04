using ClosedXML.Excel;
//using ClosedXML.Excel.Hyperlinks;
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
    public partial class TablaEmpleados : Form
    {
        private EupEntities1 _context = new EupEntities1();
      
        private string rutaImagenSeleccionada;
        private byte[] fotoEmpleado;
        private string extensionImagen;
        public TablaEmpleados()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {
            var listaEmpleados = _context.Empleados
                 .Include("Departamento")
                 .Include("Cargo")
                 .OrderByDescending(e => e.Estado)
                 .ThenBy(e => e.EmpleadoID)
                 .ToList(); 
            var listaEmpleadosFormateada = listaEmpleados

                  .Select(e => new {
                      ID = e.EmpleadoID,
                      Nombre_Empleado = e.Nombre,
                      Departamento = e.Departamento.NombreDepartamento,
                      Cargo = e.Cargo.NombreCargo,
                      Fecha_Inicio = e.FechaInicio.ToString("dd/MM/yyyy"),
                      Fecha_Desactivacion = e.FechaFin,
                      Sueldo_Bruto = e.SueldoBruto.ToString("N2"),
                      Estado = e.Estado ? "Vigente" : "No Vigente",
                      AFP = e.AFP?.ToString("N2") ?? "0.00",
                      ARS = e.ARS?.ToString("N2") ?? "0.00",
                      ISR = e.ISR?.ToString("N2") ?? "0.00",
                      Total_Descuentos = e.TotalDescuentos?.ToString("N2") ?? "0.00",
                      Sueldo_Neto = e.SueldoNeto?.ToString("N2") ?? "0.00",
                      Tiempo_en_Empresa = e.TiempoEnEmpresa,
                      Fecha_Registro = e.FechaRegistro?.ToString("dd/MM/yyyy"),

                      CargoActivo = e.Cargo.Activo,
                      DepartamentoActivo = e.Departamento.Activo

                      // Foto_Empleado = e.FotoEmpleado,


                  }).ToList();

            dgv.DataSource = listaEmpleadosFormateada;
            dgv.Columns["CargoActivo"].Visible = false;
            dgv.Columns["DepartamentoActivo"].Visible = false;
            
        }


        private void Auditoria_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = true;
            cargarDatos();
        }

        private void dgvAuditoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                // Obtener el ID del empleado seleccionado
                int empleadoId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ID"].Value);

                using (var context = new EupEntities1())
                {
                    var empleado = context.Empleados

                        .Include("Cargo")
                        .Include("Departamento") 
                        .FirstOrDefault(emp => emp.EmpleadoID == empleadoId);

                    if (empleado != null && empleado.FotoEmpleado != null)//Verifica si tiene foto y muestra en el PictureBox y labels
                    {
                        lblNombreFoto.Text = empleado.Nombre;

                        lblEstadoFoto.Text = empleado.Estado ? "Vigente" : "No Vigente";
                        lblCargoFoto.Text = empleado.Cargo.NombreCargo;
                        

                      
                        if (empleado.FotoEmpleado == null || empleado.FotoEmpleado.Length == 0)
                        {
                            MessageBox.Show("Este empleado no tiene foto registrada.");
                            pictureBox3.Image = null;
                        }
                        else
                        {
                            using (MemoryStream ms = new MemoryStream(empleado.FotoEmpleado))
                            {
                                pictureBox3.Image = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ExportarExcel()
        {


            string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            MessageBox.Show($"Ruta del escritorio detectada:\n{escritorio}");
            string carpeta = Path.Combine(escritorio, "EmpleadosE_UPexcel");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);


            string ruta = Path.Combine(carpeta, $"Empleados_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

            var workbook = new ClosedXML.Excel.XLWorkbook();
            var hoja = workbook.Worksheets.Add("EmpleadosE_UP");

            hoja.Cell(1, 1).Value = "Empleado_ID";
            hoja.Cell(1, 2).Value = "Nombre";
            hoja.Cell(1, 3).Value = "Departamento_ID";
            hoja.Cell(1, 4).Value = "Cargo_ID";
            hoja.Cell(1, 5).Value = "Fecha_Inicio";
            hoja.Cell(1, 6).Value = "Fecha_Desactivacion";
            hoja.Cell(1, 7).Value = "Sueldo_Bruto";
            hoja.Cell(1, 8).Value = "Estado";
            hoja.Cell(1, 9).Value = "Ver_Foto";
            hoja.Cell(1, 10).Value = "Extensión_Foto";
            hoja.Cell(1, 11).Value = "Fecha_Registro";
            hoja.Cell(1, 12).Value = "AFP";
            hoja.Cell(1, 13).Value = "ARS";
            hoja.Cell(1, 14).Value = "ISR";
            hoja.Cell(1, 15).Value = "Total_Despuestos";
            hoja.Cell(1, 16).Value = "Sueldo_Neto";



            // Obtener datos desde la base
            var listaEmpleados = _context.Empleados.ToList();

            int fila = 2;
            foreach (ModeloEF.Empleados empleados in listaEmpleados)
            {
                hoja.Cell(fila, 1).Value = empleados.EmpleadoID;
                hoja.Cell(fila, 2).Value = empleados.Nombre;
                hoja.Cell(fila, 3).Value = empleados.Departamento.NombreDepartamento;
                hoja.Cell(fila, 4).Value = empleados.Cargo.NombreCargo; 
                hoja.Cell(fila, 5).Value = empleados.FechaInicio.ToString("dd/MM/yyyy");
                hoja.Cell(fila, 6).Value = empleados.FechaFin?.ToString("dd/MM/yyyy");
                hoja.Cell(fila, 7).Value = empleados.SueldoBruto.ToString("N2");
                hoja.Cell(fila, 8).Value = empleados.Estado ? "Vigente" : "No Vigente";


                if (empleados.FotoEmpleado != null && empleados.FotoEmpleado.Length > 0)
                {
                    string carpetaFotos = Path.Combine(carpeta, "Fotos_Empleados_E-UP");
                    if (!Directory.Exists(carpetaFotos))
                        Directory.CreateDirectory(carpetaFotos);

                    string rutaFoto = Path.Combine(carpetaFotos, $"{empleados.EmpleadoID}{empleados.ExtensionImagen}");
                    File.WriteAllBytes(rutaFoto, empleados.FotoEmpleado);

                    hoja.Cell(fila, 9).Value = "Ver Foto";
                    hoja.Cell(fila, 9).SetHyperlink(new XLHyperlink(rutaFoto));
                }
                else
                {
                    hoja.Cell(fila, 9).Value = "Sin foto";
                }

                hoja.Cell(fila, 10).Value = empleados.ExtensionImagen ?? "Sin extensión";
                hoja.Cell(fila, 11).Value = empleados.FechaRegistro?.ToString("dd/MM/yyyy");
                hoja.Cell(fila, 12).Value = empleados.AFP?.ToString("N2") ?? "0.00";
                hoja.Cell(fila, 13).Value = empleados.ARS?.ToString("N2") ?? "0.00";
                hoja.Cell(fila, 14).Value = empleados.ISR?.ToString("N2") ?? "0.00";
                hoja.Cell(fila, 15).Value = empleados.TotalDescuentos?.ToString("N2") ?? "0.00";
                hoja.Cell(fila, 16).Value = empleados.SueldoNeto.HasValue ? empleados.SueldoBruto.ToString("N2") : "0.00";
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
            var listaEmpleados = _context.Empleados.ToList();
            if (listaEmpleados.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay Empleados para exportar.");
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
            string carpeta = Path.Combine(escritorio, "Empleados_E-UP_CSV");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            string ruta = Path.Combine(carpeta, "Empleados_" + DateTime.Now.Ticks + ".csv");
            var listaEmpleados = _context.Empleados.ToList();

            using (StreamWriter sw = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                sw.WriteLine("Empleado_ID, Nombre, Departamento_ID, Cargo_ID, Fecha_Inicio, Fecha_Desactivacion, Sueldo_Bruto, Estado, Fecha_Registro, AFP, ARS, ISR, Total_Despuestos, Sueldo_Neto");

                foreach (ModeloEF.Empleados empleados in listaEmpleados)
                {
                    sw.WriteLine($"{empleados.EmpleadoID}, {empleados.Nombre}, {empleados.DepartamentoID}, {empleados.CargoID}," +
                        $" {empleados.FechaInicio.ToString("dd/MM/yyyy")}, {empleados.FechaFin?.ToString("dd/MM/yyyy") ?? "Sin fecha"}, {empleados.SueldoBruto.ToString("N2")} " +
                        $" {(empleados.Estado ? "Vigente" : "No Vigente") }, {empleados.FechaRegistro?.ToString("dd/MM/yyyy") ?? "No registrada"}, {empleados.AFP?.ToString("N2") ?? "0.00"}, {empleados.ARS?.ToString("N2") ?? "0.00"}, {empleados.ISR?.ToString("N2") ?? "0.00"}, {empleados.TotalDescuentos?.ToString("N2") ?? "0.00"}, " +
                        $" {(empleados.SueldoNeto.HasValue ? empleados.SueldoBruto.ToString("N2") : "0.00")}");
                }
            }

            System.Windows.Forms.MessageBox.Show("Exportación CSV completada:\n" + ruta, "Exportación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void iconButtonCSV_Click(object sender, EventArgs e)
        {
            var listaEmpleados = _context.Empleados.ToList();
            if (listaEmpleados.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("No hay Empleados para exportar.");
                return;
            }
            if (System.Windows.Forms.MessageBox.Show("¿Desea exportar en formato .CSV", "Exportar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ExportarCSV();

            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            var row = dgv.Rows[e.RowIndex];

            bool cargoDesactivado = !(bool)row.Cells["CargoActivo"].Value;
            bool departamentoDesactivado = !(bool)row.Cells["DepartamentoActivo"].Value;

            if ((dgv.Columns[e.ColumnIndex].Name == "Cargo" && cargoDesactivado) ||
                (dgv.Columns[e.ColumnIndex].Name == "Departamento" && departamentoDesactivado))
            {
                e.CellStyle.ForeColor = Color.Gray;
            }
        }
    }
}
