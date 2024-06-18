using System.Text;

namespace Ejercicio03.Entidades
{
    public struct Circunferencia
    {
        public int Radio { get; set; }
        public Circunferencia(int radio)
        {
            Radio = radio;
        }
        public double GetPerimetro()=>2*Math.PI*Radio;
        public double GetSuperficie()=>Math.PI*Math.Pow(Radio,2);
        public double GetDiametro() => 2 * Radio;
        public double GetLongitudArco() => Math.PI * GetDiametro();

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Circunferencia de radio: {Radio}");
            sb.AppendLine($"Perímetro: {GetPerimetro():N2}");
            sb.AppendLine($"Superficie:{GetSuperficie():N2}");
            sb.AppendLine($"Diámetro: {GetDiametro()}");
            sb.AppendLine($"Long. Arc:{GetLongitudArco():N2}");
            return sb.ToString();
        }
    }
}
