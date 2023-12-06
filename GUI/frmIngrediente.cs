using BLL;
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
    public partial class frmIngrediente : Form
    {
        Productos producto = new Productos();
        public frmIngrediente() {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e) {

            {
                Ingrediente ingrediente = new Ingrediente();

                producto.nombre = txtNombre.Text;
                ingrediente.cantidad = Convert.ToDouble(txtCantidad.Text);
                ingrediente.Precio = Convert.ToDouble(txtPrecio.Text);

                producto.AgregarIngrediente(ingrediente);
                this.DGVINGREDIENTES.DataSource = null;
                this.DGVINGREDIENTES.DataSource = producto.GetListado();
                ingrediente.CalcularCosto();



            };



        }

        private void button3_Click(object sender, EventArgs e) {

            Ingrediente ingrediente = new Ingrediente();


            int countlist = producto.ListaIngredientes.Count();

            if (countlist > 0)
            {

                int id = Convert.ToInt32(DGVINGREDIENTES.CurrentRow.Cells[0].Value);

                ingrediente = producto.ListaIngredientes.Find(x => x.ID == id);
                producto.QuitarIngrediente(ingrediente);
                DGVINGREDIENTES.DataSource = null;
                DGVINGREDIENTES.DataSource = producto.GetListado();

            }

        }
    }





}


