using Microsoft.Win32.SafeHandles;

namespace Listaexercicio.Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o salario base do vendedor ");
            double salariobase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do vendedor ");
            double totalvendas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissao sobre as vendas em % ");
            double percentualcomissao = Convert.ToDouble(Console.ReadLine());

            double comissao = (percentualcomissao / 100) * totalvendas;

            double salariototal = salariobase + comissao;

            Console.WriteLine("O salario total do vendedor e: " + salariototal);




        }
    }
}