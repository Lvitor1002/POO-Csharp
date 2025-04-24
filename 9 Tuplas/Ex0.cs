
/* 
Crie um programa que tenha uma tupla totalmente preenchida com uma contagem por extenso, de zero até vinte. 
Seu programa deverá ler um número pelo teclado (entre 0 e 20) e mostrá-lo por extenso.
*/


using System;

class Treino
{
    static void Main()
    {
        //Usando array, pois o conteúdo é limitada e estático.

        string[] tupla = {"zero", "um", "dois", "três", "quatro",
            "cinco", "seis", "sete", "oito", "nove",
            "dez", "onze", "doze", "treze", "quatorze",
            "quinze", "dezesseis", "dezessete", "dezoito",
            "dezenove", "vinte"};

        int numero;

        while (true)
        {
            Console.Write("\n>Digite um número: ");
            string n = Console.ReadLine();
            if(int.TryParse(n, out numero) && numero >= 0 && numero <= 20)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Entrada inválida! Esperava-se um número inteiro de 0 à 20!");
            }
        }
        Console.Clear();
        Console.WriteLine($"\n>Número: {numero} - {tupla[numero].ToUpper()}");
    }
}

