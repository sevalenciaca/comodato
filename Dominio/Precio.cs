using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoComodato
{
    public class Precio
    {
        // Atributos y métodos get y set de la clase Ingrediente
        public double ingPrecio { get; set; } 
        public String ingFechaIn { get; set; }
        public String ingFechaFi { get; set; }

        // Metodo constructor
        public Precio(double ingPrecio, String ingFechaIn, String ingFechaFi)
        {
            this.ingPrecio = ingPrecio;
            this.ingFechaIn = ingFechaIn;
            this.ingFechaFi = ingFechaFi;
        }

    }
}