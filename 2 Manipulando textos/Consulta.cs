using System;

class EXC
{
    static void Main()
    {
        string frase = "Curso em video python";

        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine(frase.Length);  // Tamanho da frase
        Console.WriteLine();

        // Trocando a palavra python por java
        Console.WriteLine(frase.Replace("python", "Java"));
        Console.WriteLine();

        // Trocando a palavra python por java e SALVANDO na variável:
        string newFrase = frase.Replace("python", "Jupyter");
        Console.WriteLine(newFrase);
        Console.WriteLine();

        // Do índice 3 até 13
        Console.WriteLine(frase.Substring(3, 10));
        Console.WriteLine();

        // Do índice 1 até 15, pulando de 2 em 2
        for (int i = 1; i < 15; i += 2)
        {
            Console.Write(frase[i]);
        }
        Console.WriteLine();
        Console.WriteLine();

        // Dois pontos significa a string inteira e pulando de 2 em 2
        for (int i = 0; i < frase.Length; i += 2)
        {
            Console.Write(frase[i]);
        }
        Console.WriteLine();
        Console.WriteLine();

        // Dividindo em palavras
        string[] x = frase.Split();
        Console.WriteLine($"{x[0]} {x[3]}");  // Juntando as palavras pelos índices
        Console.WriteLine();
    }
}
