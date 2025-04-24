

/*
Crie um programa onde o usuário digite uma expressão qualquer que use parênteses. 
Seu aplicativo deverá analisar se a expressão passada está com os parênteses abertos e 
fechados na ordem e quantidade correta.
*/


using System;



class Treino
{
    static void Main()
    {
        int contador = 0;
        Console.Write("\n>Digite uma expressão qualquer: ");
        string exp = Console.ReadLine().Trim();

        foreach(char c in exp)
        {
            if (c == '(')
            {
                contador++; //Quantidade de parênteses abertos
            }
            else if(c == ')')
            {
                contador --; //Parênteses fechados

                // Verifica se há mais parênteses fechados do que abertos até o momento
                if (contador < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Expressão inválida: parênteses fechados fora de ordem.");
                    return; 
                }
            }
        }

        // Verifica se todos os parênteses abertos foram fechados
        if (contador == 0)
        {
            Console.Clear();
            Console.WriteLine("Expressão válida: todos os parênteses estão balanceados.");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Expressão inválida: existem parênteses não fechados.");
        }
    }
}

