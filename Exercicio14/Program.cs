namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Digite três números: ");
            Console.WriteLine("Numero 1: ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Numero 2: ");
            int num2 = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Numero 3: ");
            int num3 = int.Parse(Console.ReadLine()!);
            int maior = num1, menor = num1, meio = num1 ;

            if (num2 > maior) maior = num2;
            if (num3 > maior) maior = num3;

            if (num2 < menor) menor = num2;
            if (num3 < menor) menor = num3;

            if (num1 != maior && num1 != menor) meio = num1;
            if (num2 != maior && num2 != menor) meio = num2;
            if (num3 != maior && num3 != menor) meio = num3;
            Console.WriteLine($"A ordem dos números, em decrescente é {maior}, {meio}, {menor}");
            Console.ReadLine();
        }
    }
}
