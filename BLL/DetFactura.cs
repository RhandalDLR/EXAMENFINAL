
namespace BLL
{
    public class DetFactura
    {
        public string Producto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public double Impuesto { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public double Descuento { get; set; }
    }
}