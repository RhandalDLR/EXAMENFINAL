using BLL;
using Reporte;
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
    public partial class Facturacion : Form
    {
        Factura factura = new Factura();
        DetFactura detFactura = new DetFactura();
        public Facturacion() {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            //Factura factura = new Factura();
            factura.Fecha = Convert.ToDateTime(this.dtpFecha.Text);
            factura.Cliente = this.txtCliente.Text;
            detFactura.Producto = this.txtProducto.Text;
            detFactura.Cantidad = Convert.ToDouble(this.txtCantidad.Text);
            detFactura.Precio = Convert.ToDouble(this.txtPrecio.Text);

            factura.AgregarDetFactura(detFactura);
            this.DTGFactura.DataSource = null;
            this.DTGFactura.DataSource = factura.GetDets();
            factura.CalcularFactura();
            factura.CalcularImpuesto();
            factura.CalcularDescuento();
            factura.CalcularTotal();



        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            frmVisorReportes frmVisor = new frmVisorReportes();

            List<DetFactura> detFacturas = factura.GetDets();

            string nombreReporte = "Reporte.Reportes.Factura.rdlc";

            frmVisor.Imprimir(nombreReporte, detFacturas);



        }
    }
}
