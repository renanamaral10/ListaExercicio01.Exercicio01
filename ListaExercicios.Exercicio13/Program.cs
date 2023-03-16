namespace ListaExercicios.Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de paes vendidos ");
            int qtdpaes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas vendidas ");
            int qtdbroas = Convert.ToInt32(Console.ReadLine());

            double valorpao = 0.12;
            double valorbroa = 1.5;

            double totalpao = qtdpaes * valorpao;
            double totalbroa = qtdbroas * valorbroa;

            double arrecadacaoTotal = totalpao + totalbroa;
            double poupanca = arrecadacaoTotal * 0.1;

            Console.WriteLine("A arrecadacao total foi de R$" + arrecadacaoTotal);
            Console.WriteLine("O que vai para a poupanca R$" + poupanca);



        }
    }
}