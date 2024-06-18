using System.Text;

namespace Ejercicio02.Entidades
{
    public struct Cuadrado
    {
        public int Lado { get; set; }
        public Cuadrado(int lado)
        {
            Lado= lado;
        }
        public double GetPerimetro() => Lado * 4;
        public double GetSuperficie() => Math.Pow(Lado, 2);
        public double GetDiagonal() => Math.Sqrt(2) * Lado;
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Cuadrado de lado: {Lado}");
            sb.AppendLine($"Superficie: {GetSuperficie()}");
            sb.AppendLine($"Perímetro: {GetPerimetro()}");
            sb.AppendLine($"Diagonal: {GetDiagonal():N2}");
            return sb.ToString();   
        }
    }
}
