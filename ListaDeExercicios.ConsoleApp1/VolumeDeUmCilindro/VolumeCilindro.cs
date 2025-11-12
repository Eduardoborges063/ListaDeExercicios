using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Exercicios
{
    public class Exercicio2
    {
        public static void Executar()
        {
            Console.Write("Digite o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(raio, 2) * altura;
            Console.WriteLine($"O volume do cilindro é: {volume:F2}");
        }
    }
}
