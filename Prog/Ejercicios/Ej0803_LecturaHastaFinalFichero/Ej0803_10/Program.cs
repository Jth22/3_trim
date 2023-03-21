namespace Ej0803_10
{
    internal class Program
    {
        static List<string> list = new List<string>();
        static void Main(string[] args)
        {
            
            StreamWriter fichero = new StreamWriter("texto.txt");
            string dato;
            do
            {
                Console.WriteLine("Cadena?");
                dato = Console.ReadLine();
                if (dato != "")
                    fichero.WriteLine(dato);
            } while (dato != "");
            fichero.Close();

            StreamReader fichLeer = File.OpenText("texto.txt");
            string linea = fichLeer.ReadLine();
            while (linea != null)
            {
                list.Add(linea);
                linea = fichLeer.ReadLine();
            }
            string textoAbuscar;
            int cont = 1;
            do
            {
                Console.WriteLine("Texto a buscar?");
                textoAbuscar = Console.ReadLine();
                if (textoAbuscar != "")
                    Filtrar(textoAbuscar).ForEach(t => Console.WriteLine(t));


            } while (textoAbuscar != "");
        }
        private static List<string> Filtrar(string patron)
        {
            List<string> filtrar = new List<string>();
            if (patron == "")
                return filtrar = list;
            else
                return filtrar = list.FindAll(p => p.Contains(patron));
        }
    }
}