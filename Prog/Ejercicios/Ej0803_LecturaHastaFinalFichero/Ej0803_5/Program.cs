using System;

namespace Ejercicio_libro
{
    class Principal
    {
        public static void Main(string[] args)
        {
            ListaDeDocumentos listDoc = new ListaDeDocumentos();
            string opcion;
            Console.WriteLine("Documentos guardados en fichero: ");
            StreamReader ficheroLeer;
            string linea;
            ficheroLeer = File.OpenText("libro.txt");
            linea = ficheroLeer.ReadLine();
            while (linea != null)
            {
                Console.WriteLine(linea); 
                linea = ficheroLeer.ReadLine();
            }
            ficheroLeer.Close();

            Console.WriteLine();

            do
            {
                Console.WriteLine("Elige una opcion:");
                Console.WriteLine("0 - Salir");
                Console.WriteLine("1 - Añadir un documento");
                Console.WriteLine("2 - Ver los documentos existentes");
                Console.WriteLine("3 - Buscar un documento");
                Console.WriteLine("4 - Borrar un documento");
                Console.WriteLine("5 - Modificar un documento");
                Console.WriteLine("6 - Ordenar los documentos");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "0":
                        StreamWriter fichero;
                        fichero = File.AppendText("libro.txt");
                        for (int i = 0; i < listDoc.Cantidad; i++)
                        {
                            if (listDoc.Documentos[i] is Libro)
                                fichero.WriteLine(((Libro)listDoc.Documentos[i]).ToString());
                            else if (listDoc.Documentos[i] is Articulo)
                                fichero.WriteLine(((Articulo)listDoc.Documentos[i]).ToString());
                            else
                                fichero.WriteLine(((Documento)listDoc.Documentos[i]).ToString());
                        }
                        fichero.Close();
                        Console.WriteLine("Saliendo...");
                        break;
                    case "1": // Añadir documentos
                        string opcionDoc;
                        bool anyadir = true; // Boleano para saber si estamos
                                             // añadiendo un doc o estamos modificando
                        do
                        {
                            Console.WriteLine("¿Qué tipo de documento quieres añadir?: ");
                            Console.WriteLine("1 - Documento");
                            Console.WriteLine("2 - Artículo");
                            Console.WriteLine("3 - Libro");
                            opcionDoc = Console.ReadLine();
                        } while (opcionDoc != "1" && opcionDoc != "2" && opcionDoc != "3");
                        string documento = "";
                        if (opcionDoc == "1")
                            documento = "Documento";
                        else if (opcionDoc == "2")
                            documento = "Articulo";
                        else if (opcionDoc == "3")
                            documento = "Libro";
                        if (listDoc.Cantidad > 1000)
                            Console.WriteLine("No se pueden añadir mas datos. Borre uno antes de añadir.");
                        else
                        {
                            if (listDoc.AnyadirModificarDocumentos(opcionDoc, listDoc.Cantidad, anyadir))
                            {
                                if (anyadir)
                                    Console.WriteLine(documento + " añadido con exito");
                                else
                                    Console.WriteLine(documento + " modificado con exito");
                            }
                        }
                        break;
                    case "2": // Mostrar datos
                        if (listDoc.Cantidad < 1)
                            Console.WriteLine("No hay datos para mostrar");
                        else
                            listDoc.MostrarDatos();
                        break;
                    case "3": // Buscar un cierto dato
                        Console.Write("Escribe el texto a buscar:");
                        string textoBuscar = Console.ReadLine().ToLower();
                        Console.WriteLine(listDoc.Buscar(textoBuscar));
                        break;
                    case "4": // Borrar un cierto dato
                        int opcionBorrar;
                        listDoc.MostrarDatos();
                        do
                        {
                            Console.Write("¿Qué documento quieres borrar?: ");
                        } while (!Int32.TryParse(Console.ReadLine(), out opcionBorrar));
                        if (listDoc.Cantidad < 1 || opcionBorrar > listDoc.Cantidad)
                        {
                            Console.WriteLine("No se puede eliminar porque no " +
                                "hay datos suficientes o el dato elegido no existe");
                        }
                        else
                        {
                            if (listDoc.BorrarDocumentos(opcionBorrar))
                                Console.WriteLine("Documento borrado con exito");
                        }
                        break;
                    case "5": // Modificar
                        int opcionModificar;
                        listDoc.MostrarDatos();
                        do
                        {
                            Console.Write("¿Qué documento quieres modificar?: ");
                        } while (!(Int32.TryParse(Console.ReadLine(), out opcionModificar)) && opcionModificar < listDoc.Cantidad);
                        if (listDoc.Cantidad < 1 || opcionModificar > listDoc.Cantidad)
                        {
                            Console.WriteLine("No se puede modificar porque no " +
                                "hay datos suficientes o el dato elegido no existe");
                        }
                        else
                        {
                            if (listDoc.ModificarDocumentos(opcionModificar))
                                Console.WriteLine("Documento modificado con exito");
                        }
                        break;
                    case "6": // Ordenar
                        string opcionOrdenar;
                        do
                        {
                            Console.WriteLine("¿Como quieres ordenar el array?");
                            Console.WriteLine("1 - Por titulo");
                            Console.WriteLine("2 - Por autor");
                            opcionOrdenar = Console.ReadLine();
                            if (opcionOrdenar != "1" && opcionOrdenar != "2")
                                Console.WriteLine("Escribe una opción válida");
                        } while (opcionOrdenar != "1" && opcionOrdenar != "2");
                        if (listDoc.Cantidad <= 1)
                            Console.WriteLine("No se puede ordenar porque no hay datos suficientes");
                        else
                            listDoc.Ordenar(opcionOrdenar);
                        break;
                    default: break;
                }
                Console.WriteLine();
                Console.WriteLine("Pulsa \"Intro\" para seguir");
                Console.ReadLine();
                Console.Clear();
            } while (opcion != "0");
        }
    }
}
