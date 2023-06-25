using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesenCsharp
{
   public class Publicacion
    {
        public string? Nombre { get; set; }
        public decimal Precio { get; set; }

        public int NumeroPaginas { get; set; }

        public Publicacion(string nombre, decimal precio, int numeroPaginas)
        {
            Nombre = nombre;
            Precio = precio;
            NumeroPaginas = numeroPaginas;
        }

        public virtual string getInscripcion() => $"{Nombre}precio del  libro:{Precio}";



    }
}
