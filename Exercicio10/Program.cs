namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de pães: ");
            int paes = int.Parse(Console.ReadLine()!);
            Console.Write("Digite a quantidade de broas: ");
            int broas = int.Parse(Console.ReadLine()!);

            double valorFinal = (paes * 0.12) + (broas * 1.5);
            double poupanca = valorFinal * 0.1;
            Console.WriteLine($"O seu valor arrecadado hoje foi de: R${valorFinal.ToString("F2")}");
            Console.WriteLine($"O valor destinado para a poupança é de R${poupanca.ToString("F2")}");
            Console.ReadLine();
        }
    }
}
