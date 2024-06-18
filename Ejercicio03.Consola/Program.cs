using Ejercicio03.Entidades;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Circ!");
            int radio;
            bool esNoValido=true;
            do
            {
                Console.Write("Ingrese la medida del radio:");
                if (!int.TryParse(Console.ReadLine(), out radio)|| 
                    radio<=0)
                {
                    Console.WriteLine("Radio no válido...Favor reintentar!!!");
                }
                else
                {
                    esNoValido= false;
                }

            } while (esNoValido);
            Circunferencia circunferencia = new Circunferencia(radio);
            Console.WriteLine(circunferencia.ToString());
        }
    }
}
