

/*
Escreva um programa que leia dois números inteiros e compare-os. 
mostrando na tela uma mensagem:
- O primeiro valor é maior
- O segundo valor é maior
- Não existe valor maior, os dois são iguais
 */

using System;

class Treino
{

    static void Main()
    {
        int primeiro_valor;
        int segundo_valor;

        Console.Write("\n>Digite 2 valores para comparação:\n");

        while (true)
        {
            Console.Write(">1ª: ");
            string p = Console.ReadLine();
            if (int.TryParse(p, out primeiro_valor))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida! Esperava um número 'inteiro'\n");
            }

        }

        while (true)
        {
            Console.Write(">2ª: ");
            string s = Console.ReadLine();
            if (int.TryParse(s, out segundo_valor))
            {
                break;
            }

            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida! Esperava um número 'inteiro'\n");
            }
        }
        
        if (primeiro_valor > segundo_valor)
        {
            Console.Clear();
            Console.Write($"\n>Primeiro valor é maior!\n\n>Primeiro: {primeiro_valor}\n>Segundo: {segundo_valor}\n");
        }
        else if(primeiro_valor == segundo_valor)
        {
            Console.Clear();
            Console.Write($"\n>Valores iguais!\n\n>Primeiro: {primeiro_valor}\n>Segundo: {segundo_valor}\n");
        }
        else
        {
            Console.Clear();
            Console.Write($"\n>Segundo valor é maior!\n\n>Primeiro: {primeiro_valor}\n>Segundo: {segundo_valor}\n");
        }
    }
}