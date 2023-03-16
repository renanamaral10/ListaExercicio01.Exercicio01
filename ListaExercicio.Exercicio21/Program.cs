using System.Runtime.InteropServices;

namespace ListaExercicio.Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int resultado;

            Console.Write("Digite o valor de A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                resultado = a + b;
                Console.WriteLine("OS valores são iguais. A soma é " + resultado);
            }
            else
            {
                resultado = a * b;
                Console.WriteLine("Os valores sao diferentes. A multiplicacao e " + resultado);
            }
        }
    }
}