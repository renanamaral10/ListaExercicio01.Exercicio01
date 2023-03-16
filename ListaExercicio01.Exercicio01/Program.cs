namespace ListaExercicio01.Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite a largura ");
            int largura = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite o comprimento ");
            int comprimento = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Digite a altura");
            int altura = Convert.ToInt32(Console.ReadLine());


            int volume = largura * comprimento * altura;

            Console.WriteLine(" O volume da caixa e: "+ volume );




        }
    }
}