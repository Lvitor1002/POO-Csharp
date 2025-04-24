
/*
 Escreva um programa que faça o computador "pensar" em um número inteiro entre 0 e 5
e peça para o usuário tentar descobrir qual foi o número escolhido pelo computador. 
O programa deverá escrever na tela se o usuário venceu ou perdeu.
 */


using System;



class Treino
{
    static void Main()
    {
        Random random = new Random(); // Instância criada fora do loop para o valor ser atualizado


        while (true)
        {
            int numero_escolhido;
            int numero_sorteado;
            while (true)
            {
                Console.Write("\n>Digite um número de 0 à 5: ");
                string nu_esco = Console.ReadLine();
                if (int.TryParse(nu_esco, out numero_escolhido))
                {
                    if (numero_escolhido >= 0 && numero_escolhido <= 5)
                    {
                        break;
                    }
                    else

                    {
                        Console.Clear();
                        Console.Write(">Fora do intervalo permitido! Números permitidos: 0 à 5!\n");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida! Esperava um número 'inteiro'!\n");
                }

            }

            numero_sorteado = random.Next(0, 6);

            if (numero_escolhido == numero_sorteado)
            {
                Console.Clear();
                Console.Write($"\n>Parabéns, você acertou!\n>Sua escolha: {numero_escolhido}\n>Número sorteado: {numero_sorteado}\n");
            }
            else
            {
                Console.Clear();
                Console.Write($"\n>Desculpe, você errou!\n>Sua escolha: {numero_escolhido}\n>Número sorteado: {numero_sorteado}\n");
            }

        
            Console.Write("\n\n>Deseja continuar? [Sim][Não]\n");
            string op = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(op))
            {
                if (op == "sim")
                {
                    Console.Clear();
                    continue;
                }
                if (op == "não")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida! Esperava um 'sim' ou 'não'!\n");
                }
            }
        }
    }
}