namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Bem vindo, digite as dimensões dos 4 lados do terreno em metros ");

            Console.WriteLine("Lado leste: ");
            float lado1 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Lado oeste: ");
            float lado2 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Lado norte: ");
            float lado3 = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Lado sul: ");
            float lado4 = float.Parse(Console.ReadLine()!);

            if(EhRetangulo(lado1, lado2, lado3, lado4))
            {
                float area = lado1 * lado3;
                Console.WriteLine($"Ótimo, seu terreno é um retângulo e sua aréa é de {area} metros quadrados");
            } else
            {
                Console.WriteLine("Infelizmente seu terreno não é um retângulo");
            }
            Console.ReadLine();
        }

        static bool EhRetangulo(float lado1, float lado2, float lado3, float lado4)
        {
            bool ehRetangulo = lado1 == lado2 && lado3 == lado4;
            if(ehRetangulo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
