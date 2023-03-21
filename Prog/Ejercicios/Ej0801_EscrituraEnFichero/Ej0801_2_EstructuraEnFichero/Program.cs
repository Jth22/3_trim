namespace Ej0802_EstructuraEnFichero
{
    internal class Program
    {
        struct tipoFicha
        {
            public string nombreFich; // Nombre del fichero 
            public long tamanyo; // El tamaño en KB 
        }
        static void Main(string[] args)
        {
            /*(5.2.3) Descompón en funciones la base de datos de ficheros
             * (ejemplo 04_06a), de modo que el "Main" sea breve y más legible
             * (Pista: las variables que se compartan entre varias funciones
             * deberán estar fuera de todas ellas, y deberán estar precedidas
             * por la palabra "static").*/
            int numeroFichas = 0; // Número de fichas que ya tenemos
            string textoBuscar = " "; // Para cuando preguntemos al usuario
            long tamanyoBuscar = 0; // Para buscar por tamaño
            tipoFicha[] fichas = new tipoFicha[1000];

            int opcion; // La opcion del menú que elija el usuario
            do
            { // Menu principal, repetitivo 
                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine("1.- Añadir datos de un nuevo fichero");
                Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
                Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
                Console.WriteLine("4.- Ver datos de un fichero");
                Console.WriteLine("5.- Guardar en fichero y salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                // Hacemos una cosa u otra según la opción escogida
                switch (opcion)
                {
                    case 1: numeroFichas = Anyadir(fichas, numeroFichas); break; // Añadir un dato nuevo
                    case 2: MostrarTodos(fichas, numeroFichas); break;// Mostrar todos
                    case 3: MostrarTamanyo(fichas, numeroFichas, tamanyoBuscar); break;// Mostrar según el tamaño
                    case 4: Ver(fichas, numeroFichas, textoBuscar); break; // Ver todos los datos (pocos) de un fichero
                    case 5: GuardarSalir(fichas); // Salir: avisamos de que salimos */ 
                        Console.WriteLine("Fin del programa");
                        break;
                    default: // Otra opcion: no válida 
                        Console.WriteLine("Opción desconocida!");
                        break;
                }
            } while (opcion != 5); // Si la opcion es 5, terminamos
        }
        static int Anyadir(tipoFicha[] fichas, int numeroFichas)
        {
            if (numeroFichas < 1000)
            { // Si queda hueco
                Console.WriteLine("Introduce el nombre del fichero: ");
                fichas[numeroFichas].nombreFich = Console.ReadLine();
                Console.WriteLine("Introduce el tamaño en KB: ");
                fichas[numeroFichas].tamanyo = Convert.ToInt32(Console.ReadLine());
                // Y ya tenemos una ficha más 
                numeroFichas++;
            }
            else // Si no hay hueco para más fichas, avisamos 
                Console.WriteLine("Máximo de fichas alcanzado (1000)!");

            return numeroFichas;
        }
        static void MostrarTodos(tipoFicha[] fichas, int numeroFichas)
        {
            for (int i = 0; i < numeroFichas; i++)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
                    , fichas[i].nombreFich, fichas[i].tamanyo);
        }
        static void MostrarTamanyo(tipoFicha[] fichas, int numeroFichas, long tamanyoBuscar)
        {
            Console.WriteLine("¿A partir de que tamaño quieres ver?");
            tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < numeroFichas; i++)
                if (fichas[i].tamanyo >= tamanyoBuscar)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
                        , fichas[i].nombreFich, fichas[i].tamanyo);
        }
        static void Ver(tipoFicha[] fichas, int numeroFichas, string textoBuscar)
        {
            Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
            textoBuscar = Console.ReadLine();
            for (int i = 0; i < numeroFichas; i++)
                if (fichas[i].nombreFich == textoBuscar)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB"
                    , fichas[i].nombreFich, fichas[i].tamanyo);
        }

        static void GuardarSalir(tipoFicha[] fichas)
        {
            StreamWriter fichero = new StreamWriter("Datos");
            for(int i = 0; i < fichas.Length; i++)
            {
                fichero.WriteLine("Nombre de la ficha: "+ fichas[i].nombreFich + ", tamaño: "+ fichas[i].tamanyo);
            }
            fichero.Close();
        }
    }
}