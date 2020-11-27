using System;

namespace ProyectoComodato
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente ingrediente1 = new Ingrediente(001,"Leche","Liquido blanco","ml");
            ingrediente1.ReporteRangoPrecios();
        }
    }
}
