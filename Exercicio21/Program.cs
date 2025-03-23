namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número, iremos calcular o fatorial dele(apenas até o numero 31)");
            int numero = int.Parse(Console.ReadLine()!);
            int resultado = numero;
            for (int tamanho = numero - 1; tamanho > 0; tamanho--)
            {
                resultado *= tamanho;
                
            }
            Console.WriteLine($"{numero}! = {resultado}");
            Console.ReadLine();
        }
    }
}
