
//Crie um algoritmo que leia um número e mostre o seu dobro, triplo e raiz quadrada.

using System;

class Treino
{
    static void Main()
    {
        var resultado = leitura();
        Console.Clear();
        Console.Write($">Resultados do número [{resultado.numero}]:\n>Dobro: {resultado.dobro}\n>Triplo: {resultado.triplo}\n>Raiz: {resultado.raiz:F2}\n");
        
    }

    static (double numero, double dobro, double triplo, double raiz) leitura()
    {
        double numero;

        while (true)
        {
            Console.Write("\n>Digite um número: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero))
            {
                break;
            }
            else
            {
                Console.WriteLine("\n>Entrada inválida!");
            }
            

        }
        double dobro = numero * 2;
        double triplo = numero * 3;
        double raiz = Math.Sqrt(numero);

        return (numero, dobro, triplo, raiz);

    }
}