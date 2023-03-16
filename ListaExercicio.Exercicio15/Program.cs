namespace ListaExercicio.Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus celsius ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine("A temperatura em fahrenheit e " + fahrenheit);
        }
    }
}