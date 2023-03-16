namespace ListaExercicios.Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do terreno em metros ");
            double largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terreno ");
            double comprimento = Convert.ToDouble(Console.ReadLine());

            double area = largura * comprimento;

            Console.WriteLine("A area do terreno e: " + area);
            
        }
    }
    }
