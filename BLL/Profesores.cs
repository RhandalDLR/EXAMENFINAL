namespace BLL
{
    public class Profesores
    {

        #region PROPIEDADES

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double HorasTrabajadas { get; set; }
        public double PrecioHoras { get; set; }
        public double AFP { get; set; }
        public double SS { get; set; }
        public double TotaDescuento { get; set; }
        public double SueldoBase { get; set; }
        public double SueldoNeto { get; set; }

        #endregion

        //#region CONTRUCTORES

        //public Profesores(int iD, string nombre, string apellido, double horasTrabajadas, double precioHoras, double aFP, double sS, double totaDescuento, double sueldoBase, double sueldoNeto)
        //{
        //    ID = iD;
        //    Nombre = nombre;
        //    Apellido = apellido;
        //    HorasTrabajadas = horasTrabajadas;
        //    PrecioHoras = precioHoras;
        //    AFP = aFP;
        //    SS = sS;
        //    TotaDescuento = totaDescuento;
        //    SueldoBase = sueldoBase;
        //    SueldoNeto = sueldoNeto;
        //}
        //#endregion





        public void CalcularSueldo() {
            SueldoBase = HorasTrabajadas * PrecioHoras;
            SueldoNeto = SueldoBase - TotaDescuento;
        }

        public void CalcularDescuento() {
            AFP = SueldoBase * 0.03;
            SS = SueldoBase * 0.04;
            TotaDescuento = AFP + SS;
            SueldoNeto = SueldoBase - TotaDescuento;
        }









    }
}
