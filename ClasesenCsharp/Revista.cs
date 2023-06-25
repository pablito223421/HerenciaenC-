using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesenCsharp
{
       public class Revista : Publicacion
    {
        public string? Periodista { get; set; }

        public Revista(string? periodista, string nombre, int cantidadPaginas, decimal precio)
            : base(nombre, precio, cantidadPaginas)
        {
            Periodista = periodista;
        }

        public override string getInscripcion() => $" Nombre de la revista: {Nombre} , su autor es: {Periodista}, numero de páginas: {NumeroPaginas}";
    }
}
