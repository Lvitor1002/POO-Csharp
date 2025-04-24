

/*
 Desenvolva um programa que leia o comprimento de três retas e diga ao usuário se elas podem ou não formar um triângulo.
 */

using System;

class Treino
{
    static void Main()
    {
        int[] retas = dados();

        Console.Write($"\nRetas digitadas:\n");
        foreach (var reta in retas)
        {
            Console.Write($"{reta} | ");
        }
        
        if ((retas[0] + retas[1] > retas[2]) && (retas[1] + retas[2] > retas[0]) && (retas[0] + retas[2] > retas[1]))
        {
            Console.Clear();
            Console.Write("\n>É um triângulo!\n");
        }
        else
        {
            Console.Clear();
            Console.Write("\n>Não é um triângulo!\n");
        }
    }

    static int[] dados()
    {
        int[] retas = new int[3];
        int reta;

        Console.Write("\n>Digite 3 reats:\n");
        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.Write($">{i + 1}ª: ");
                string r = Console.ReadLine();
                if (int.TryParse(r, out reta) && reta > 0)
                {
                    retas[i] = reta;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Esperava um número inteiro positivo.");
                }
            }
        }
        return retas;
    }
}