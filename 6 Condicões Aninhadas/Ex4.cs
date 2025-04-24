

/*
Crie um programa que leia duas notas de um aluno e calcule sua média, 
mostrando uma mensagem no final, de acordo com a média atingida:
- Média abaixo de 5.0: REPROVADO
- Média entre 5.0 e 6.9: RECUPERAÇÃO
- Média 7.0 ou superior: APROVADO
 */

using System;

class Treino
{
    static void Main()
    {
        var (n1, n2, media) = dados();
        
        Console.Clear();
        Console.Write($"\n>Notas: {n1} & {n2}\n");
        if (media < 5)
        {
            Console.WriteLine($"\n>Média: {media:F0}\n>Você está Reprovado!\n");
        }
        else if(media >= 7)
        {
            Console.WriteLine($"\n>Média: {media:F0}\n>Você está Aprovado!\n");
        }
        else
        {
            Console.WriteLine($"\n>Média: {media:F0}\n>Você está de Recuperação!\n");
        }
    }

    static (double n1, double n2, double media) dados()
    {
        double n1, n2, media;

        Console.Write("\n>Digite abaixo 2 notas:\n");
        while (true)
        {
            Console.Write("\n>1ª: ");
            string nota1 = Console.ReadLine();
            if (double.TryParse(nota1, out n1))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número 'Inteiro ou Real'\n");
            }
        }
        while (true)
        {
            Console.Write(">2ª: ");
            string nota2 = Console.ReadLine();
            if (double.TryParse (nota2, out n2))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número 'Inteiro ou Real'\n");
            }
        }
        media = (n1 + n2)/2;
        return (n1, n2, media);
    }
}