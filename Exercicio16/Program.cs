﻿namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()!);

            if (numero % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            } else
            {
                Console.WriteLine("Esse número é ímpar");
            }
            Console.ReadLine();
        }
    }
}
