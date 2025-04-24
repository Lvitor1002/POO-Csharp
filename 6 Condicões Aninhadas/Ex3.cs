
/*
Faça um programa que leia o ano de nascimento de um jovem e informe, de acordo com a sua idade, 
se ele ainda vai se alistar ao serviço militar, 
se é a hora exata de se alistar ou se já passou do tempo do alistamento. 
Seu programa também deverá mostrar o tempo que falta ou que passou do prazo.
 */

using System;

class Treino
{
    static void Main()
    {
        int ano;
        while (true)
        {
            Console.Write("\n>Digite o seu ano de nascimento: ");
            string a = Console.ReadLine();
            if (int.TryParse(a, out ano) && ano > 1900 && ano < 2025)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Entrada inválida! Esperava 4 números 'inteiros'!\n");
            }
        }
        int idade = DateTime.Now.Year - ano;
        if (idade < 18)
        {
            Console.Clear();
            Console.Write($"\n>Idade: {idade} anos. Ainda faltam {18-idade} anos para se alistar!\n" +
                $">Ano de alistamento {(DateTime.Now.Year + (18 - idade))}\n");
        }
        else if(idade > 50)
        {
            Console.Clear();
            Console.Write($">\nNão é possível se alistar pois já possui idade avançada de {idade} anos. Desculpe!\n");
        }
        else
        {
            Console.Clear();
            Console.Write($"\n>Idade: {idade} anos. Já deveria ter se alistado no ano de {DateTime.Now.Year + (18 - idade)}!\n" +
                $">[Se aliste imediatamente]!\n");
        }
    }
}