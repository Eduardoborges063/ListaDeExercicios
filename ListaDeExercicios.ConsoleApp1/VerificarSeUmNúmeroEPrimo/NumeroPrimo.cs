using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Projeto.Exercicios
{
    public class Exercicio7
    {
       public static void Executar()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            bool primo = true;

            if (numero <= 1)
                primo = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        primo = false;
                        break;
                    }
                }
            }

            if (primo)
                Console.WriteLine($"{numero} é primo.");
            else
                Console.WriteLine($"{numero} não é primo.");
        }
    }
}
