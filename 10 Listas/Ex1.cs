

/*
Crie um programa onde o usuário possa digitar vários valores numéricos e cadastre-os em uma lista. 
Caso o número já exista lá dentro, ele não será adicionado. 
No final, serão exibidos todos os valores únicos digitados, em ordem crescente. 
*/


using System;
using System.Collections.Generic;


class Treino
{
    static void Main()
    {
        var valores = Leitura();

        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
        Console.WriteLine($">Valores: {string.Join(", ",valores)}.");
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n");
    }
    static List<int> Leitura()
    {
        var valores = new List<int>();
        int valor;

        Console.WriteLine(">Digite alguns valores inteiros..\n>Para finalizar, digite 'sair'");
        while (true)
        {
            string v = Console.ReadLine().Trim().ToLower();
            if(v == "sair")
            {
                break;
            }
            else if(int.TryParse(v, out valor) && valor >= 0)
            {
                if (valores.Contains(valor))
                {
                    Console.Clear();
                    Console.WriteLine($">Valor '{valor}' já adicionado!");
                }
                valores.Add(valor);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida! Digite um número 'inteiro' positivo ou 'sair'!\n");
            }
        }
        return valores;
    }
}
