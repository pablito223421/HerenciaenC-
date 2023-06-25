using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesenCsharp
{
    public class Libro:Publicacion
    {
        

        private string autor;

        public string Autor
        {
            get => autor;
            set => autor = value;
        }

        public  Libro (string nombre, string autor, int cantidadPaginas, decimal precio) : base(nombre, precio, cantidadPaginas)
        {
            this.autor = autor;
        }


        public override string getInscripcion() => $"Título del libro: {Nombre} ,escrito por {Autor}, número de paginas:{NumeroPaginas}";
    }
}