using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoComodato
{
    public class Componente
    {
        // Atributos y métodos get y set de la clase Ingrediente
        public int comId { get; set; }
        public String comNombre { get; set; }

        // Metodo constructor
        public Componente(int comId, String comNombre)
        {
            this.comId = comId;
            this.comNombre = comNombre;
        }
    }
}