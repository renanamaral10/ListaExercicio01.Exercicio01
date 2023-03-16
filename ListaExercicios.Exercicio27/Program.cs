namespace ListaExercicios.Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int anterior = 0;
            int atual = 1;
            int proximo;

            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("A Sequência de Fibonacci até o número e " + numero);

            while (atual <= numero)
            {
                Console.Write($"{atual} ");

                proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
        }
    }
}