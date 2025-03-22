using System.Xml;

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas duas notas e seus respectivos pesos");
            float nota1, nota2, peso1, peso2;
            Console.WriteLine("Nota 1: ");
            nota1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Peso 1: ");
            peso1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Nota 2: ");
            nota2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Peso 2: ");
            peso2 = float.Parse(Console.ReadLine()!);

            float media = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
            Console.WriteLine("Sua média é: "+ media);
            Console.ReadLine();
        }
    }
}
