using System;

class Exercicio1
{
    static void Main()
    {
        Console.Write("Digite o comprimento da caixa: ");
        double comprimento = double.Parse(Console.ReadLine());

        Console.Write("Digite a largura da caixa: ");
        double largura = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura da caixa: ");
        double altura = double.Parse(Console.ReadLine());

        double volume = comprimento * largura * altura;
        Console.WriteLine($"O volume da caixa é: {volume:F2}");
    }
}

class Exercicio2
{
    static void Main()
    {
        Console.Write("Digite o raio do cilindro: ");
        double raio = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do cilindro: ");
        double altura = double.Parse(Console.ReadLine());

        double volume = Math.PI * Math.Pow(raio, 2) * altura;
        Console.WriteLine($"O volume do cilindro é: {volume:F2}");
    }
}
class Exercicio3
{
    static void Main()
    {
        Console.Write("Digite a quilometragem inicial: ");
        double kmInicial = double.Parse(Console.ReadLine());

        Console.Write("Digite a quilometragem final: ");
        double kmFinal = double.Parse(Console.ReadLine());

        Console.Write("Digite o combustível consumido (litros): ");
        double combustivel = double.Parse(Console.ReadLine());

        double distancia = kmFinal - kmInicial;
        double consumo = distancia / combustivel;

        Console.WriteLine($"O consumo médio foi de {consumo:F2} km/L");
    }
}

