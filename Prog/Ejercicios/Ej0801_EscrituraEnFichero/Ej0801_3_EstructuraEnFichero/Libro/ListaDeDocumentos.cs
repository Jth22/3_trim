using System;
namespace Ejercicio_libro
{
    public class ListaDeDocumentos
    {
        public int Cantidad { get; set; }
        public Documento[] Documentos { get; set; }
        public ListaDeDocumentos()
        {
            this.Cantidad = 0;
            this.Documentos = new Documento[1000];
        }
        public bool AnyadirModificarDocumentos(string opcionDoc, int cant, bool anyadir)
        {
            int posiciones = Cantidad; // Esto es una copia de cantidad
            Cantidad = cant; // Esto es para que cantiad sea igual a cantidad si
                             // se añade un doc o sea igual a la opcion
                             // de modificar si se modifica
            Console.Write("Autor: ");
            string autor = Console.ReadLine();
            Console.Write("Titulo: ");
            string titulo = Console.ReadLine();
            Console.Write("Ubicación: ");
            string ubicacion = Console.ReadLine();
            bool resultado = true;
            if (opcionDoc == "1")
            {
                Documento document = new Documento(autor, titulo, ubicacion);
                Documentos[Cantidad] = document;
                resultado = true;
            }
            else if (opcionDoc == "2")
            {
                Console.Write("Procedencia: ");
                string procedencia = Console.ReadLine();
                Articulo art = new Articulo(autor, titulo, ubicacion, procedencia);
                Documentos[Cantidad] = art;
                resultado = true;
            }
            else if (opcionDoc == "3")
            {
                int paginas;
                do
                {
                    Console.Write("Nº páginas: ");
                } while (!Int32.TryParse(Console.ReadLine(), out paginas));
                Libro book = new Libro(autor, titulo, ubicacion, paginas);
                Documentos[Cantidad] = book;
                resultado = true;
            }
            else
                Console.WriteLine("Escribe una opción válida.");
            Cantidad = posiciones;
            if (anyadir) // boleano para ver si estamos añadiendo un doc o modificando
                Cantidad++;
            return resultado;
        }
        public void MostrarDatos()
        {
            for (int i = 0; i < this.Cantidad; i++)
            {
                string tipo = this.Documentos[i].GetType().Name;
                Console.WriteLine(i + 1 + ". " + tipo + ": " + this.Documentos[i].ToString());
            }
        }
        public string Buscar(string textoBuscar)
        {
            string resultado = "";
            for (int i = 0; i < this.Cantidad; i++)
            {
                if (Documentos[i].Contiene(textoBuscar))
                {
                    string tipo = this.Documentos[i].GetType().Name;
                    resultado += i + 1 + ". " + tipo + ": " + this.Documentos[i].ToString() + "\n";
                }
            }
            return resultado;
        }
        public void Ordenar(string opcionOrdenar)
        {
            if (opcionOrdenar == "1")
            {
                int i, j;
                for (i = 0; i < this.Cantidad - 1; i++)
                {
                    for (j = i + 1; j < this.Cantidad; j++)
                    {
                        if (this.Documentos[i].Titulo.ToLower().CompareTo(this.Documentos[j].Titulo.ToLower()) > 0)
                        {
                            Documento aux = this.Documentos[i];
                            this.Documentos[i] = this.Documentos[j];
                            this.Documentos[j] = aux;
                        }
                    }
                }
            }
            else if (opcionOrdenar == "2")
            {
                int i, j;
                for (i = 0; i < this.Cantidad - 1; i++)
                {
                    for (j = i + 1; j < this.Cantidad; j++)
                    {
                        if (this.Documentos[i].Autor.ToLower().CompareTo(this.Documentos[j].Autor.ToLower()) > 0)
                        {
                            Documento aux = this.Documentos[i];
                            this.Documentos[i] = this.Documentos[j];
                            this.Documentos[j] = aux;
                        }
                    }
                }
            }
        }
        public bool BorrarDocumentos(int opcion)
        {
            for (int i = opcion - 1; i < this.Cantidad; i++)
            {
                Documentos[i] = Documentos[i + 1];
            }
            Cantidad--;
            return true;
        }
        public bool ModificarDocumentos(int opModificar)
        {
            bool anyadir = false; // Boleano para que añadir sea false y no sume cantidad +1.
            string opDoc = Documentos[opModificar - 1].GetType().Name;
            if (opDoc == "Documento")
                opDoc = "1";
            else if (opDoc == "Articulo")
                opDoc = "2";
            else if (opDoc == "Libro")
                opDoc = "3";
            AnyadirModificarDocumentos(opDoc, opModificar - 1, anyadir);
            return true;
        }
    }
}
