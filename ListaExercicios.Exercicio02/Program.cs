namespace ListaExercicios.Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TemperaturaFahrenheit, TemperaturaCelsius;

            Console.WriteLine("Digite a temperatura em graus Fahrenheit: ");
            TemperaturaFahrenheit = Convert.ToInt32(Console.ReadLine());

            TemperaturaCelsius = (TemperaturaFahrenheit - 32) * 5 / 9;

            Console.WriteLine("A temperatura em graus Celsius e: " + TemperaturaCelsius);
        }
    }
}