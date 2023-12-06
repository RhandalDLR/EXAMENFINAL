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
    public partial class NominaProfesores : Form
    {
        Nomina nomina = new Nomina();
        public NominaProfesores() {
            InitializeComponent();
        }

        private void txtAgregar_Click(object sender, EventArgs e) {
            Profesores profesores = new Profesores();
            profesores.Nombre = this.txtNombre.Text;
            profesores.Apellido = this.txtApellido.Text;
            profesores.HorasTrabajadas = Convert.ToDouble(txtHorasTrabajadas.Text);
            profesores.PrecioHoras = Convert.ToDouble(txtPrecioPorHora.Text);

            nomina.AgregarProfesorNomina(profesores);
            this.dataGV.DataSource = null;
            this.dataGV.DataSource = nomina.GetListado();
            profesores.CalcularSueldo();
            profesores.CalcularDescuento();
            Limpiar();
            CalcularTotales();
        }

        public void BorrarProfesor() {
            Profesores profesores = new Profesores();


            int countlist = nomina.ListaProfesores.Count();

            if (countlist > 0)
            {

                int id = Convert.ToInt32(dataGV.CurrentRow.Cells[0].Value);

                profesores = nomina.ListaProfesores.Find(x => x.ID == id);
                nomina.BorrarDetalles(profesores);
                dataGV.DataSource = null;
                dataGV.DataSource = nomina.GetListado();

            }

            else
            {
                return;
            }

                CalcularTotales();

        }


        public void Limpiar() {
            txtNombre.Clear();
            txtApellido.Clear();
            txtHorasTrabajadas.Clear();
            txtPrecioPorHora.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e) {
            BorrarProfesor();
        }

        public void CalcularTotales() {


            List<Profesores> ListaP = nomina.GetListado();

            double totalSueldoNeto = ListaP.Sum(x => x.SueldoNeto);
            double totalSueldoBase = ListaP.Sum(x => x.SueldoBase);
            double totalAFP = ListaP.Sum(x => x.AFP);
            double totalSS = ListaP.Sum(x => x.SS);
            double totalDescuentos = ListaP.Sum(x => x.TotaDescuento);

            txtTotalSueldoNeto.Text = String.Format(totalSueldoNeto.ToString(), "C");
            txtTotalSueldoBase.Text = String.Format(totalSueldoBase.ToString(), "C");
            txtTotalAFP.Text = String.Format(totalAFP.ToString());
            txtTotalSS.Text = String.Format(totalSS.ToString(), "C");
            txtTotalDescuentos.Text = String.Format(totalDescuentos.ToString(), "C");

        }
    }
}
