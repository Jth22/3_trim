/* 8.8.3) Un programa que pida al usuario repetidamente pares de números y la operación a realizar
 * con ellos (+, -, *, /) y guarde en un fichero "calculadora.txt" el resultado de dichos cálculos
 * (con la forma "15 * 6 = 90"). Debe controlar los posibles errores, como que los datos no sean
 * numéricos, la división entre cero, o que el fichero no se haya podido crear.
 */
namespace Ej0808_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dato1, operacion;
            int num1, num2, resultado = 0;

            do
            {
                Console.WriteLine("Dime un par de datos. Escribe \"fin\" para salir");
                Console.WriteLine("Número 1: ");
                dato1= Console.ReadLine();
                if (dato1 != "fin")
                {
                    num1 = Convert.ToInt32(dato1);
                    Console.WriteLine("Número: 2 ");
                    while (!Int32.TryParse(Console.ReadLine(), out num2))
                        Console.WriteLine("Formato erróneo, prueba otra vez");
                    Console.WriteLine("Qué operación quieres realizar: Suma(1), Resta(2), Prodcuto(3), División(4)");
                    operacion = Console.ReadLine();
                    try
                    {
                        using (StreamWriter fichero = new StreamWriter("calculadora.txt", true))
                        {
                            switch (operacion)
                            {
                                case "+":
                                    resultado = num1 + num2;
                                    break;
                                case "-":
                                    resultado = num1 - num2;
                                    break;
                                case "*":
                                    resultado = num1 * num2;
                                    break;
                                case "/":
                                    resultado = num1 / num2;
                                    break;
                                default:
                                    Console.WriteLine("La operación no es correcta");
                                    break;
                            }
                            fichero.WriteLine(num1 + "  " + operacion + " " + num2 + " = " + resultado);
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            } while (dato1 != "fin");
        }
    }
}