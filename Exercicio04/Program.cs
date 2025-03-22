namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperaturaC, temperaturaF;
            Console.Write("Digite a temperatura em Celsius: ");
            temperaturaC = float.Parse(Console.ReadLine()!);
            Console.WriteLine();
            temperaturaF = (temperaturaC * 9 / 5) + 32;
            Console.WriteLine("Essa temperatura em fahrenheit é: " + temperaturaF);
            Console.ReadLine();
        }
    }
}
