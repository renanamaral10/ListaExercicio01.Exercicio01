namespace ListaExercicios.Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a nota da primeira prova ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da primeira prova ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o peso da segunda prova ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double mediaponderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            Console.WriteLine("A media ponderada e " + mediaponderada);



        }
    }
}