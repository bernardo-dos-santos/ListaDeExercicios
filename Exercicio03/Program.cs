namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float kmInicial, kmFinal, consumoCombustivel, kmPercorrido, consumoPorLitro;  
            Console.Write("Digite a quilometragem inicial: ");
            kmInicial = float.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.Write("Digite a quilometragem final: ");
            kmFinal = float.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Console.Write("Digite o consumo de combustivel (em litros) ");
            consumoCombustivel = float.Parse(Console.ReadLine()!);
            Console.WriteLine();

            kmPercorrido = kmFinal - kmInicial;
            consumoPorLitro = kmPercorrido / consumoCombustivel;

            Console.WriteLine($"Seu Consumo de combustivel por litro foi de: {consumoPorLitro}");


        }
    }
}
