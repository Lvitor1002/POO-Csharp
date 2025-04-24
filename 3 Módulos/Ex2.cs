

/*
  Faça um programa que leia um ângulo qualquer e mostre na tela o valor do seno, cosseno e tangente desse ângulo.
 */

using System;

class Treino
{
    static void Main()
    {
        var (angulo, cos, sen, tan) = Leitura();

        Console.Clear();
        Console.Write($"\n>Convertendo o ângulo {angulo:F0}º:\n\n" +
                         $">Seno de {angulo:F0}º: {sen:F2}\n" +
                         $">Cosseno de {angulo:F0}º: {cos:F2}\n");
        Console.WriteLine($">Tangente de {angulo:F0}º: {tan:F2}");




    }
    static (double angulo, double cos, double sen, double tan) Leitura()
    {
        double angulo;
        
        while (true)
        {
            Console.Write("\n>Digite o valor do Angulo: ");
            string a = Console.ReadLine();
            if (double.TryParse(a, out angulo))
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida, esperava um 'número'!\n\n");
            }
            
        }
        double radianos = Math.PI * angulo / 180;
        double cos = Math.Cos(radianos);
        double sen = Math.Sin(radianos);
        double tan = Math.Tan(radianos);

        return (angulo, cos, sen, tan);
    }
}