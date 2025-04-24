

/*
Desenvolva um programa que leia o comprimento de três retas e diga ao usuário se elas podem ou não formar um triângulo.
Mostre que tipo de triângulo será formado:
- EQUILÁTERO: todos os lados iguais
- ISÓSCELES: dois lados iguais, um diferente
- ESCALENO: todos os lados diferentes
 */

using System;

class Treino
{
    static void Main()
    {
        int reta;
        int[] retas = new int[3];

        Console.Write("\n>Digite 3 retas para um triângulo;\n");
        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                Console.Write($"{i + 1}ª: ");
                string r = Console.ReadLine();
                if (int.TryParse(r, out reta))
                {
                    retas[i] = reta;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! Esperava um número 'inteiro'\n");
                }
            }
        }
        if ((retas[0] + retas[1] > retas[2]) && (retas[1] + retas[2] > retas[0]) && retas[2] + retas[0] > retas[1])
        {
            Console.Clear();
            Console.WriteLine(">Triângulo formado!\n");

            if (retas[0] == retas[1] && retas[1] == retas[2])
            {
                Console.Clear();
                Console.WriteLine(">Triângulo Equilátero - Todos os lados iguais!\n");
            }else if (retas[0] != retas[1] && retas[1] != retas[2])
            {
                Console.Clear();
                Console.WriteLine(">Triângulo Escaleno - Todos os lados diferentes!\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Triângulo Isósceles - Dois lados iguais e um diferente!\n");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(">Não foi possível formar um Triângulo!\n");
        }
        
    }
}