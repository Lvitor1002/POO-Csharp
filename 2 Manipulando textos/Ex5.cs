

/*
 * Faça um programa que leia o nome completo de uma pessoa, 
 * mostrando em seguida o primeiro e o último nome separadamente.
 */

using System;
using System.Globalization;
using System.Linq;

class Treino
{
    static void Main()
    {
        while (true) {
            Console.Write("Digite um nome: "); // .Trim() -> remover espaços em branco
            string nome = Console.ReadLine()?.Trim();// ?.) para garantir que o Console.ReadLine() não gerasse um erro caso fosse nulo.
            if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
            {
                /*
                     CultureInfo.CurrentCulture: Retorna informações sobre a cultura atual do sistema (idioma, formatação de datas, números, etc.).
                    
                    .TextInfo: Fornece funcionalidades para manipulação de texto, como capitalização.
                    
                    .ToTitleCase(n): Converte o texto n para Title Case, em que a primeira letra de cada palavra é maiúscula e as demais são minúsculas.
                    
                */

                Console.Clear();
                string[] nome_separado = nome.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); 
                string primeiro_nome = nome_separado.First();
                string ultimo_nome = nome_separado.Last();
                Console.Write($"> Nome completo: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome)}\n" +
                    $"> Primeiro nome: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(primeiro_nome)}\n" +
                    $"> Último nome: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ultimo_nome)}\n\n");
                break;
            }
            else
            {
                Console.Clear() ;
                Console.Write(">Entrada inválida!\n");
            }
        }
    }

}