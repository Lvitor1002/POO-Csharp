/*
Faça um programa que leia a largura e a altura de uma parede em metros, 
calcule a sua área e a quantidade de tinta necessária para pinta-lá, 
sabendo que cada litro de tinta, pinta uma área de 2m^2.
*/

using System;

class Treino
{
    static void Main()
    {
        
        var (area, largura, altura) = CalculoArea();
        var qtd = QuantidadeTinta(area);

        Console.Clear();
        Console.WriteLine(new string('~', 50));
        Console.WriteLine($">Área da parede: {area:F2}m²\n\n>Quantidade de tinta necessária para pintar a parede: {qtd:F2} Litros");
        Console.WriteLine(new string('~', 50));
    }
    static (double area, double largura, double altura) CalculoArea()
    {
        double area;
        double largura;
        double altura;

        Console.Clear();
        while (true)
        {
            Console.Write(">Digite a largura de sua parede: ");
            string l = Console.ReadLine();
            if (double.TryParse(l, out largura) && largura != 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida!\n>Esperava um número 'inteiro ou real'..\n");
            }
        }

            while (true)
        {
            Console.Write(">Digite a altura de sua parede: ");
            string a = Console.ReadLine();
            if (double.TryParse(a, out altura) && altura != 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida!\n>Esperava um número 'inteiro ou real'..\n");
            }
        }

        area = largura * altura;
        return (area, largura, altura);
    }

    static double QuantidadeTinta(double area)
    {
        double qtd = area / 2;
        return qtd;
    }
}
