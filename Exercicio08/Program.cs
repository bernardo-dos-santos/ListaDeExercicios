namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número: ");
            int numero = int.Parse(Console.ReadLine()!);
            if (ehPrimo(numero))
            {
                Console.WriteLine("O número que você digitou é primo");
            }else
            {
                Console.WriteLine("O número que você digitou não é primo");
            }
            Console.ReadLine();

        }

        static bool ehPrimo(int numero)
        {
            bool teste1 = numero % 2 != 0;
            bool teste2 = numero % 3 != 0;
            bool teste3 = numero % 5 != 0;
            bool teste4 = numero % 7 != 0;
            bool teste5 = numero % 11 != 0;
            if (teste1 && teste2 && teste3 && teste4 && teste5)
            {
                return true;
           
            }else
            {
                return false;
            }
        }
    }
}
