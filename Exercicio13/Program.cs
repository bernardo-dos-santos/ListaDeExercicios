namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores A, B e C");
            Console.Write("A: ");
            decimal A = decimal.Parse(Console.ReadLine()!);
            Console.Write("B: ");
            decimal B = decimal.Parse(Console.ReadLine()!);
            Console.Write("C: ");
            decimal C = decimal.Parse(Console.ReadLine()!);

            if (A + B < C )
            {
                Console.WriteLine("A soma de A + B é menor que C");
            } else
            {
                Console.WriteLine("A soma de A + B é maior ou igual a C");
            }
            Console.ReadLine();
        }
    }
}
