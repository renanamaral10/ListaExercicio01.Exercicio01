namespace ListaExercicio.Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Os valores são iguais. A soma atribuida de C é " + c);
            }
            else
            {
                c = a * b;
                Console.WriteLine("Os valores são diferentes. A multiplicação atribuida de C é " + c);
            }
        }
    }
}