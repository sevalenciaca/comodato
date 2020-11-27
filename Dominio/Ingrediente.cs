using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoComodato
{
    public class Ingrediente
    {
        // Atributos y métodos get y set de la clase Ingrediente
        public int Id { get; set; } 
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String UnidadMedida { get; set; }

        // Metodo constructor
        public Ingrediente(int Id, String Nombre, String Descripcion, String UnidadMedida)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.UnidadMedida = UnidadMedida;
        }

        // Metodos de la clase Ingrediente
        public void AdicionarIngrediente()
        {
            Console.WriteLine("Ingrediente adicionado");
        }
        public void InhabilitarIngrediente()
        {
            Console.WriteLine("Ingrediente eliminado");
        }
        public void ModificarIngrediente()
        {
            Console.WriteLine("Ingrediente modificado");
        }
        public void ConsultarIngrediente()
        {
            Console.WriteLine("Ingrediente consultado");
        }
        public void ReporteStock()
        {
            Console.WriteLine("Reporte stock ingrediente");
        }
    }
}
