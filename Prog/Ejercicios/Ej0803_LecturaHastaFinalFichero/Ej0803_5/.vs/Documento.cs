using System;
namespace Ejercicio_libro
{
    public class Documento
    {
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Ubicacion { get; set; }
        public Documento(string autor, string titulo, string ubicacion)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.Ubicacion = ubicacion;
            Console.WriteLine("Creando documento...");
        }
        
        public override string ToString()
        {
            return Autor + " - " + Titulo + " - " + Ubicacion;
        }
        public virtual bool Contiene(string texto)
        {
            bool resultado;
            if (Autor.ToLower().Contains(texto) || Titulo.ToLower().Contains(texto))
                resultado = true;
            else
                resultado = false;
            return resultado;
        }
    }
}
