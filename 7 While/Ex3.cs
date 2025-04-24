
/*
Faça um programa que leia um número qualquer e mostre o seu fatorial.

Ex: 5! = 5 x 4 x 3 x 2 x 1 = 120
 */

using System;



class Treino
{
    static void Main()
    {
        int numero, fatorial = 1;
        string exibir_x = "";
        
        while (true)
        {
            Console.Write(">Digite um número qualquer: ");
            string n = Console.ReadLine();
            if(int.TryParse(n, out numero) && numero > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro ou real'!");
            }
        }
        
        for (int i = numero; i > 0; i--) 
        {
            fatorial *= i;
            exibir_x += i;
            
            if (i > 1)
            {
                exibir_x += " x ";
            }
        }

        Console.Clear();
        Console.WriteLine($"\n>Fatorial de {numero}! = {exibir_x} = {fatorial}");
        
    }
}