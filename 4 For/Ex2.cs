
/*
 Faça um programa que calcule a soma entre todos os números que são múltiplos de três e que se encontram no intervalo de 1 até 500.
 */

using System;

class F2
{
    static void Main()
    {
        Calculo();
    }

    static void Calculo()
    {
        int soma = 0;
        Console.Clear(); // Limpa o console, equivalente ao 'os.system("cls")' no Python
        Console.Write("\n>Números múltiplos de 3 de 1 à 500: ");

        for (int i = 1; i <= 500; i++)
        {
            if (i % 3 == 0)
            {
                soma += i;
                Console.Write($"{i}-");
            }
        }

        Console.WriteLine();
        Console.WriteLine($"\nSoma dos números: {soma}\n");
    }
}
