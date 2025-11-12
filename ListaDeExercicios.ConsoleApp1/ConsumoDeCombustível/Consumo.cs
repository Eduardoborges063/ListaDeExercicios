using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Exercicios
{
    public class Exercicio3
    {
        public static void Executar()
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
}
