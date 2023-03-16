namespace ListaExercicios.Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de C ");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B e menor que C ");
            }
            else
            {
                Console.WriteLine("A soma de A e B nao e menor que C ");


            }
        }
    }