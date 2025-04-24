
/*
 Desenvolva um programa que leia o nome, idade e sexo de 4 pessoas. 
No final do programa, mostre: a média de idade do grupo, 
qual é o nome do homem mais velho e quantas mulheres têm menos de 20 anos.
 */


using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;


class Treino
{
    static void Main()
    {
        var(pessoas, media, qtd_mulheres, homem_velho) = Dados();

        Console.Clear();
        Console.WriteLine(new string('~', 30));
        Console.Write("Pessoas cadastrada:\n");

        foreach (var pessoa in pessoas){
            Console.Write($"\n>Nome: {pessoa.Nome}\n>Sexo: {pessoa.Sexo}\n>Idade: {pessoa.Idade}\n");
        }
        Console.WriteLine(new string('~', 30));

        Console.Write($">Média de idade do grupo: {media}\n");
        Console.Write($">Homem mais velho: {homem_velho}\n");
        Console.Write($">{qtd_mulheres} Mulheres tem menos 20 anos\n");
        Console.WriteLine(new string('~', 30));
    }


    // Irá receber uma classe Pessoa que está logo abaixo. Isso para organizar
    static (Pessoa[] pessoas, int media, int qtd_mulheres, string homem_velho) Dados()         
    {
        Pessoa[] pessoas = new Pessoa[4]; /*
                                           Aqui, é criado um array de 4 posições para armazenar os dados de 4 pessoas. 
                                           Cada posição do array será preenchida com um objeto do tipo Pessoa.
                                           */
        int soma_idade = 0;
        int qtd_mulheres = 0;
        int idade_homem_velho = 0;
        string homem_velho = null;

        for (int i=0; i<4; i++)
        {
            string sexo;
            string nome;
            int idade;
            

            Console.Write($"------------- {i + 1}ª Pessoa --------------\n");
            while (true)
            {
                Console.Write(">Digite um nome: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && !nome.Any(char.IsDigit))
                {
                    nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava uma 'string'!\n");
                }
            }
            while (true)
            {
                Console.Write($">Digite o sexo de {nome} | [M] ou [F]: ");
                sexo = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(sexo))
                {
                    if (sexo == "m" || sexo == "f")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write(">Entrada inválida. Esperava sexo 'M' OU 'F'!\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava uma 'string'!\n");
                }
            }
            while (true)
            {
                Console.Write($">Digite a idade de {nome}: ");
                string string_idade = Console.ReadLine();
                if (int.TryParse(string_idade, out idade) && idade > 0)
                {
                    
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.Write(">Entrada inválida. Esperava um número 'inteiro'!\n");
                }
            }
            soma_idade += idade;

            if (sexo == "f" && idade < 20)
            {
                qtd_mulheres += 1;
            }

            if (sexo == "m" && idade > idade_homem_velho)
            {
                idade_homem_velho = idade;
                homem_velho = nome;
            }

            pessoas[i] = new Pessoa { Nome = nome, Sexo = sexo, Idade = idade };
        }

        int media = soma_idade / 4;

        return (pessoas, media, qtd_mulheres, homem_velho ?? "Nenhum homem foi cadastrado"); // Isso será retornada para ser usado em Main();
    }
    

    // Está por último pois se colar antes de Dados() não será reconhecido os atributos NOME, SEXO E IDADE
    class Pessoa
    {
        public string Nome { get; set; } //leitura (get) e escrita (set).
        public string Sexo { get; set; }
        public int Idade { get; set; }
    }
}