

/*
 Faça um programa que leia um ano qualquer e mostre se ele é bissexto.
 */

using System;

class Treino
{
    static void Main()
    {
        int ano;
       while (true)
        {
            Console.Write(">Digite um ano: ");
            string a = Console.ReadLine();
            if (int.TryParse(a, out ano) && a.Length == 4)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um ano 'inteiro' de 4 digitos!\n");
            }
        }

       if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
        {
            Console.Clear();
            Console.WriteLine($"\n>O ano {ano} é bissexto.\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"\n>O ano {ano} não é bissexto.\n");
        }
    }
}