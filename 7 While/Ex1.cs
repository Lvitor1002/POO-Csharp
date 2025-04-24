

/*
Melhore o jogo do DESAFIO 028 onde o computador vai "pensar" em um número entre 0 e 10. 
Só que agora o jogador vai tentar adivinhar até acertar, 
mostrando no final quantos palpites foram necessários para vencer.
 */

using System;
using System.Globalization;

class Treino
{
    static void Main()
    {

        
        while (true)
        {
            
            int tentativas = 0;
            int escolha_jogador;
            Console.Clear();
            while (true)
            {
                
                Random sorteio_maquina = new Random();
                int escolha_maquina = sorteio_maquina.Next(0, 11);

                Console.Write("\n>Tente advinhar um número de 0 à 10 pensado pelo computador. Digite o mesmo: ");
                string es_jo = Console.ReadLine();
                if (int.TryParse(es_jo, out escolha_jogador) && escolha_jogador >= 0 && escolha_jogador <= 10)
                {
                    Console.Clear();
                    Console.WriteLine($">Escolha Jogador:{escolha_jogador}\n>Escolha Máquina:{escolha_maquina}\n");
                    tentativas += 1;

                    if (escolha_jogador == escolha_maquina)
                    {
                        Console.WriteLine($">Jogador acertou!\nForam necessárias {tentativas} tentativas!\n");
                        break;
                    }
                    else
                    {
                        
                        Console.WriteLine("\n>Jogador Errou!");
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Escolha inválida. Esperava um número 'inteiro' de 0 à 10!\n");
                }
            }

            Console.WriteLine(">Deseja continuar? [Sim][Não]: ");
            string op = Console.ReadLine().Trim().ToLower();
            if (op == "sim")
            {
                continue;

            }else if (op == "não")
            {
                break;
            }
        }
    }
}