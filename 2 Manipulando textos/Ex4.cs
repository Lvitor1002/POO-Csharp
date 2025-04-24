

/*
Faça um programa que leia uma frase pelo teclado e mostre quantas vezes aparece a letra "A", 
em que posição ela aparece a primeira vez e em que posição ela aparece a última vez.
*/

using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
class Treino
{
    static void Main()
    {
        var (frase, vezes_A, primeira_posicao_A, ultima_posicao_A) = leitura();
        Console.Clear();
        Console.Write($"\n> Frase: {frase}\n\n" +
            $"> Quantidade de vezes de 'A': {vezes_A} Vezes.\n" +
            $"> Primeira posicão de 'A': {primeira_posicao_A}ª\n" +
            $"> Última posição de 'A': {ultima_posicao_A}ª\n\n");
    }
    static (string frase, int vezes_A, int primeira_posicao_A, int ultima_posicao_A) leitura()
    {
        string frase;
        int vezes_A = 0;
        int primeira_posicao_A = 0;
        int ultima_posicao_A = 0;

        while (true)
        {
            Console.Write(">Digite uma frase qualquer: ");
            frase = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(frase) && !frase.Any(char.IsDigit))
            {
                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == 'a')
                    {
                        vezes_A += 1;
                    }
                }
                string frase_sem_espaço = frase.Replace(" ", "");
                primeira_posicao_A = frase_sem_espaço.IndexOf('a') + 1;
                ultima_posicao_A = frase_sem_espaço.LastIndexOf('a') + 1;
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Tente novamente..\n\n");
            }
           
        }
        return (frase, vezes_A, primeira_posicao_A, ultima_posicao_A);

    }
  
}