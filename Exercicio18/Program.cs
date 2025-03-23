namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int contador = 100; contador < 201; contador++)
            {
                if (contador % 2 != 0 )
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadLine();
        }
    }
}
