

/*
Faça um programa que mostre a tabuada de vários números, um de cada vez, para cada valor digitado pelo usuário. 
O programa será interrompido quando a entrada for 'sair'. 
 */


using System;
class Treino
{
    static void Main()
    {
        int numero;
        Console.Write("\n>Digite um número para tabuada:\n>Para interromper digite 'sair'\n");

        while (true)
        {
            
            string n = Console.ReadLine().Trim().ToLower();
            if (n == "sair")
            {
                Console.Clear();
                Console.WriteLine("\nSaindo..");
                break;
            }
            
            if (int.TryParse(n, out numero) && numero > 0)
            {
                Console.Clear();
                Console.WriteLine($"\nTabuada do {numero}:");
                for (int i = 1; i <= 10; i += 1)
                {
                    Console.WriteLine($"\n| {numero,2} x {i,2} = {numero * i,3}  |");
                }
                Console.Write("\n>Digite outro número ou 'sair': ");
                continue;
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro' ou 'sair'\n");
            }
        }
    }
}

