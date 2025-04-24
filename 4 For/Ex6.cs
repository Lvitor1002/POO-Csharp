
/*
 Faça um programa que leia um número inteiro e diga se ele é ou não um número primo.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Treino
{
    static void Main()
    {

        int numero;

        while (true) { 
            

            Console.Write(">Digite um número inteiro: ");
            string n = Console.ReadLine();
            if (int.TryParse(n, out numero) && numero > 0)
            {
                
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Espereva um 'número inteiro'\n");
            }
        }
        string resultado = Primo(numero);
        Console.Clear();
        Console.Write($"\n{resultado}\n");
    }

    static string Primo(int numero)
    {
        if (numero < 2) return $">{numero} Não é primo!\n";

        for (int i = 2; i <= Math.Sqrt(numero); i ++)
        {
            if (numero % i == 0)
            {
                return $">{numero} Não é primo!\n";
            }
        }
        return $">{numero} é primo!\n";
    }
}