using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Nomina
    {
        #region PROPIEDADES

        public string Fecha { get; set; }
        public string Mes { get; set; }

        public List<Profesores> ListaProfesores = new List<Profesores>();
        


        #endregion

        #region METODOS

        public void AgregarProfesorNomina(Profesores profesor)
        {

            profesor.ID = ListaProfesores.Count + 1;
            ListaProfesores.Add(profesor);

        }

        public List<Profesores> GetListado()
        {

            return ListaProfesores;
        }

        public void ListarDetalles()
        {


        }

        public void BorrarDetalles(Profesores profesor) 
        {  
                ListaProfesores.Remove(profesor);
        }

        #endregion

    }
}
