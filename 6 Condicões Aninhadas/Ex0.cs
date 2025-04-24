

/*
Escreva um programa para aprovar o empréstimo bancário para a compra de uma casa. 
Pergunte o valor da casa, o salário do comprador e em quantos anos ele vai pagar. 
A prestação mensal não pode exceder 30% do salário ou então o empréstimo será negado.
*/

using System;

class Treino
{
    static void Main()
    {
        double valor_casa;
        double salario;
        int anos;

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-= Simulação de Empréstimo Bancário -=-=-=-=-=-=-=-=-=-=-=\n");
       while (true)
        {
            Console.Write("\n>Digite o valor do imóvel R$:");
            string casa = Console.ReadLine();
            if (double.TryParse(casa, out valor_casa) && valor_casa > 0){
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um valor 'real'!\n");
            }
        }
       while (true)
        {
            Console.Write("\n>Digite o salário atual R$:");
            string s = Console.ReadLine();
            if (double.TryParse(s, out salario) && salario > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um valor 'real'!\n");
            }
        }
       while (true)
        {
            Console.Write("\n>Digite em quantos anos deseja financiar o imóvel: ");
            string a = Console.ReadLine();
            if (int.TryParse(a, out anos) && anos > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava um valor 'inteiro'!\n");
            }
        }

        double prestacao = valor_casa / (anos * 12);

        if (prestacao > 0.30 * salario)
        {
            Console.Clear();
            Console.Write($"\n>Empréstimo negado!\n" +
                $">A prestação mensal de R${prestacao:F2} excede 30% do seu salário!\n");
        }
        else
        {
            Console.Clear();
            Console.Write($"\n>Parabéns seu empréstimo foi aceito!\n>Parcelas em {anos*12}x de R${prestacao:F2} ao total de {anos} anos.\n\n");
        }

    }
}