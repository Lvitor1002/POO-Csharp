


/*
Crie um programa onde 4 jogadores com seus nomes joguem um dado e tenham resultados aleatórios. 
Guarde esses resultados em um dicionário em c#. No final, coloque esse dicionário em ordem, 
sabendo que o vencedor tirou o maior número no dado.
*/

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Treino
{
    static void Main()
    {
        while (true)
        {
            var (jogadores, lista_vencedores) = Dados();
            Exibir(jogadores, lista_vencedores);

            while (true)
            {
                Console.Write(">Deseja um novo sorteio? [s/n]: ");
                string op = Console.ReadLine().Trim().ToLower();
                if (op == "s")
                {
                    Console.Clear();
                    break;
                }
                else if (op == "n")
                {
                    Console.Clear();
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida! Digite apenas 's' ou 'n'!");
                }
            }
        }
    }

    static (Dictionary<string, int> jogadores, List<string> lista_vencedores) Dados()
    {
        var jogadores = new Dictionary<string, int>();
        var lista_vencedores = new List<string>();

        string nome;
        int numero_sorteado = 0;
        int vencedor = int.MinValue;
        Random sorteio = new Random();

        for (int i = 0; i < 4; i++)
        {
            Console.Clear();
            Console.WriteLine($"{i + 1}ª Jogador -------------");
            while (true)
            {
                Console.Write(">Digite o seu nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;

                }
                else if (jogadores.ContainsKey(nome))
                {
                    Console.Clear();
                    Console.WriteLine($">Entrada inválida! Digite um nome válido ou diferente de {nome}, já digitado!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }
            numero_sorteado = sorteio.Next(1, 7);

            jogadores[nome] = numero_sorteado;
            if (numero_sorteado > vencedor)
            {
                vencedor = numero_sorteado;
                lista_vencedores = new List<string> { nome };

            }
            else if (numero_sorteado == vencedor)
            {
                lista_vencedores.Add(nome); //Se o vencedor tirar o maior número então...
            }
        }
        return (jogadores, lista_vencedores);
    }

    static void Exibir(Dictionary<string, int> jogadores, List<string> lista_vencedores)
    {
        Console.Clear();
        Console.WriteLine("\n>Alunos cadastrados:\n");
        foreach (var jogador in jogadores.OrderByDescending(x => x.Value))
        {
            Console.WriteLine($">{jogador.Key}\n" +
                                $">Número sorteado: {jogador.Value}\n" +
                                $"-------------------------------------\n");
        }
        Console.WriteLine($">Vencedor(es): {string.Join(", ", lista_vencedores)} com o maior número!\n");
        Console.WriteLine("---------------------------------------\n");
    }
}

