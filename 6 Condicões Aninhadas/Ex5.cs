

/*
A Confederação Nacional de Natação precisa de um programa que leia o ano de nascimento de um atleta e mostre sua categoria, 
de acordo com a idade:
- Até 9 anos: MIRIM
- Até 14 anos: INFANTIL
- Até 19 anos: JÚNIOR
- Até 25 anos: SÊNIOR
- Acima de 25 anos: MASTER
 */

using System;

class Treino
{
    static void Main()
    {
        int idade = Dados();
        
        Console.Clear();
        Console.Write($"\n-=-=-=-=-=-= Categoria de {idade} anos -=-=-=-=-=-=\n");
        if (idade <= 9)
        {
            Console.WriteLine($"\n>Categoria: [MIRIM]\n");
        }
        else if(idade <= 14)
        {
            Console.WriteLine($"\n>Categoria: [INFANTIL]\n");
        }
        else if (idade <= 19)
        {
            Console.WriteLine($"\n>Categoria: [JÚNIOR]\n");
        }
        else if (idade <= 25)
        {
            Console.WriteLine($"\n>Categoria: [SÊNIOR]\n");
        }
        else
        {
            Console.WriteLine($"\n>Categoria: [MASTER]\n");
        }
    }

    static int Dados()
    {
        int ano;

        
        while (true)
        {
            Console.Write(">Digite o seu ano de nascimento: ");
            string a = Console.ReadLine();
            if (int.TryParse(a, out ano) && a.Length == 4 && ano <= DateTime.Now.Year && ano >= 1900)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida! Digite um número inteiro de 4 dígitos entre 1900 e o ano atual.\n");
            }
        }
        int idade = DateTime.Now.Year - ano;
        
        return idade;
    }
}