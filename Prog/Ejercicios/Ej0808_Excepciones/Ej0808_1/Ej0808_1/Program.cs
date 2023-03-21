/*(8.8.1) Un programa que pida al usuario el nombre de un fichero de origen y el de un fichero de destino,
 * y que vuelque al segundo fichero el contenido del primero, convertido a mayúsculas.
 * Se debe controlar los posibles errores, como que el fichero de origen no exista, o que el
 * fichero de destino no se pueda crear.
 */

namespace Ej0808_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Dime el nombre del fichero origen: ");
            string nombreOrigen = Console.ReadLine();
            Console.WriteLine("Dime el nombre del fichero destino: ");
            string nombreDestino = Console.ReadLine();

            try
            {
                string[] contenido = File.ReadAllLines(nombreOrigen);
                for (int i = 0; i < contenido.Length; i++)
                    contenido[i] = contenido[i].ToUpper();
                File.WriteAllLines(nombreDestino, contenido);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("El nombre es muy largo");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El archivo de origen no existe");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
