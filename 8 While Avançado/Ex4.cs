
/*
Crie um programa que simule o funcionamento de um caixa eletrônico. 
No início, pergunte ao usuário qual será o valor a ser sacado (número inteiro)
e o programa vai informar quantas cédulas de cada valor serão entregues.
OBS: considere que o caixa possui cédulas de R$50, R$20, R$10 e R$1.
 */


using System;

class Treino
{
    static void Main()
    {
        int valor, cedula50 = 0, cedula20 = 0, cedula10 = 0, cedula1 = 0;

        Console.Write("\n\t-=-= Caixa eletrônico -=-=\n");
        while (true)
        {
            Console.Write("\n>Digite o valor que deseja sacar: R$ ");
            string v = Console.ReadLine();
            if (int.TryParse(v, out valor) && valor > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write("\n>Entrada inválida! Esperava um número 'inteiro'\n");
            }
        }

        if (valor >= 50)
        {
            cedula50 = valor / 50; // Calcula quantas cédulas de R$50 são necessárias dividindo o valor total por 50.
            valor %= 50;          // Atualiza o valor restante usando o operador de módulo (resto da divisão por 50).
        }
        if (valor >= 20)
        {
            cedula20 = valor / 20; 
            valor %= 20;          
        }
        if (valor >= 10)
        {
            cedula10 = valor / 10; 
            valor %= 10;          
        }
        if (valor >= 1)
        {
            cedula1 = valor / 1;  // Calcula quantas cédulas de R$1 são necessárias dividindo o valor restante por 1.
                                  // Não é necessário atualizar 'valor' aqui, pois este é o menor valor de cédula disponível.
        }

        Console.WriteLine($"\nVocê receberá >\n{cedula50} notas de 50\n" +
            $"{cedula20} notas de 20\n" +
            $"{cedula10} notas de 10\n" +
            $"{cedula1} notas de 1\n");
    }
}

