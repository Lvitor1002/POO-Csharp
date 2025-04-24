
/*
 Crie um programa que leia o ano de nascimento de sete pessoas. No final, 
mostre quantas pessoas ainda não atingiram a maioridade e quantas já são maiores.
 */


using System;
using static System.Net.Mime.MediaTypeNames;


class Treino
{
    static void Main()
    {
        int ano;
        int maior_idade = 0;
        int menor_idade = 0;
        int idade;

        Console.Write("\n>Digite o ano de nascimento de 7 pessoas:\n\n");
        for (int i = 0; i < 7; i += 1)
        {
            while (true)
            {
                
                Console.Write($">{i+1}ª: ");
                string a = Console.ReadLine();
                

                if (int.TryParse(a, out ano) && a.Length == 4 && ano > 0){
                    idade = DateTime.Now.Year - ano;
                    if (idade >= 18)
                    {
                        maior_idade += 1;
                    }
                    else
                    {
                        menor_idade += 1;
                    }
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava 4 números inteiros!\n");
                }
            }
        }
        Console.Clear();
        if (maior_idade <= 1)
        {
            Console.Write($"\n> {maior_idade} Pessoa é maior de idade!\n");
        }
        else if (maior_idade >= 2)   
        {
            Console.Write($"\n> {maior_idade} Pessoas são maiores de idade!\n");
        }
        if (menor_idade <= 1)
        {
            Console.Write($"\n> {menor_idade} Pessoa ainda não atingiu a maior idade!\n");
        }
        else if (menor_idade >= 2)
        {
            Console.Write($"\n> {menor_idade} Pessoas ainda não atingiram a maior idade!\n");
        }
        
    }
}