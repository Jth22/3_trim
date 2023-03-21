using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio_8_3_11
{
    class Program
    {
        //(8.3.11) Crea un programa que lea el contenido de un fichero de texto,
        //lo almacene línea por línea en un ArrayList, lo ordene y lo muestre ordenado en pantalla.
        static void Main(string[] args)
        {
            List<string> miLista = new List<string>();
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("lista.txt");
            linea = fichero.ReadLine();

            while (linea != null)
            {
                miLista.Add(linea);
                linea = fichero.ReadLine();
            }

            fichero.Close();

            miLista.Sort(); // Ordenar la lista de strings

            foreach (string frase in miLista)
                Console.WriteLine(frase);
        }
    }
}
