
/*
 Desenvolva um programa que leia o primeiro termo e a razão de uma PA. No final, mostre os 10 primeiros termos dessa progressão.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Treino
{
    static void Main()
    {
        int p_termo;
        int razao;

        while (true)
        {

            Console.Write(">Digite o primeiro termo de uma PA - Progressão Aritmética: ");
            string p_t = Console.ReadLine();
            if (int.TryParse(p_t, out p_termo))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número!\n");
            }
        }
        while (true)
        {

            Console.Write(">Digite a razão de uma PA: ");
            string r = Console.ReadLine();
            if (int.TryParse(r, out razao))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número!\n");
            }
        }
        int decimo = p_termo + (10 - 1) * razao;
        for (int i = p_termo; i <= decimo; i += razao)
        {
            Console.Write(i + " -> ");
        }
        Console.WriteLine("Acabou\n");
    }
}