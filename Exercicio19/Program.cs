namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int numero = 1; numero < 501; numero++)
            {
               if(numero%2 != 0 && numero%3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }
            Console.ReadLine();
        }
    }
}
