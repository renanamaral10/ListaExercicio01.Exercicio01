namespace ListaExerciciosExercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Digite o primeiro numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num1 + ", " + num2 + ", " + num3);
                }
                else
                {
                    Console.WriteLine(num1 + ", " + num3 + ", " + num2);
                }
            }
            else if (num2 > num1 && num2 > num3)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num2 + ", " + num1 + ", " + num3);
                }
                else
                {
                    Console.WriteLine(num2 + ", " + num3 + ", " + num1);
                }
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine(num3 + ", " + num1 + ", " + num2);
                }
                else
                {
                    Console.WriteLine(num3 + ", " + num2 + ", " + num1);
                }
            }

        }
    }
}