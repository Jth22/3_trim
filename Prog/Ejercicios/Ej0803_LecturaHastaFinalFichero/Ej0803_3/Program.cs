namespace Ej0803_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos un fichero de prueba     
            StreamWriter ficheroWriter = new StreamWriter("archivo.txt");
            for (int i = 0; i < 50; i++)
            {
                ficheroWriter.WriteLine("Línea " + (i + 1));
            }
            ficheroWriter.Close();
            //ejercicio
            string nomFichero, linea = "" ;
            Console.WriteLine("Dime el nombre del fichero: ");
            nomFichero = Console.ReadLine();
            StreamReader fichero;
            fichero= new StreamReader(nomFichero);

            do
            {
                for (int i = 0; i < 24; i++)
                {
                    linea = fichero.ReadLine();
                    if (linea != null)
                        Console.WriteLine(linea);
                }
                Console.WriteLine();
                Console.WriteLine("Pulsa \"Intro\" para seguir");
                Console.ReadLine();
            } while (linea != null);
            fichero.Close();
        }
    }
}