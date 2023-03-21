/*(8.6.1) Crea un programa que pida al usuario pares de números enteros y escriba su suma (con el formato "20 + 3 = 23")
 * en pantalla y en un fichero llamado "sumas.txt", que se encontrará en un subdirectorio llamado "resultados". 
 * Cada vez que se ejecute el programa, deberá añadir los nuevos resultados a continuación de 
 * los resultados de las ejecuciones anteriores.
 * */
namespace Ej0806_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numUsu1, numUsu2, suma;
            string ficheroResultado = @".\resultados\sumas.txt";
            do
            {
                Console.WriteLine("Dime dos números: (Pulsa \"0\" para salir)");
                Console.Write("Num1 ?");
                while (!Int32.TryParse(Console.ReadLine(), out numUsu1)) Console.WriteLine("Formato erróneo, prueba otra vez");
                Console.WriteLine("Num2 ?");
                while (!Int32.TryParse(Console.ReadLine(), out numUsu2)) Console.WriteLine("Formato erróneo, prueba otra vez");
                
                if (numUsu1 != 0 && numUsu2 != 0)
                {
                    suma = numUsu1 + numUsu2;
                    using (StreamWriter fichero = new StreamWriter(ficheroResultado, true))
                    {
                        fichero.WriteLine(numUsu1 + " + " + numUsu2 + " = " + suma);
                    }
                }
            } while (numUsu1 != 0 && numUsu2 != 0);
        }
    }
}