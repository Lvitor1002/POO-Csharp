
/*
 O mesmo professor do desafio 019 quer sortear a ordem de apresentação de trabalhos dos alunos. 
Faça um programa que leia o nome dos quatro alunos e mostre a ordem sorteada.
*/

using System;
using System.Linq;

class Treino
{
    static void Main()
    {
        string[] alunos = leitura();
        
        while (true)
        {

            //Programa começa aqui
            string[] alunos_sorteados = sorteio(alunos);

            Console.Clear();
            Console.Write(">Ordem de sorteio dos alunos:\n");
            for (int i = 0; i < alunos_sorteados.Length; i++)
            {
                Console.Write($">{i+1}ª: {alunos_sorteados[i]}\n");
            }

            string op;
            while (true)
            {
                Console.Write(">Deseja um novo sorteio com os mesmos? [Sim][Não]\n");
                op = Console.ReadLine().Trim().ToLower();
                if (op == "sim" || op == "não")
                {
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida! Espereva uma 'string', 'Sim' ou 'Não'!\n\n");
                }

            }
            
            if (op == "não")
            {
                break;
            }
          
        }
        
    }

    static string[] leitura()
    {
        string[] aluno = new string[4];

        Console.WriteLine(">Digite 4 nomes abaixo: ");
        for (int i = 0; i<aluno.Length; i++)
        {
            
            while (true)
            {
                Console.Write($">{i + 1}ª: ");
                string nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit)){
                    aluno[i] = capitalize(nome);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava uma 'string'!\n");
                    
                }
            }
        }
        return aluno;
        
    }

    // Aqui o método recebe um array de 'leitura()' e retorna uma array para ser usado em main()
    static string[] sorteio(string[] alunos)
    {
        Random n = new Random();
        string[] copia_alunos = (string[])alunos.Clone(); // Cria uma cópia do array para evitar modificar o original

        for (int i = copia_alunos.Length - 1; i>0; i--)
        {
            int indice_aleatorio = n.Next(i + 1); //[Next(i + 1)] - exemplo, se i for 3, portanto, o método Next(4). Gerará então um número aleatório entre 0 e 3
            string troca = copia_alunos[i]; //Aqui, o valor do elemento atual (localizado no índice i) do array alunos é armazenado [temporariamente] na variável 'troca'.

            copia_alunos[i] = copia_alunos[indice_aleatorio];
            copia_alunos[indice_aleatorio] = troca; //Aqui, o valor temporário armazenado em 'troca' (que era o valor original de alunos[i]) é atribuído ao índice indice_aleatorio.
        }
        
        return copia_alunos;
    }

    static string capitalize(string alunos) 
    {
        if (string.IsNullOrWhiteSpace(alunos)) //verifica se a string alunos está nula, vazia ou contém apenas espaços em branco
        {
            return alunos;
        }
        else
        {
            //Ele pega o primeiro caractere do nome e o converte para maiúsculo com char.ToUpper(nome[0]).
            //Em seguida, ele pega o restante do nome com nome.Substring(1) e o converte para minúsculo com ToLower().
            return char.ToUpper(alunos[0]) + alunos.Substring(1).ToLower();
        }
    }
    
}