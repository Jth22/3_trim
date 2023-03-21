/* 8.10.1) Abre un fichero con extensión EXE (cuyo nombre introducirá el usuario) y 
 * comprueba si realmente se trata de un ejecutable, mirando si los dos primeros bytes del fichero son un 77
 * (que corresponde a una letra "M", según el estándar que marca el código ASCII) y un 90 (una letra "Z"), respectivamente.
 */
namespace Ej0810_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomUsuFich;
            bool ok = false;
            byte dato1, dato2;

            Console.WriteLine("Nombre fcihero:");
            nomUsuFich = Console.ReadLine();

            if (File.Exists(nomUsuFich))
            {
                try
                {
                    using (FileStream fichero = new FileStream(nomUsuFich, FileMode.Open))
                    {
                        dato1 = (byte)fichero.ReadByte();
                        dato2 = (byte)fichero.ReadByte();
                        if (dato1 == 77 && dato2 == 90)
                        {
                            ok = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                if (ok)
                    Console.WriteLine("Se trata de un fichero ejecutable");
                else
                    Console.WriteLine("No es un fichero ejecutable");
            }
            else
                Console.WriteLine("El fichero no existe");
            
        }
    }
}