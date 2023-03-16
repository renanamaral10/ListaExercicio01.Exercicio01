namespace ListaExercicios.Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quilometragem inicial ");
            double Kminicial = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quilometragem final ");
            double Kmfinal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustivel em litros ");
            double consumo = Convert.ToDouble(Console.ReadLine());

            double distancia = Kmfinal - Kminicial;
            double consumoporkm = consumo / distancia;

            Console.WriteLine("O consumo de combustivel por km e: " + consumoporkm);
        }
    }
}