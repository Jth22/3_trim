namespace Ej0805_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime un nombre para el fichero");
            string nomFichero = Console.ReadLine();

            StreamWriter fich = new StreamWriter(nomFichero);
            for (int i = 0; i < 20; i++)
            {
                fich.WriteLine("Línea"+ (i+1));
            }
            fich.Close();

            string texto = File.ReadAllText(nomFichero);


        }
    }
}