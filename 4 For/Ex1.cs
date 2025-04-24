
/*
 Crie um programa que mostre na tela todos os números pares que estão no intervalo entre 1 e 50.
 */

using System;
using System.Linq;


class Treino
{
    static void Main()
    {
        Console.Write(">Números pares de 1 à 50:\n");
        for (int i = 0; i<= 50; i += 2)
        {
            Console.Write($"{i}\n");
        }
        
    }
    
}