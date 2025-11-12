using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Exercicios
{
    public class Exercicio5
    {
        public static void Executar()
        {
            Console.Write("Digite o salário base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (%): ");
            double percentual = double.Parse(Console.ReadLine());

            double comissao = totalVendas * (percentual / 100);
            double salarioTotal = salarioBase + comissao;

            Console.WriteLine($"O salário total é: R$ {salarioTotal:F2}");
        }
    }
}
