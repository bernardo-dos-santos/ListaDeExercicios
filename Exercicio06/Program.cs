namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas notas você tem para calcularmos sua média harmônica");
            int quantasNotas = int.Parse(Console.ReadLine()!);
            float somaDasDivisoes = 0;
            for (int contador = 1; contador <= quantasNotas; contador++ )
            {
                Console.WriteLine($"Nota {contador}: ");
                 float nota = float.Parse(Console.ReadLine()!);
                 somaDasDivisoes += 1 / nota;
            }
            float media = quantasNotas / somaDasDivisoes;
            Console.WriteLine($"Sua média é: {media.ToString("F2")}");
            Console.ReadLine();

            

        }
    }
}
