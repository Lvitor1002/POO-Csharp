
/*
 Escreva um programa que leia a velocidade de um carro. 
Se ele ultrapassar 80Km/h, mostre uma mensagem dizendo que ele foi multado. 
A multa vai custar R$7,00 por cada Km acima do limite.
 */


using System;



class Treino
{
    static void Main()
    {

        int velocidade;

        while (true)
        {
            Console.Write("\n>Digite a velocidade atual do carro: ");
            string v = Console.ReadLine();
            if(int.TryParse(v, out velocidade) && velocidade > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida. Esperava um número 'inteiro'!\n");
            }
        }
        Console.Clear();
        Console.Write("\n>Velociade máxima parmitida da via é de 80KM/h!\n");

        if (velocidade > 80)
        {
            
            Console.Write($"\n>Velociade atual: {velocidade}KM/h\n" +
                $">Você foi multado!\n" +
                $">Valor da multa: R${(velocidade - 80)*7} reais.\n\n");
        }
        else
        {
            Console.Write($"\n>Velociade atual: {velocidade}KM/h\n\n" +
                $">Siga viagem!\n");
        }
    }
}