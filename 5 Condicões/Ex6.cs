

/*
 Escreva um programa que pergunte o salário de um funcionário e calcule o valor do seu aumento. 
Para salários superiores a R$1250,00, calcule um aumento de 10%. Para os inferiores ou iguais, o aumento é de 15%.
 */

using System;

class Treino
{
    static void Main()
    {
        double salario;

        while (true)
        {
            Console.Write(">Digite o seu salário: R$");
            string s = Console.ReadLine();
            if (double.TryParse(s, out salario)) 
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Esperava um número 'Real ou inteiro'!\n");
            }
        }
        if(salario > 1250)
        {
            Console.Clear();
            Console.WriteLine($">Parabéns! Você ganhou um aumento de 10% em seu Salário de R${salario:F2} reais!\n" +
                $">Novo salário: {salario*1.10:F2} reais.\n");
        }
        else
        {
            Console.Clear();
            Console.WriteLine($">Parabéns! Você ganhou um aumento de 15% em seu Salário de R${salario:F2} reais!\n" +
                $">Novo salário: {salario*1.15:F2} reais.\n");
        }
    }
}