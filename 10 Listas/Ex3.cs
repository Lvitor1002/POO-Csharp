

/*
Crie um programa que vai ler vários números e colocar em uma lista. 
Depois disso, crie duas listas extras que vão conter apenas os valores pares e os valores ímpares digitados, 
respectivamente. 
Ao final, mostre o conteúdo das três listas geradas.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Server;

class Treino
{
    static void Main()
    {
        var lista_original = Leitura();
        var (lista_par, lista_impar) = ListasExtras(lista_original);
        ExibirListas(lista_original, lista_par, lista_impar);
    }
    static List<int> Leitura()
    {
        var valores = new List<int>();
        int valor;

        
        Console.WriteLine(">Digite abaixo alguns valores 'inteiros'.\n>Para interromper digite 'sair'.");
        while (true)
        {
            Console.Write(">Valor: ");
            string v = Console.ReadLine().Trim().ToLower();
            
            if (v == "sair")
            {
                break;
            }
            else if (int.TryParse(v, out valor) && valor >= 0)
            {
                valores.Add(valor);
                
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo ou 'sair'!");
            }
            
        }
        return valores;
    }
    static (List<int> lista_par, List<int> lista_impar) ListasExtras(List<int> valores)
    {
        var lista_par = new List<int>();
        var lista_impar = new List<int>();

        if (valores.Count > 0)
        {
            foreach (var valor in valores)
            {
                if (valor % 2 == 0)
                {
                    lista_par.Add(valor);   
                }else if(valor % 2  != 0)
                {
                    lista_impar.Add(valor);
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(">Lista vazia!");
        }
        return (lista_par, lista_impar);
    }

    static void ExibirListas(List<int> valores, List<int> lista_par, List<int> lista_impar)
    {
        Console.Clear();

        Console.WriteLine($">Lista Original: {string.Join(", ",valores.OrderBy(x => x))}.\n");

        if(lista_par.Count > 0)
        {
            Console.WriteLine($">Valores Pares: {string.Join(", ", lista_par.OrderBy(x => x))}.\n");
        }
        if(lista_impar.Count > 0)
        {
            Console.WriteLine($">Valores Ímpares: {string.Join(", ", lista_impar.OrderBy(x => x))}.\n");
        }
    }
}
