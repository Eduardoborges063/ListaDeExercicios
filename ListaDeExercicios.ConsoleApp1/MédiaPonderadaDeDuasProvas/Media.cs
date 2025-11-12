using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Exercicios
{
    public class Exercicio6
    {
        public static void Executar()
        {
            Console.Write("Digite a nota da primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da primeira prova: ");
            double peso1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a nota da segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da segunda prova: ");
            double peso2 = double.Parse(Console.ReadLine());

            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            Console.WriteLine($"A média ponderada é: {mediaPonderada:F2}");
        }
    }
}
