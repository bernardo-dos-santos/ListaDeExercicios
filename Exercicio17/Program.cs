namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números: ");

            Console.Write("Numero 1: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("Numero 2: ");
            int num2 = int.Parse(Console.ReadLine()!);
            int resultado;
            if(num1 == num2)
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado é: " + resultado);
            } else
            {
                resultado = num1 * num2;
                Console.WriteLine("O resultado é "+ resultado);      
            }
            Console.ReadLine();
        }
    }
}
