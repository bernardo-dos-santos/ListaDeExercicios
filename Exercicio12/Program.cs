namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: R$");
            decimal salario = decimal.Parse(Console.ReadLine()!);
            decimal salarioAumento = salario + (salario * 15 / 100);
            decimal salarioDesconto = salarioAumento * 92 / 100;

            Console.WriteLine($"O salário com aumento é de R${salarioAumento}");
            Console.WriteLine($"O salário final, com impostos, é de R${salarioDesconto}");
            Console.ReadLine();

        }
    }
}
