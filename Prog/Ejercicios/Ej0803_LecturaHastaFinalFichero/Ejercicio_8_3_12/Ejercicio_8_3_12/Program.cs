using System;
using System.Collections.Generic;
using System.IO;

namespace Ejercicio_8_3_12
{
    class Program
    {
        // (8.3.12) Crea un programa que lea el contenido de un fichero de texto,
        // lo almacene línea por línea en un ArrayList, lo ordene y vuelque a un
        // nuevo fichero las líneas que no estén duplicadas.
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

            StreamWriter nuevoFichero;
            nuevoFichero = File.CreateText("nuevoFichero.txt");

            int cantidad = miLista.Count;
            for (int i = 0; i < cantidad; i++)
                for (int j = i+1; j < cantidad-1; j++)
                    if (miLista[i] == miLista[j])
                        miLista.RemoveAt(j);

            foreach (string frase in miLista)
                nuevoFichero.WriteLine(frase);

            nuevoFichero.Close();
        }
    }
}
