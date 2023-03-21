
namespace Ej0803_6
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
                dato= Console.ReadLine();
                if (dato != "")
                    fichero.WriteLine(dato);
            } while (dato != "");
            fichero.Close();

            StreamReader ficheroALeer;
            string linea, nombreFichero, cadena = "" ;
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
                while(linea != null)
                {
                    if (linea.Contains(cadena))
                    {
                        Console.WriteLine(cont + " "+ linea);
                        encontrado= true;
                    }
                    linea = ficheroALeer.ReadLine() ;
                    cont++;
                }
            }
            ficheroALeer.Close();
            if (!encontrado)
                Console.WriteLine("texto no encontrado");
        }
    }
}