namespace ListaExecicios.Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um Numero inteiro ");
            int Numero = Convert.ToInt32(Console.ReadLine());

            bool NumeroPrimo = true;

            for (int i = 2; i <= Math.Sqrt(Numero); i++)
            {
                if (Numero % i == 0 || Numero <= 1)
                {
                    NumeroPrimo = false;
                    break;
                }
            }

            if (NumeroPrimo)
                Console.WriteLine("O numero e primo ");
            else
                Console.WriteLine("O numero nao e primo ");




        }
    }
}