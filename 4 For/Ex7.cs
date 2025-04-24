
/*
Crie um programa que leia uma frase qualquer e diga se ela é um palíndromo, desconsiderando os espaços.
Exemplos de palíndromos: 
APOS A SOPA, 
A SACADA DA CASA, 
A TORRE DA DERROTA, 
O LOBO AMA O BOLO, 
ANOTARAM A DATA DA MARATONA.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading;

class Treino
{
    static void Main()
    {
        string frase;
        string frase_inversa = "";
        while (true)
        {
            Console.Write(">Digite uma frase: ");
            frase = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(frase) && !frase.Any(char.IsDigit))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava uma frase em 'string'!\n");
            }
        }
        //Deixando a frse inversa:
        for (int i = frase.Length - 1; i >= 0; i -= 1)
        {
            
            frase_inversa += frase[i];  //frase[i] pega o caractere da string frase na posição i
            // frase_inversa pega o caractere atual (frase[i]) e o adiciona no final da string frase_inversa
        }

        if (frase == frase_inversa)
        {                           
            Console.Clear() ;
            Console.Write($"\n>A frase é Palíndromo!\n" +
                $">Frase original: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase)}\n" +
                $">Frase invertida: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase_inversa)}\n");
        }
        else
        {
            Console.Clear();
            Console.Write($"\n>A frase NÃO é Palíndromo!\n" +
                $">Frase original: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase)}\n" +
                $">Frase invertida: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(frase_inversa)}\n");
        }

    }
}