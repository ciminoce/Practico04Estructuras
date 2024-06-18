namespace ConsoleApp01.Entidades
{
    public struct Temperatura
    {
        public DateTime Fecha;
        public double ValorCelsius;

        public Temperatura(DateTime fecha, double valorCelsius)
        {
            Fecha = fecha;
            ValorCelsius = valorCelsius;
        }

        public double GetValorFahrenheit()
        {
            return 1.8 * ValorCelsius + 32;
        }

        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()}: {ValorCelsius}°C / {GetValorFahrenheit()}°F";
        }
    }
}
