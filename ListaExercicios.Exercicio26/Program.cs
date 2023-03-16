namespace ListaExercicios.Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int fatorial = 1;

            Console.Write("Digite um número inteiro para calcular o fatorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write($"\n{numero}! = ");
            for (int i = numero; i >= 1; i--)
            {
                Console.Write($"{i}");
                fatorial *= i;
                if (i > 1)
                {
                    Console.Write(" x ");
                }
            }
            Console.Write("= " + fatorial);
        }
    }
    
}