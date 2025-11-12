using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Exercicios
{
    public class Exercicio1
    {
        public static void Executar()
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
}
