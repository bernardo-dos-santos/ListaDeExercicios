using System.Linq.Expressions;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float comprimento, largura, altura;
            Console.WriteLine("Digite as medidas de uma caixa retangular: ");
            Console.WriteLine("Comprimento: ");
            comprimento = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Altura: ");
            altura = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Largura: ");
            largura = float.Parse(Console.ReadLine()!);
            float volume = comprimento * largura * altura;
            Console.WriteLine("O volume dessa caixa é"+ volume);
            
        }
    }
}
