namespace Ejercicio01.Entidades
{
    public struct Angulo
    {
        private const double VALOR_RADIANES = 0.0174532925;


        public double Grados;
        public int Minutos;
        public int Segundos;

        public Angulo(int grados, int minutos, int segundos)
        {
            Grados = grados + (minutos / 60.0) + (segundos / 3600.0);

        }
        public Angulo(double grados)
        {
            Grados=grados;
        }
        public override string ToString()
        {
            int grados = (int)Grados;
            double restoMinutos = (Grados - grados) * 60;
            int minutos = (int)restoMinutos;
            double segundos = (restoMinutos - minutos) * 60;

            return $"{grados}° {minutos}' {segundos:N2}";
        }
        public double GetRadianes() { 
            return Grados * VALOR_RADIANES;
        }

    }
}
