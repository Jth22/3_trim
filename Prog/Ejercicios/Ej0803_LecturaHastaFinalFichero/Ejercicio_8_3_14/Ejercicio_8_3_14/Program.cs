using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio_8_3_14
{
    class Program
    {
        // (8.3.14) Crea un programa que lea todo el contenido de un fichero,
		// lo guarde en una lista de strings y luego lo muestre en orden inverso
        // (de la última línea a la primera).
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

            for (int i = miLista.Count-1; i >= 0; i--)
                Console.WriteLine(miLista[i]);
        }
    }
}
