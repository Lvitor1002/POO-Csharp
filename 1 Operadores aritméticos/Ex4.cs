

// Crie um programa que leia quanto dinheiro uma pessoa tem na carteira e (mostre quantos dólares ela pode comprar).
// Não é apenas converter.
//dolar atual 01/2025: 6,17
// valor/6.17

using System;
class Treino

{
    static void Main()
    {
        double valor;

        Console.Clear();
        while (true)
        {
            Console.Write(">Digite o seu valor atual:\n('Valor que possui em carteira para compra de $Dolar')\n");
            string v = Console.ReadLine();

            if (double.TryParse(v, out valor) && valor != 0){
                Console.Clear();
                Console.Write($">Com R${valor:F2} Reais você pode comprar ${valor/6.17:F2} Dolares..\n\n");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Valor de entrada inválido!\n");
            }
        }
    }
    
}