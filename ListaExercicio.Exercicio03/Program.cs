namespace ListaExercicio.Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;


            Console.WriteLine("Digite o raio do cilindro ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do clindro ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume do cilindro e: " + volume);
        }
    }
}