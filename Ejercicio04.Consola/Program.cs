using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectángulos!!!");
            int ladoMayor;
            bool esNoValido = true;
            do
            {
                Console.Write("Ingrese la medida del lado mayor:");
                if (!int.TryParse(Console.ReadLine(), out ladoMayor) ||
                    ladoMayor <= 0)
                {
                    Console.WriteLine("Lado mayor no válido...Favor reintentar!!!");
                }
                else
                {
                    esNoValido = false;
                }

            } while (esNoValido);
            int ladoMenor;
            esNoValido = true;
            do
            {
                Console.Write("Ingrese la medida del lado menor:");
                if (!int.TryParse(Console.ReadLine(), out ladoMenor) ||
                    ladoMenor <= 0 || ladoMenor>=ladoMayor)
                {
                    Console.WriteLine("Lado menor no válido...Favor reintentar!!!");
                }
                else
                {
                    esNoValido = false;
                }

            } while (esNoValido);
            Rectangulo rectangulo=new Rectangulo(ladoMayor, ladoMenor);
            Console.WriteLine(rectangulo.ToString());
        }
    }
}
