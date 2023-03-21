using System;
namespace Ejercicio_libro
{
    public class Libro : Documento
    {
        public int Paginas { get; set; }
        public Libro(string autor, string titulo, string ubicacion, int paginas)
            : base(autor, titulo, ubicacion)
        {
            this.Paginas = paginas;
            Console.WriteLine("Creando libro...");
        }
        public override string ToString()
        {
            return base.ToString() + " - " + Paginas;
        }
    }
}
