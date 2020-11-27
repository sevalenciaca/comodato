using System;

namespace ProyectoComodato
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente ingrediente1 = new Ingrediente(1,"Leche","Liquido blanco","ml");
            Precio precio1 = new Precio(10000,"Marzo","Abril");
            Categoria categoria1 = new Categoria();
            Console.WriteLine("El ingrediente "+ingrediente1.ingNombre+" cuesta: "+"$ "+precio1.ingPrecio);
        }
    }
}
