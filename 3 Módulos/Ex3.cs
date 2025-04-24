
/* 
 Um professor quer sortear um dos seus quatro alunos para apagar o quadro. Faça um programa que ajude ele, 
lendo o nome dos alunos e escrevendo na tela o nome do escolhido.
*/

using System;
using System.Linq;

class Treino
{
    static void Main()
    {
        string[] nomes = Leitura();

        while (true)
        {
            Console.Clear();
            Console.Write(new string('~', 50));
            Console.Write("\n\t\t  Nomes: \n\n");
            foreach (var n in nomes)
            {
                Console.Write($">{Maiusculo(n)}\n");
            }
            string nome_sorteado = Sorteio(nomes); // Realiza o sorteio novamente dentro do loop

            Console.WriteLine($">Nome sorteado: {Maiusculo(nome_sorteado)}");
            Console.Write(new string('~', 50));

            string op;
            while (true) // Loop para garantir entrada válida
            {
                Console.Write("\n>Deseja continuar? [Sim][Não]?\n");
                op = Console.ReadLine().ToLower().Trim();

                if (string.IsNullOrWhiteSpace(op) || op.Any(char.IsDigit) || (op != "sim" && op != "não"))
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida! Digite apenas 'sim' ou 'não'.\n");
                }
                else
                {
                    break; // Entrada válida, saia do loop
                }
            }

            if (op == "sim")
            {
                Console.Clear();
                Console.WriteLine("Novo Sorteio!!"); // Precisa do 1 segundo para ficar visível
                System.Threading.Thread.Sleep(1000);
                continue;
            }
            else if (op == "não")
            {
                Console.Clear();
                Console.WriteLine("Encerrando o programa...");
                System.Threading.Thread.Sleep(1000);
                break;
            }
        }
    }

    static string[] Leitura()
    {
        /*Tamanho Fixo vs. Tamanho Dinâmico
         * 
         ARRAYS: O tamanho de um array é fixo. Após sua criação, não é possível alterar o número de elementos. 
        Você deve definir o tamanho do array no momento da sua criação

         LISTAS: Uma lista (por exemplo, List<T> em C#) tem um tamanho dinâmico. 
        Você pode adicionar ou remover elementos a qualquer momento, e a estrutura se ajusta automaticamente
        */

        string[] nomes = new string[4];  // Array de 4 posições

        Console.Write(">Digite 4 nomes abaixo:\n");
        for (int i = 0; i < nomes.Length; i++)
        {
            while (true)
            {
                Console.Write($">{i + 1}ª nome: ");
                string nome = Console.ReadLine().ToLower().Trim();

                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
                {
                    nomes[i] = nome;
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida! Esperava um 'nome' em 'string'..\n\n");
                }
            }
        }
        return nomes;
    }

    static string Sorteio(string[] nomes)
    {
        Random rand = new Random();
        int indice_sorteado = rand.Next(0, nomes.Length);

        return nomes[indice_sorteado];
    }

    static string Maiusculo(string nomes)
    {
        if (string.IsNullOrWhiteSpace(nomes)) ////verifica se a string alunos está nula, vazia ou contém apenas espaços em branco
        {
            return nomes;
        }
        //Ele pega o primeiro caractere do nome e o converte para maiúsculo com char.ToUpper(nome[0]).
        //Em seguida, ele pega o restante do nome com nome.Substring(1) e o converte para minúsculo com ToLower().
        return char.ToUpper(nomes[0]) + nomes.Substring(1).ToLower();
        
    }
}