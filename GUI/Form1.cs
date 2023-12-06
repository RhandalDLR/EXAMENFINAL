using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            personalizarMenu();
        }
        #region
        private void btnNomina_Click(object sender, EventArgs e) {
            mostrarSubmenu(panelsSubMenuFormularios);
        }

        private void personalizarMenu() {
            panelsSubMenuFormularios.Visible = false;

        }
        private void ocultarMenu() {
            if (panelsSubMenuFormularios.Visible == true)
                panelsSubMenuFormularios.Visible = false;

        }
        private void mostrarSubmenu(Panel panelsSubMenu) {
            if (panelsSubMenu.Visible == false)
            {
                ocultarMenu();
                panelsSubMenu.Visible = true;
            }
            else
                panelsSubMenu.Visible = false;

        }

        private Form FormularioActivo = null;
        private void AbrirFormularioHijo(Form FormularioHijo) {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijo.Controls.Add(FormularioHijo);
            panelFormularioHijo.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }
        #endregion
        private void button1_Click(object sender, EventArgs e) {
            AbrirFormularioHijo(new NominaProfesores());


            ocultarMenu();
        }

        private void FormIngredientes_Click(object sender, EventArgs e) {
            AbrirFormularioHijo(new frmIngrediente());

            ocultarMenu();
        }

        private void button3_Click(object sender, EventArgs e) {
            AbrirFormularioHijo(new Facturacion());

            ocultarMenu();
        }
    }
}
