using System.Globalization;

namespace Ej0806_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string > stack = new Stack<string>();
            StreamWriter fichero = new StreamWriter("texto.txt");
            string dato;

            do
            {
                Console.WriteLine("Dato? ");
                dato= Console.ReadLine();
                if (dato != "")
                    fichero.WriteLine(dato);
            } while (dato != "");
            fichero.Close();

            Console.WriteLine("nombre fichero: ");
            string cadena = Console.ReadLine();
            StreamReader fichALeer = File.OpenText(cadena);

            string linea = fichALeer.ReadLine();
            while(linea != null)
            {
                stack.Push(linea);
                linea = fichALeer.ReadLine();
            }
            fichALeer.Close();

            while(stack.Count > 0)
            {
                string frase = stack.Pop();
                Console.WriteLine(frase);
            }
        }
    }
}