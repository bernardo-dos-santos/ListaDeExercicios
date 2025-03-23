namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()!);
            for (int contador = 0; contador < 11; contador++)
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
            }
            Console.ReadLine();
        }
    }
}
