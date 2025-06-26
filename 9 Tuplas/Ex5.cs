

/* 
Crie um programa que tenha uma tupla com várias palavras (não usar acentos). 
Depois disso, você deve mostrar, para cada palavra, quais são as suas vogais.
*/

using System;
using System.Linq;


class Treino
{
    static void Main()
    {
        string[] palavras = {"pastel", "sabonete", "panela", "piada", "pernambuco",
                            "cachorro", "tabuada", "paraguai", "esquecido"};

        char[] vogais = { 'a', 'e', 'i', 'o', 'u' }; //Lista do tipo CHAR, por isso foi usado var no início

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine($"Palavras   | Vogais");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        foreach (var pa in palavras)
        {
            var vogais_palavra = pa.Where(vo => vogais.Contains(vo)).Distinct().OrderBy(x => x).ToArray();//É uma expressão lambda usada para definir a condição de filtragem.
                                                                                                                         //vogais.Contains(c) verifica se o caractere c está presente na coleção vogais,
                                                                                                                         //que é um array contendo as vogais { 'a', 'e', 'i', 'o', 'u' }.

            Console.WriteLine($"{pa,-10} | {string.Join(", ", vogais_palavra)}");
        }
        Console.WriteLine("\n-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    }
}
