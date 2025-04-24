

/*
Jogo pedra papel e tesoura
 */

using System;
using System.Linq;
using System.Globalization;

class Treino
{
    static void Main()
    {
        
        while (true)
        {
            string escolha_jogador;

            Console.WriteLine("-=-=-= Jogo pedra, papel e tesoura -=-=-=\n");
            while (true)
            {
                
                Console.Write("\n>Digite: Pedra, Papel ou Tesoura: ");
                escolha_jogador = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(escolha_jogador) && !escolha_jogador.Any(char.IsDigit) && 
                    (escolha_jogador == "pedra" || escolha_jogador == "tesoura" || escolha_jogador == "papel"))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Esperava um nome em formato 'string' como; 'pedra, papel ou tesoura'!\n");
                }
            }
        
            string[] opcoes = { "pedra", "papel", "tesoura" };
            Random sorteio = new Random();


            Console.Clear();

            // Sorteia um índice aleatório dentro do intervalo do array
            string escolha_maquina = opcoes[sorteio.Next(0, opcoes.Length)];// Obtém o nome correspondente ao índice sorteado

            Console.Write($"\n>Máquina escolheu: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(escolha_maquina)}\n" +
                $">Usuário escolheu: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(escolha_jogador)}\n");

            if (escolha_jogador == escolha_maquina)
            {
                Console.WriteLine($">Mesma esolha!\n>Tente novamente!\n");
                
            }
            else if ((escolha_jogador == "pedra" && escolha_maquina == "tesoura") || (escolha_jogador == "papel" && escolha_maquina == "pedra") || (escolha_jogador == "tesoura" && escolha_maquina == "papel"))
            {
                Console.WriteLine("\n>Parabéns! Você ganhou!\n");
            }
            else
            {
                Console.WriteLine("\n>Que pena! A máquina ganhou!\n");
            }

            Console.Write(">Deseja continuar? [Sim][Não]\n");
            string op = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(op))
            {
                if (op == "sim")
                {
                    Console.Clear();
                    continue;
                }
                else if (op == "não")
                {
                    Console.WriteLine("\nSaindo..!\n");
                    break;
                }
            }
        }
    }
}