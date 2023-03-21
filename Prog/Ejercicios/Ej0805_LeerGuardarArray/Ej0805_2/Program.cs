/*(8.5.2) Crea una nueva versión del ejercicio 8.3.7: un programa que pida al usuario
 * el nombre de un fichero de texto y muestre en orden inverso las líneas que lo forman, 
 * tras leer todo su contenido a un array.
 * */
namespace Ej0805_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("texto.txt");
            string dato;
            do
            {
                Console.WriteLine("Dato? ");
                dato = Console.ReadLine();
                if (dato != "")
                    fichero.WriteLine(dato);
            } while (dato != "");
            fichero.Close();

            Console.WriteLine("nombre fichero: ");
            string cadena = Console.ReadLine();
            string[] cadenas = File.ReadAllLines(cadena);

            for (int i = cadenas.Length; i > 0; i--)
                Console.WriteLine(cadenas[i]);
        }
    }
}