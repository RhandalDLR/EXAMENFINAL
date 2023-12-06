using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Productos
    {
        public string nombre { get; set; }
        public double caracteristica { get; set; }

        public List<Ingrediente> ListaIngredientes = new List<Ingrediente>();


        public void AgregarIngrediente(Ingrediente ingrediente) {

            ingrediente.ID = ListaIngredientes.Count + 1;
            ListaIngredientes.Add(ingrediente);

        }

        public List<Ingrediente> GetListado() {

            return ListaIngredientes;
        }

        public void QuitarIngrediente(Ingrediente ingrediente) {

            ListaIngredientes.Remove(ingrediente);
        }



    }
}
