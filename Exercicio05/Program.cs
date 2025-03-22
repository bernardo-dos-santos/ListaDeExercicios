namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salarioBase, salarioFinal, percentual, totalVendas, comissao;

            Console.Write("Digite o Salário base do empregado: R$");
            salarioBase = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.Write("Digite o Total de vendas: R$");
            totalVendas = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.Write($"Digite o percentual de comissão: ");
            percentual = decimal.Parse(Console.ReadLine()!);
            Console.WriteLine();
            comissao = totalVendas * percentual / 100;
            salarioFinal = salarioBase + comissao;

            Console.WriteLine($"O salário total desse empregado é: {salarioFinal}");
            Console.ReadLine();
        }
    }
}
