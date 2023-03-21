using System.Collections.Immutable;

namespace Ej0805_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero = new StreamWriter("textos.txt");
            for(int i = 0; i < 20; i++)
            {
                fichero.WriteLine("Línea"+ (i+1));
            }
            fichero.Close();

            string[] cadenas = File.ReadAllLines("textos.tx");

            Array.Sort(cadenas);

            File.WriteAllLines("textos2.txt", cadenas);
        }
    }
}