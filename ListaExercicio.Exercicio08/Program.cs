namespace ListaExercicio.Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio da lata de oleo ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a altura da lata de oleo ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de oleo e: " + volume);
        }
    }
}