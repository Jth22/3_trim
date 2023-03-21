using System;
namespace Ejercicio_libro
{
    public class Articulo : Documento
    {
        public string Procedencia { get; set; }
        public Articulo(string autor, string titulo, string ubicacion, string procedencia)
            : base(autor, titulo, ubicacion)
        {
            this.Procedencia = procedencia;
            Console.WriteLine("Creando artículo...");
        }
       
        public override string ToString()
        {
            return base.ToString() + " - " + Procedencia;
        }
        public override bool Contiene(string texto)
        {
            bool resultado;
            if (Autor.ToLower().Contains(texto) || Titulo.ToLower().Contains(texto) || Procedencia.ToLower().Contains(texto))
                resultado = true;
            else
                resultado = false;
            return resultado;
        }
    }
}
