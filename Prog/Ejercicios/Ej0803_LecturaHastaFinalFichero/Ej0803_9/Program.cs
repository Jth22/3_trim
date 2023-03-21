using Microsoft.VisualBasic;

namespace Ej0803_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            StreamWriter fich = new StreamWriter("Texto.txt");
            string cadena;
            do
            {
                Console.WriteLine("Cadena");
                cadena = Console.ReadLine();
                if (cadena != "")
                    fich.WriteLine(cadena);
            } while (cadena != "");
            fich.Close();

            StreamReader fichLista = File.OpenText("Texto.txt");
            string linea = fichLista.ReadLine();

            while (linea != null)
            {
                list.Add(linea);
                linea = fichLista.ReadLine();
            }
                
            int fila;
            do
            {
                Console.WriteLine("Qué lìnea quieres ver? ");
                while (!Int32.TryParse(Console.ReadLine(), out fila)) Console.WriteLine("repite respuesta, formato erróneo");
                if (fila != -1 && fila < list.Count)
                    Console.WriteLine(list[fila - 1]);
                else
                    Console.WriteLine("Fuera de rango");
            }while(fila != -1);
            
        }
    }
}