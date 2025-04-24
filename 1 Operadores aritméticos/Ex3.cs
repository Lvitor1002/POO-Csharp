
//# Faça um programa que leia um número int e mostre na tela a sua tabuada.
using System;

class Treino
{
    static void Main()
    {
        int numero = tabuada();

        Console.Clear();    
        Console.WriteLine(new string('~',50));
        Console.Write($">Tabuada do [{numero}]:\n\n");
        for (int i = 0; i <= 10; i++)
        {
            Console.Write($"| {numero,2} x {i,2} = {numero*i,3} |\n");
        }
        Console.WriteLine(new string('~', 50));
    }

    static int tabuada() 
    {
        int numero;
        while (true)
        {
            
            Console.Write(">Digite um número para formar a tabuada:");
            string n = Console.ReadLine();
            if(int.TryParse(n, out numero))
            {
                return numero;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Erro! Esperava um 'inteiro'..\n");
            }
        }
        
    }
}

