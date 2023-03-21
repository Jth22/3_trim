namespace Ej0802_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            

            using (StreamWriter ficheroWriter = new StreamWriter("registroDeUsuario.txt"))
            {
                do
                {
                    Console.WriteLine("Dime una frase: ");
                    frase = Console.ReadLine();
                    if (frase != "fin")
                    {
                        ficheroWriter.WriteLine(frase);
                    }
                } while (frase != "fin");
            }
            StreamReader ficheroLeer = new StreamReader("registroDeUsuario.txt");
            Console.WriteLine(ficheroLeer.ReadLine());
            Console.WriteLine(ficheroLeer.ReadLine());
            Console.WriteLine(ficheroLeer.ReadLine());
            ficheroLeer.Close();
        }
    }
}