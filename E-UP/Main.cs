using E_UP.Clases;
using E_UP.ModeloEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity; // habilita Include tipado en EF6
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace E_UP
{
    public partial class Main : Form
    {
        private EupEntities1 _context = new EupEntities1();
        public Main()
        {
            InitializeComponent();

            menuStrip1.BackColor = Color.FromArgb(42, 35, 54);
            homeTool.ForeColor = Color.FromArgb(217, 210, 208);
            homeTool.BackColor = Color.FromArgb(42, 35, 54);


            administradorTool.ForeColor = Color.FromArgb(217, 210, 208);

            administradorTool.BackColor = Color.FromArgb(42, 35, 54);

            RRHHTool.BackColor = Color.FromArgb(42, 35, 54);
            RRHHTool.ForeColor = Color.FromArgb(217, 210, 208);
            auditoriaTool.BackColor = Color.FromArgb(42, 35, 54);
            auditoriaTool.ForeColor = Color.FromArgb(217, 210, 208);
            tablaTool.BackColor = Color.FromArgb(42, 35, 54);
            tablaTool.ForeColor = Color.FromArgb(217, 210, 208);
            departamentoTool.BackColor = Color.FromArgb(42, 35, 54);
            departamentoTool.ForeColor = Color.FromArgb(217, 210, 208);
            cargoTool.BackColor = Color.FromArgb(42, 35, 54);
            cargoTool.ForeColor = Color.FromArgb(217, 210, 208);
            menuStrip1.Renderer = new MyRenderer();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void acrylicPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void administradorTool_Click(object sender, EventArgs e)
        {

            

            panelCredenciales.Visible = false;
            Form1 frmAdmin = new Form1
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmAdmin.Show();
            frmAdmin.WindowState = FormWindowState.Maximized;
        }

        private void iconBTNenter_Click(object sender, EventArgs e)
        {


            // Captura del texto ingresado en los TextBox
            string usuario = txtRol.Text.Trim();   // nombre de usuario
            string clave = txtPass.Text.Trim();       // contraseña

            // Consulta en la base de datos
            var user = _context.Usuarios
                .Include(u => u.Roles)
                .FirstOrDefault(u => u.NombreUsuario == usuario && u.Clave == clave);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
                return;
            }

            // Si existe, mostramos el rol
            MessageBox.Show($"Bienvenido {user.NombreUsuario}, Rol: {user.Roles.NombreRol}");

            // Control de permisos según rol
            if (user.Roles.NombreRol == "Administrador")
            {

                administradorTool.Visible = true;
                auditoriaTool.Visible = true;
                tablaTool.Visible = true;
                departamentoTool.Visible = true;
                cargoTool.Visible = true;
                RRHHTool.Visible = false;

                txtRol.Clear();
                txtPass.Clear();
            }
            else if (user.Roles.NombreRol == "RRHH")
            {

                administradorTool.Visible = false;
                auditoriaTool.Visible = false;
                RRHHTool.Visible = true;
                tablaTool.Visible = true;
                departamentoTool.Visible = false;
                cargoTool.Visible = false;
                txtRol.Clear();
                txtPass.Clear();
            }

        }

        private void homeTool_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
            {
                if (frm != this)
                    frm.Hide();
            }
            panelCredenciales.Visible = true;
        }

        private void menuStrip1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void homeTool_MouseHover(object sender, EventArgs e)
        {

         
        }

        private void homeTool_MouseLeave(object sender, EventArgs e)
        {
         
        }

        private void homeTool_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void auditoríaTool_Click(object sender, EventArgs e)
        {
            panelCredenciales.Visible = false;
            FrmAuditoria frmAuditoria = new FrmAuditoria
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmAuditoria.Show();
            frmAuditoria.WindowState = FormWindowState.Maximized;
        }

        private void RRHHTool_Click(object sender, EventArgs e)
        {
            panelCredenciales.Visible = false;
            RRHH frmRRHH = new RRHH
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmRRHH.Show();
            frmRRHH.WindowState = FormWindowState.Maximized;

            
        }

        private void tablaTool_Click(object sender, EventArgs e)
        {
            panelCredenciales.Visible = false;
            TablaEmpleados frmAuditoria = new TablaEmpleados
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmAuditoria.Show();
            frmAuditoria.WindowState = FormWindowState.Maximized;
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCredenciales.Visible = false;

            Departamento frmDepartamento = new Departamento
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmDepartamento.Show();
            frmDepartamento.WindowState = FormWindowState.Maximized;

        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelCredenciales.Visible = false;
            Cargo frmCargo = new Cargo
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            frmCargo.Show();
            frmCargo.WindowState = FormWindowState.Maximized;
        }
    }
}
