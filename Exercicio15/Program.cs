namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sue peso e sua altura");
            Console.Write("Peso(Kg): ");
            float peso = float.Parse(Console.ReadLine()!);
            Console.Write("Altura(m): ");
            float altura = float.Parse(Console.ReadLine()!);
            double imc = peso / Math.Pow(altura,2);

            if (imc < 18.5)
                Console.WriteLine($"O seu IMC é de {imc.ToString("F2")}, que se encontra em abaixo do peso");
            if (imc >= 18.5 && imc <= 25 )
                Console.WriteLine($"O seu IMC é de {imc.ToString("F2")}, que se encontra em peso normal");
            if (imc > 25 && imc <= 30)
                Console.WriteLine($"O seu IMC é de {imc.ToString("F2")}, que se encontra em acima do peso");
            if (imc > 30)
                Console.WriteLine($"O seu IMC é de {imc.ToString("F2")}, que se encontra em obessidade ");
            Console.ReadLine();
        }
    }
}
