
//# Faça um programa que leia um número e mostre na tela o seu sucessor e seu antecessor.

using System;

class Treino
{
    static void Main()
    {
        int numero;

        while (true) {
            Console.Clear();
            Console.WriteLine(new string('=', 20));
            Console.Write(">Digite um número: ");
            string n = Console.ReadLine();

            if (int.TryParse(n, out numero)) {
                Console.Clear();
                Console.WriteLine(new string('~', 50));
                Console.WriteLine($">Sucessor de [{numero}]: {numero+1}\n>Antecessor de [{numero}]: {numero-1}");
                Console.WriteLine(new string('~', 50));
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n>Erro, entrada inválida.\n>Tente novamente..\n");
            }

        }

    }
    
}