

/*
Faça um programa que ajude um jogador da MEGA SENA a criar palpites.
O programa vai perguntar quantos jogos serão gerados e vai sortear 6 números entre 1 e 60 para cada jogo, 
cadastrando tudo em uma lista composta.
*/

using System;
using System.Collections.Generic;

class Treino
{
    static void Main()
    {
        var (palpites, jogos) = Dados();
        Exibir(palpites, jogos);
    }
    static (List<List<int>> palpites, int jogos) Dados()
    {
        var palpites = new List<List<int>>();
        
        Random sorteio = new Random();
        int jogos;

        Console.Write(">Quantos jogos ao todo serão gerados? ");
        while(true){
            string jo = Console.ReadLine();
            if(int.TryParse(jo, out jogos) && jogos > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' positivo maior que zero!");
            }
        }

        for(int i = 0; i<jogos; i++)
        {
            /*Evita a necessidade de verificar manualmente se um número já está presente na coleção antes de adicioná - lo. */
            var numeros_sorteados = new HashSet<int>(); //Lista temporária contendo os números de 1 à 60 sem repetilos

            while (numeros_sorteados.Count < 6)
            {
                numeros_sorteados.Add(sorteio.Next(1, 61));
            }
            palpites.Add(new List<int>(numeros_sorteados));
        }
        return (palpites, jogos);
    }

    static void Exibir(List<List<int>> palpites, int jogos)
    {
        Console.Clear();

        Console.WriteLine($"-=-=-= Sorteio da Mega sena -=-=-=\n\n" +
                          $">Foram ao todo {jogos} jogos: ");
        for(int i = 0; i < palpites.Count; i++)
        {
            Console.WriteLine($"\n{i+1}ª Palpite: {string.Join(", ", palpites[i]),4}");
        }
        Console.WriteLine($"\n-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n\n");
    }
}


