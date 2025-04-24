

/*
 Faça um programa que leia o comprimento do cateto oposto e do cateto adjacente de um triângulo retângulo. 
Calcule e mostre o comprimento da hipotenusa.
*/

using System;

class Treino
{
    static void Main()
    {
        var (cateto_ad, cateto_op, comprimento_hip) = Calculo();
        
        Console.Clear();
        Console.Write($"\n>Cateto Oposto: {cateto_op}\n" +
            $">Cateto Adjacente: {cateto_ad}\n" +
            $">Comprimento da Hipotenusa: {comprimento_hip:F2} \n\n");
    }
    static (double cateto_ad, double cateto_op, double comprimento_hip) Calculo()
    {
        double cateto_op;
        double cateto_ad;
        

        Console.Write("\n>Digite abaixo os valores dos..;\n\n");

        while (true)
        {
            Console.Write(">Cateto Oposto: ");
            string op = Console.ReadLine();
            if (double.TryParse(op, out cateto_op))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida, esperava um 'número'!\n\n");
            }
        }
        while (true)
        {
            Console.Write(">Cateto Adjacente: ");
            string ad = Console.ReadLine();
            if (double.TryParse(ad, out cateto_ad))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida, esperava um 'número'!\n\n");
            }
        }

        double comprimento_hip = Math.Sqrt(Math.Pow(cateto_op, 2) + Math.Pow(cateto_ad, 2));

        return (cateto_ad, cateto_op, comprimento_hip);
    }
}