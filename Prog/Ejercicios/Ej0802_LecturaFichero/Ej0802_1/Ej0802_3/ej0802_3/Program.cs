namespace ej0802_3
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
            using (StreamReader ficheroLeer = new StreamReader("registroDeUsuario.txt"))
            {
                Console.WriteLine(ficheroLeer.ReadLine());
                Console.WriteLine(ficheroLeer.ReadLine());
                Console.WriteLine(ficheroLeer.ReadLine());
            }
        }
    }
}