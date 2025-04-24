
/*
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. 

Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. 

Ao final, mostrar a listagem atualizada dos funcionários.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. 
Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.
*/

using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

class Employee
{
    //Atributos private & Propriedades autoimplementadas
    private string _nome;
    public int ID { get; private set; }
    public double Salario { get; private set; }

    
    public string Nome  //Propriedade autoimplementada apenas para NOME 
    {
        get { return _nome; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nome = value;
            }
            else
            {
                throw new ArgumentException(">Nome não pode ser nulo!");
            }
        }
    }

    public Employee(string nome, int id, double salario)  //Construtor
    {
        Nome = nome;
        ID = id;
        Salario = salario;
    }

    //Métodos 
    public void AumentoSalarial(double porcentagem)
    {
        Salario *= (1 + porcentagem/100);
    }

    //Exibir
    public void Descricao()
    {
        Console.WriteLine($">ID: {ID}");
        Console.WriteLine($">Nome: {Nome}");
        Console.WriteLine($">Salário: R${Salario:F2}");
    }

}

class Treino
{
    static void Main()
    {
        Exibir();
    }
    static List<Employee> Leitura()
    {
        string nome;
        int id, N = 0;
        double salario=0;
        var funcionarios = new List<Employee>();

        while (true)
        {
            Console.Write(">Digite quantos funcionários serão cadastrados: ");
            string entrada0 = Console.ReadLine();
            if (int.TryParse(entrada0, out N) && N > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' válido e maior que zero!");
            }
        }

        

        for (int i = 0; i < N; i++)
        {
            Console.Clear();

            Console.Write($"{i+1}ª Funcionário: ");
            while (true)
            {
                Console.Write("\n>Digite o nome do funcionário: ");
                nome = Console.ReadLine().Trim().ToLower();
                if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
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
                Console.Write(">Digite o id do funcionário: ");
                string entrada1 = Console.ReadLine();
                if (int.TryParse(entrada1, out id) && id > 0)
                {
                    if (!funcionarios.Any(f => f.ID == id))// Verifica se o ID já existe
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um id válido e 'EXCLUSIVO' maior que zero!");
                }
            }
            while (true)
            {
                Console.Write(">Digite o salário do funcionário: ");
                string entrada2 = Console.ReadLine();
                if (double.TryParse(entrada2, out salario) && salario > 0)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real' válido e maior que zero!");
                }
            }
            funcionarios.Add(new Employee(nome, id, salario));
        }
        return funcionarios;
    }

    static void Exibir()
    {

        var funcionarios = Leitura();
        int escolhaId;
        double porcentagem;

        Employee funcionarioEscolhido = null;

        Console.Clear();
        Console.WriteLine("{0,-5} | {1,-20} | {2,10}", "ID", "Nome", "Salário");
        Console.WriteLine("--------------------------------------------------------");
        foreach (var f in funcionarios)
        {
            Console.WriteLine("{0,-5} | {1,-20} | {2,10:F2}", f.ID, f.Nome, f.Salario);
        }
        Console.WriteLine("--------------------------------------------------------");

        while (true)
        {
            Console.Write(">Escolha um id para o aumento de salário do funcionário: ");
            string op = Console.ReadLine();
            if (int.TryParse(op, out escolhaId) && escolhaId > 0)
            {
                funcionarioEscolhido = funcionarios.Find(f => f.ID == escolhaId);

                if (funcionarioEscolhido != null){
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\n>ID's disponíveis: [{string.Join(", ", funcionarios.Select(f => f.ID))}].\n");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um id válido e 'EXCLUSIVO' maior que zero!");
                
                Console.WriteLine($"\n>ID's disponíveis: [{string.Join(", ", funcionarios.Select(f => f.ID))}].\n");
            }
        }
        while (true)
        {
            Console.Write($">Em quantos % deseja aumentar o salário do funcionário {funcionarioEscolhido.Nome}? ");
            string op1 = Console.ReadLine();
            if (double.TryParse(op1, out porcentagem) && porcentagem > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real' válido e maior que zero!");
            }
        }

        funcionarioEscolhido.AumentoSalarial(porcentagem);
        Console.Clear();

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("     Listagem atualizada dos funcionários\n");

        foreach (var f in funcionarios)
        {
            f.Descricao();
            if (f.ID == funcionarioEscolhido.ID)
            {
                Console.WriteLine($">Salário do funcionário {f.Nome} foi aumentado em {porcentagem}%.");
            }
            Console.WriteLine("\n---------------------------------------------");
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
    }
}




