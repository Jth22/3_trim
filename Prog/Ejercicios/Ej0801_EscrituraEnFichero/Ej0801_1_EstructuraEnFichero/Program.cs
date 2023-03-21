namespace Ej_8_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            StreamWriter fichero = new StreamWriter("registroDeUsuario");
            do
            {
                Console.WriteLine("Dime una cadena? ");
                cadena = Console.ReadLine();
                if (cadena != "fin")
                    fichero.WriteLine(cadena);
            } while (cadena !="fin");
            fichero.Close();
        }
    }
}