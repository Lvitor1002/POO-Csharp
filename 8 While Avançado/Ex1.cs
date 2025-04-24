


/*
Faça um programa que jogue par ou ímpar com o computador. 
O jogo só será interrompido quando o jogador não quiser mais continuar, 
mostrando o total de vitórias consecutivas que ele conquistou no final do jogo. 

O jogo deve determinar o vencedor com base na soma dos números (se é par ou ímpar), 
não na comparação direta entre as escolhas de "par" ou "impar"
 
 */


using System;
using System.Linq;
using System.Globalization;
class Treino
{
    static void Main()
    {
        
        Random sorteio = new Random();
        int vitorias = 0;
        

        while (true)
        {
            string jogador;
            
            int numero_pc = sorteio.Next(1, 6);

            Console.Clear();
            Console.WriteLine("\n-=-=-=-=-= Jogo - Ímpar | Par -=-=-=-=-=\n");

            while (true)
            {
                Console.Write("\n>Par ou Impar? Digite a sua escolha: ");
                jogador = Console.ReadLine().ToLower().Trim();
                if (!string.IsNullOrWhiteSpace(jogador) && !jogador.Any(char.IsDigit) && (jogador == "par" || jogador == "impar" || jogador == "ímpar"))
                {
                    if (jogador == "ímpar") jogador = "impar"; // Normalizar entrada
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! espereva uma 'string' 'par' 'impar'\n");
                }
            }

            int numero;
            while (true) {
                Console.Write("\nDigite agora um número de 1 à 5: ");
                string n = Console.ReadLine();
                if (int.TryParse(n, out numero) && numero > 0 && numero <= 5)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! esperava-se um número 'inteiro'!\n");
                    
                }

            }
            
            

            Console.Clear();
            Console.WriteLine($"\n>Você escolheu: '{CultureInfo.CurrentCulture.TextInfo.ToTitleCase(jogador)}'\n");
            
            int soma = numero + numero_pc;
            

            if ((soma % 2 == 0 && jogador == "par") || (soma % 2 != 0 && jogador == "impar"))
            {
                vitorias += 1;
                Console.WriteLine($"\n>Soma: {soma}\n>Parabéns, Jogador venceu!\n");
                Console.WriteLine($"..com {vitorias} vitórias consecutivas!\n");
                
            }
            else
            {
                Console.WriteLine($"\n>Soma: {soma}\n>Que pena, computador venceu!");
                vitorias = 0; // Reseta as vitórias consecutivas
            }
            
            while (true)
            {
                Console.Write("\n>Deseja continuar? [Sim][Não]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "sim")
                {
                    break;
                }
                else if (op == "não")
                {
                    Console.Clear();
                    Console.WriteLine("> Saindo...!");
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n>Entrada inválida! Esperava uma string 'Sim' ou 'Não'!\n");
                }
            }
        }
    }
}

