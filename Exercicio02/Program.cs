namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float raio, altura;
            Console.WriteLine("Digite as medidas de um cilindro: ");
            Console.WriteLine("Raio: ");
            raio = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Altura: ");
            altura = float.Parse(Console.ReadLine()!);
            double volume = Math.PI * Math.Pow(raio,2) * altura;
            Console.WriteLine("O volume desse cilindro é" + volume);
        }
    }
}
