namespace Ej0802_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "";
            StreamReader ficheroLeer;

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
            ficheroLeer = File.OpenText("registroDeUsuario.txt");
            Console.WriteLine(ficheroLeer.ReadLine());
            Console.WriteLine(ficheroLeer.ReadLine());
            Console.WriteLine(ficheroLeer.ReadLine());
            ficheroLeer.Close();
        }
    }
}