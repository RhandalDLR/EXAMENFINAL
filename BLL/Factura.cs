
using BLL;
using System;
using System.Collections.Generic;

public class Factura
{
    
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Cliente { get; set; }
    public List<DetFactura> ListaDetalle { get; set; } = new List<DetFactura>();

    public void AgregarDetFactura(DetFactura detFactura) {
        ListaDetalle.Add(detFactura);
    }

    public void CalcularFactura() {
        foreach (var detalle in ListaDetalle)
        {
            detalle.SubTotal = detalle.Cantidad * detalle.Precio;
        }
    }

    public void CalcularImpuesto() {
        foreach (var detalle in ListaDetalle)
        {
            detalle.Impuesto = detalle.SubTotal * 0.18; // ITBIS del 18%
        }
    }

    public void CalcularDescuento() {
        double descuentoPorcentaje = 0.05; // 5%
        foreach (var detalle in ListaDetalle)
        {
            detalle.Total = detalle.SubTotal + detalle.Impuesto - (detalle.SubTotal * descuentoPorcentaje);
        }
    }

    public void CalcularTotal() {
        foreach (var detalle in ListaDetalle)
        {
            detalle.Total = detalle.SubTotal + detalle.Impuesto - (detalle.SubTotal * 0.05);
        }
    }

    public void QuitarIngrediente(DetFactura detFactura) {
        ListaDetalle.Remove(detFactura);
    }

    public List<DetFactura> GetDets() {

        return ListaDetalle;
    }
}

