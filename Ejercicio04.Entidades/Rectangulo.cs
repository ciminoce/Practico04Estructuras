using System.Text;

namespace Ejercicio04.Entidades
{
    public struct Rectangulo
    {
        public Rectangulo(int ladoMayor, int ladoMenor)
        {
            LadoMayor = ladoMayor;
            LadoMenor = ladoMenor;
        }

        public int LadoMayor { get; set; }
        public int LadoMenor { get; set; }
        public double GetPerimetro() => 2 * LadoMayor + 2 * LadoMenor;
        public double GetSuperficie() => LadoMenor * LadoMayor;
        public double GetDiagonal()=>Math.Sqrt(Math.Pow(LadoMayor, 2)
            +Math.Pow(LadoMenor, 2));

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Datos del Rectángulo");
            sb.AppendLine($"Lado mayor: {LadoMayor}");
            sb.AppendLine($"Lado Menor: {LadoMenor}");
            sb.AppendLine($"Superficie: {GetSuperficie()}");
            sb.AppendLine($"Perímetro: {GetPerimetro()}");
            sb.AppendLine($"Diagonal: {GetDiagonal():N2}");
            return sb.ToString();
        }
    }
}
