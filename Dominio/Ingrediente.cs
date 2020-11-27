using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoComodato
{
    public class Ingrediente
    {
        // Atributos y métodos get y set de la clase Ingrediente
        public int ingId { get; set; } 
        public String ingNombre { get; set; }
        public String ingDescripcion { get; set; }
        public String ingUnidadMedida { get; set; }

        // Metodo constructor
        public Ingrediente(int ingId, String ingNombre, String ingDescripcion, String ingUnidadMedida)
        {
            this.ingId = ingId;
            this.ingNombre = ingNombre;
            this.ingDescripcion = ingDescripcion;
            this.ingUnidadMedida = ingUnidadMedida;
        }

        // Metodos de la clase Ingrediente
        public void ConsultarIngrediente()
        {
            // Excepcion: Ingrediente no resgistrado
            Console.WriteLine("Ingrediente consultado");
        }
        public void AdicionarIngrediente()
        {
            // Excepcion: Ingrediente ya registrado
            // Excepcion: Datos obligatorios incompletos
            Console.WriteLine("Ingrediente adicionado");
        }
        public void ModificarIngrediente()
        {
            // Excepcion: Datos obligatorios incompletos
            Console.WriteLine("Ingrediente modificado");
        }
        public void InhabilitarIngrediente()
        {
            Console.WriteLine("Ingrediente eliminado");
        }
        public void ReporteStock()
        {
            Console.WriteLine("Reporte stock ingrediente");
        }
    }
}
