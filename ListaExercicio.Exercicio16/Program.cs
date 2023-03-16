namespace ListaExercicio.Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario do funcionario: R$ ");
            double salaraio = Convert.ToDouble(Console.ReadLine());

            double aumento = salaraio * 0.15;
            double salarioaumentado = salaraio + aumento;
            double imposto = salarioaumentado * 0.08;
            double salariofinal = salarioaumentado - imposto;

            Console.WriteLine("Salario inicial e " + salaraio);
            Console.WriteLine("O salario com aumento e " + salarioaumentado);
            Console.WriteLine("O salario final e " + salariofinal);


        }
    }
}