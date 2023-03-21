using System;
using System.IO;

namespace Ejercicio_8_4_1
{
    class Program
    {
        // (8.4.1) Un programa que pida al usuario que teclee frases, y
        // las almacene en el fichero "log.txt", que puede existir anteriormente
        // (y que no deberá borrarse, sino añadir al final de su contenido).
        // Cada sesión acabará cuando el usuario pulse Intro sin teclear nada.
        static void Main()
        {
            StreamWriter fichero;
            string frases;
            fichero = File.AppendText("log.txt");
            do
            {
                Console.Write("Escribe frases: ");
                frases = Console.ReadLine();
                if (frases != "")
                    fichero.WriteLine(frases);
            } while (frases != "");
            fichero.Close();
        }
    }
}
