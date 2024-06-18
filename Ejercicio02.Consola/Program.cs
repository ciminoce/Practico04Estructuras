using Ejercicio02.Entidades;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el lado y validar
            int lado;
            bool esNumeroValido=false;
            do
            {
                Console.Write("Ingrese el valor del lado: ");
                string? entrada = Console.ReadLine();
                esNumeroValido = int.TryParse(entrada, out lado);

                if (!esNumeroValido)
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                }
            } while (!esNumeroValido);
            Cuadrado cuadrado=new Cuadrado(lado);
            Console.WriteLine(cuadrado.ToString());
        }
    }
}
