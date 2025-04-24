

/*
Crie um programa que leia um número Real qualquer pelo teclado e mostre na tela a sua porção Inteira.
Ex: Digite um número: 6.127
O número 6.127 tem a parte Inteira 6.
*/

using System;


class Treino
{
    static void Main()
    {
        double real;
        while (true)
        {
            
            Console.Write(">Digite um número real para conversão em inteiro: ");
            string r = Console.ReadLine();
            if (double.TryParse(r, out real)) {

                Console.Clear();
                int inteiro = (int)Math.Floor(real);

                Console.Write("\n>Conversão de valores:\n");
                Console.Write($">Número real: {real}\n>número inteiro: {inteiro}\n\n");
                break;
            }
            else
            {
                Console.Clear();
                Console.Write($">Entrada [{r}] inválida! Esperava um número!\n\n");
            }
        }
    }

}