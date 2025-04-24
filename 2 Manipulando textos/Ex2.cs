

//Crie um programa que leia o nome de uma cidade diga se ela começa ou não com o nome "SANTO".

using System;
using System.Globalization;
using System.Linq;
class Treino
{
    static void Main()
    {
        while (true) {
            Console.Write(">Digite o nome de uma cidade: ");
            string nome = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
            {
                if (nome.StartsWith("santo"))
                {
                    Console.Clear();
                    Console.WriteLine($"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)} começa com 'santo'\n\n");
                    break;
                }
                else
                {
                    Console.Clear();
                    /*
                     CultureInfo.CurrentCulture: Retorna informações sobre a cultura atual do sistema (idioma, formatação de datas, números, etc.).
                    
                    .TextInfo: Fornece funcionalidades para manipulação de texto, como capitalização.
                    
                    .ToTitleCase(n): Converte o texto n para Title Case, em que a primeira letra de cada palavra é maiúscula e as demais são minúsculas.
                    
                     */
                    Console.Write($"> {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)} não começa com 'santo'!\n\n");
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Tente novamente!\n\n");
            }
        }

    }
  
}