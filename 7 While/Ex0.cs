

/*
Faça um programa que leia o sexo de uma pessoa, mas só aceite os valores 'M' ou 'F'. 
Caso esteja errado, peça a digitação novamente até ter um valor correto.
 */

using System;
using System.Globalization;

class Treino
{
    static void Main()
    {
        string sexo;
        while (true)
        {
            Console.Write("\n>Digite o seu sexo: [M] ou [F]: ");
            sexo = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(sexo))
            {
                if (sexo == "m" || sexo == "f")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Esperava sexo [F] ou [M]!\n>Tente novamente..");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava uma 'string'!\n>Tente novamente..");
            }
        }
        Console.Clear();
        Console.WriteLine($">Você digitou o sexo corretamente: [{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sexo)}]");
    }
}