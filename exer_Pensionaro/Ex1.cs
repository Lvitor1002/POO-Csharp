
/*
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.

Quando um estudante deseja alugar um quarto, deve-se registrar; 
                                                               o nome
                                                               e email 
deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios. 
E pergunte quantos quartos serão alugados.

Para cada registro de aluguel, informar; 
                                        o nome 
                                        e email 
do estudante, bem como qual dos quartos ele escolheu (de 0 a 9). 

Suponha que seja escolhido um quarto vago. 
Ao final, seu programa deve imprimir um relatório de todas ocupações do pensionato, por ordem de quarto.
*/

using System;
using System.Globalization;
using System.Linq;

class Pensionato
{
    //Atributos private 
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public int NumeroQuarto { get; private set; }


    //Construtor
    public Pensionato(string nome, string email, int numeroQuarto)
    {
        Nome = nome;
        Email = email;
        NumeroQuarto = numeroQuarto;
    }

}

class Treino
{
    static void Main()
    {
        var pensionato = Leitura();
        Exibir(pensionato);
    }
    static Pensionato[] Leitura()
    {
        var quartos = new Pensionato[10];

        int numeroQuarto, qtdQuarto;
        string nome, email;

        Console.Write(">Quantos quartos serão alugados? De 0 à 9: ");
        while (true)
        {
            string qtdQ = Console.ReadLine().Trim();
            if (int.TryParse(qtdQ, out qtdQuarto) && qtdQuarto >= 0 && qtdQuarto <= 9)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' de 0 à 9!");
            }
        }

        for (int i = 0; i < qtdQuarto; i++)
        {
            Console.Clear();
            Console.WriteLine($"{i + 1}ª Aluguel ");
            while (true)
            {
                Console.Write(">Digite o nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (nome.All(c => char.IsLetter(c) || c == ' '))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um nome válido!");
                }
            }

            while (true)
            {
                Console.Write(">Digite o email: ");
                email = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(email))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um email válido!");
                }
            }
            while (true)
            {
                Console.Write(">Digite o número do quarto escolhido: De 0 à 9: ");
                string nquarto = Console.ReadLine().Trim();
                if (int.TryParse(nquarto, out numeroQuarto) && numeroQuarto >= 0 && numeroQuarto <= 9)
                {
                    if (quartos[numeroQuarto] == null)// Verifica se o quarto está disponível
                    {
                        Console.WriteLine(">Este quarto já está ocupado. Escolha outro.");
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um número 'inteiro' de 0 à 9!");
                }
            }
            quartos[numeroQuarto] = new Pensionato(nome, email, numeroQuarto);
        }
        return quartos;
    }
    static void Exibir(Pensionato[] quartos)
    {
        Console.Clear();
        Console.WriteLine("--==--== Quartos Ocupados ==--==--\n");

        for (int i = 0; i < quartos.Length; i++)
        {
            if (quartos[i] != null)
            {
                Console.WriteLine($"Quarto {i}\n" +
                                  $"Nome do Ocupante: {quartos[i].Nome}\n" +
                                  $"\t\tEmail: {quartos[i].Email}\n" +
                                  $"\t\tNº Quarto: {quartos[i].NumeroQuarto}\n");
            }
        }
        Console.WriteLine("--==--==--==--==--==--==--==--==--");
    }

}




