

//Crie um programa que leia o nome de uma pessoa e diga se ela tem "silva" no nome.

using System;
using System.Globalization;
using System.Linq;
class Treino
{
    static void Main()
    {
        while (true) {
            Console.Write(">Digite um nome: ");
            string nome = Console.ReadLine().ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit)) {
                 if (nome.Contains("silva"))
                {
                    Console.Clear();
                    Console.Write($"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)} possui 'silva'\n\n");
                    break;
                }
                else
                {
                    /*
                     CultureInfo.CurrentCulture: Retorna informações sobre a cultura atual do sistema (idioma, formatação de datas, números, etc.).
                    
                    .TextInfo: Fornece funcionalidades para manipulação de texto, como capitalização.
                    
                    .ToTitleCase(n): Converte o texto n para Title Case, em que a primeira letra de cada palavra é maiúscula e as demais são minúsculas.
                    
                     */
                    Console.Clear();
                    Console.Write($"{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)} não possui 'silva'\n\n");
                    break;
                }
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Tente novamente!\n");
            }
        }
    }
  
}