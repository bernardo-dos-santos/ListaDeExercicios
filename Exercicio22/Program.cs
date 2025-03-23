namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos termos da Sequência de Fibonacci você desja? ");
            int num = int.Parse(Console.ReadLine()!);
            
            int primeiro = 0, segundo = 1, seguinte;
            Console.Write($"{segundo} ");

            for (int i = 1; i < num; i++ )
            {
                seguinte = primeiro + segundo;
                Console.Write($" {seguinte} ");
                primeiro = segundo;
                segundo = seguinte;
            }
            Console.ReadLine();

        }
    }
}
