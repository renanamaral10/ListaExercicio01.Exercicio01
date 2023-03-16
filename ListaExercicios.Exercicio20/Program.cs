namespace ListaExercicios.Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("\nO número digitado é par.");
            }
            else
            {
                Console.WriteLine("\nO número digitado é ímpar.");
            }
        }
    }
}