

/*
 Faça um programa que leia três números e mostre qual é o maior e qual é o menor.
 */

using System;

class Treino
{
    static void Main()
    {
        int[] numeros = leitura();

        int maior = int.MinValue;/*Aqui inicializamos a variável maior com o menor valor possível de um inteiro. 
        Isso garante que qualquer número lido será maior que maior na primeira comparação do laço, 
        permitindo a lógica de encontrar o maior número.*/

        int menor = int.MaxValue;/*Aqui inicializamos a variável menor com o maior valor possível de um inteiro. 
         Isso garante que qualquer número lido será menor que menor na primeira comparação do laço, 
        permitindo a lógica de encontrar o menor número.*/

        foreach (var numero in numeros)
        {
            if(numero > maior)
            {
                maior = numero;
            }
            if(numero < menor)
            {
                menor = numero;
            }
        }

        if (numeros[0] == numeros[1] && numeros[0] == numeros[2])
        {
            Console.Clear();
            Console.Write(">Números iguais!\n");
            foreach (var numero in numeros)
            {
                Console.Write($"{numero} | ");
            }
            Console.WriteLine();
            
        }
        else
        {
            Console.Write($"\n>Maior valor:{maior}\n>Menor valor:{menor}\n");
        }
    }

    static int[] leitura()
    {
        int[] numeros = new int[3];
        int numero;

        Console.Write("\n>Digite 3 valores:\n");
        for (int i = 0; i < 3; i++)
        {

            while (true)
            {
                Console.Write($">{i + 1}ª: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numero))
                {

                    numeros[i] = numero;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Esperava um número inteiro!");
                }
            }
        }
        return numeros;
    }
}