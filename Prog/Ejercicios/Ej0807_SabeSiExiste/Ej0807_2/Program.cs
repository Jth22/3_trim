/*(8.7.2) Mejora el ejemplo 08_07a para que no use "while (true)" y "break", sino una variable booleana de control.*/

namespace Ej0807_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter ficheroPrueba = new StreamWriter("Prueba.txt");
            for (int i = 0; i < 5; i++)
            {
                ficheroPrueba.WriteLine(i);
            }
            ficheroPrueba.Close();
            StreamReader fichero; 
            string nombre;
            bool ok = false;
            while (!ok) // Interrumpimos desde dentro con "break" (no recomendable)
            {
                Console.Write( "Nombre del fichero (\"fin\" para terminar)? "); 
                nombre = Console.ReadLine(); 
                if (nombre != "fin" && File.Exists(nombre))
                { 
                    fichero = File.OpenText( nombre ); 
                    Console.WriteLine("Su primera linea es: {0}", fichero.ReadLine() );
                    fichero.Close(); 
                } 
                
                if (nombre != "fin" && !File.Exists(nombre))
                    Console.WriteLine( "No existe!" );
                
                if (nombre == "fin")
                    ok = true;
            }
        }
    }
}