using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAprending._02aplication
{
    internal class Curso
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public int NumPlazas { get; set; }
        public string Lugar { get; set; }
        public int Precio { get; set; }

        public Curso() { } 

        public Curso(int codigo, string titulo, int numPlazas, string lugar, int precio)
        {
            Codigo = codigo;
            Titulo = titulo;
            NumPlazas = numPlazas;
            Lugar = lugar;
            Precio = precio;
        }

        public override string ToString()
        {
            return Codigo + ":" + Titulo + ";"+ NumPlazas + ";" + Lugar + ";"+ Precio ;
        }
    }
}
