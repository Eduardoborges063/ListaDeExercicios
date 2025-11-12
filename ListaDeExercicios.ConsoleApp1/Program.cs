using System;
using Projeto.Exercicios; 

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("     LISTA DE EXERCÍCIOS C#");
            Console.WriteLine("===================================");
            Console.WriteLine("1 - Volume da Caixa Retangular");
            Console.WriteLine("2 - Volume do Cilindro");
            Console.WriteLine("3 - Consumo de Combustível");
            Console.WriteLine("4 - Conversão Celsius → Fahrenheit");
            Console.WriteLine("5 - Salário Total com Comissão");
            Console.WriteLine("6 - Média Ponderada de Duas Provas");
            Console.WriteLine("7 - Verificar Número Primo");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("===================================");
            Console.Write("Escolha uma opção: ");

            // Tratando erro de entrada
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("\nEntrada inválida! Pressione qualquer tecla para tentar novamente...");
                Console.ReadKey();
                continue;
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:
                    Exercicio1.Executar();
                    break;

                case 2:
                    Exercicio2.Executar();
                    break;

                case 3:
                    Exercicio3.Executar();
                    break;

                case 4:
                    Exercicio4.Executar();
                    break;

                case 5:
                    Exercicio5.Executar();
                    break;

                case 6:
                    Exercicio6.Executar();
                    break;

                case 7:
                    Exercicio7.Executar();
                    break;

                case 0:
                    Console.WriteLine("Saindo... até mais, chefe 😎");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }
}