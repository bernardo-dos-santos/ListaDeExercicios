namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine()!);
            int dias = idade * 365;
            Console.WriteLine($"{nome}, você já viveu {dias} dias");
            Console.ReadLine();
        }
    }
}
