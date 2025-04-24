
/*
 Faça um programa que mostre na tela uma contagem regressiva para o estouro de fogos de artifício, 
indo de 10 até 0, com uma pausa de 1 segundo entre eles
 */

using System;
using System.Linq;
using System.Threading;

class Treino
{
    static void Main()
    {
        Console.Clear();
        Console.Write(">Contagem regressiva para o Ano novo!\n\n");
        for (int c = 10; c >= 0; c-= 1) {
            Console.WriteLine(c);
            Thread.Sleep(1000);
        }
        Console.WriteLine("FELIZ 2025!!");
        
    }
    
}