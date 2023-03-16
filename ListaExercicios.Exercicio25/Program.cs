namespace ListaExercicios.Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número de 1 a 10: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Tabuada de {numero}:");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i * numero}");
            }
        }
    }
}