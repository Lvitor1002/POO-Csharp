
/*
Contagem de quantidade Par e ímpar usando while:
 */

using System;
class Treino
{
    static void Main()
    {
        int numero, qtd_numero = 0, par = 0, impar = 0;

        Console.Write("\n>Digite alguns números..\n>Para sair digite 'sair'\n");
        while (true)
        {
            string n = Console.ReadLine().Trim().ToLower();
            if (n == "sair")
            {
                if (qtd_numero == 0)
                {
                    Console.Clear();
                    Console.WriteLine(">Nenhum número foi digitado!\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($">{qtd_numero} números foram digitados.\n" +
                        $">{par} Par\n" +
                        $">{impar} Ímpar\n");

                }
                break;

            }
            if (int.TryParse(n, out numero) && numero > 0)
            {
                qtd_numero += 1;
                if (numero % 2 == 0)
                {
                    par += 1;
                }
                else if (numero % 2 != 0)
                {
                    impar += 1;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro' ou 'Sair'!");
                Console.WriteLine(">Digite um número: ");
            }
        }
    }
}

