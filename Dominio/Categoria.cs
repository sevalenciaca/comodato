using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoComodato
{
    public class Categoria
    {
        // Atributos y métodos get y set de la clase Categoria
        public int catId { get; set; } 
        public String catNombre { get; set; }
        public String catDescripcion { get; set; }

        // Metodo constructor
        // public Categoria(int catId, String catNombre, String catDescripcion)
        // {
        //     this.catId = catId;
        //     this.catNombre = catNombre;
        //     this.catDescripcion = catDescripcion;
        // }

        // Metodos de la clase Categoria
        public void AdicionarCategoria()
        {
            Console.WriteLine("Categoria adicionada");
        }
        public void InhabilitarCategoria()
        {
            Console.WriteLine("Categoria eliminada");
        }
        public void ModificarCategoria()
        {
            Console.WriteLine("Categoria modificada");
        }
        public void ConsultarCategoria()
        {
            Console.WriteLine("Categoria consultada");
        }
        public void ReporteCategoriaIngrediente()
        {
            Console.WriteLine("Reporte categoria ingrediente");
        }
    }
}