/*(8.5.1) Crea una nueva versión del ejercicio 8.3.6: un programa que pida al usuario
 * el nombre de un fichero de texto y una frase a buscar, y que muestre en pantalla todas
 * las líneas de ese fichero que contengan esa frase. Cada frase se debe preceder del número
 * de línea (la primera línea del fichero será la 1, la segunda será la 2, y así sucesivamente). 
 * Al final de la lectura se debe avisar, en caso de que no se haya encontrado el texto buscado.
 * Debes leer todos los datos a un array.
 * */
namespace Ej0805_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("texto.txt");
            string dato;
            do
            {
                Console.WriteLine("Frase? ");
                dato = Console.ReadLine();
                if (dato != "")
                    fichero.WriteLine(dato);
            } while (dato != "");
            fichero.Close();

            StreamReader ficheroALeer;
            string linea, nombreFichero, cadena = "";
            int cont = 1;
            bool encontrado = false;


            Console.WriteLine("Dime un fichero");
            nombreFichero = Console.ReadLine();
            ficheroALeer = File.OpenText(nombreFichero);

            if (!File.Exists(nombreFichero))
                Console.WriteLine("Este fichero no existe");
            else
            {
                Console.WriteLine("Dime una cadena a buscar: ");
                cadena = Console.ReadLine();

                linea = ficheroALeer.ReadLine();
                while (linea != null)
                {
                    if (linea.Contains(cadena))
                    {
                        Console.WriteLine(cont + " " + linea);
                        encontrado = true;
                    }
                    linea = ficheroALeer.ReadLine();
                    cont++;
                }
            }
            ficheroALeer.Close();
            if (!encontrado)
                Console.WriteLine("texto no encontrado");

            string[] cadenas = File.ReadAllLines(nombreFichero);
            foreach(string s in cadenas)
                Console.WriteLine(s);
        }
    }
}