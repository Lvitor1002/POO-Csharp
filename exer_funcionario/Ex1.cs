
/*
 
Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada na imagem.

 */

using System;
using System.Globalization;
using System.Linq;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }
    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }

}

class Treino
{
    static void Main()
    {
        Funcionario funcionario = Leitura();
        Exibir(funcionario);
    }
    static Funcionario Leitura()
    {
        Funcionario func = new Funcionario();
        string nome;
        double salarioBruto = 0, imposto = 0;

        Console.Write(">Digite o seu nome: ");
        while (true)
        {
            nome = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(nome) && nome.All(c => char.IsLetter(c) || c == ' '))
            {
                func.Nome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um nome válido!");
            }
        }
        Console.Write($">{func.Nome}, agora digite o salário bruto atual R$: ");
        while (true)
        {
            string entrada1 = Console.ReadLine().Trim();
            if (double.TryParse(entrada1, out salarioBruto) && salarioBruto > 0)
            {
                func.SalarioBruto = salarioBruto;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', válido!");
            }
        }
        Console.Write($">{func.Nome}, agora digite o valor do imposto atual: ");
        while (true)
        {
            string entrada2 = Console.ReadLine().Trim();
            if (double.TryParse(entrada2, out imposto) && imposto > 0)
            {
                func.Imposto = imposto;
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', válido!");
            }
        }
        return func;
    }
    static void Exibir(Funcionario func)
    {
        double porcentagem = 0;

        Console.Clear();
        Console.WriteLine($"> Nome do Funcionário: {func.Nome}\n" +
                          $"> Salário Líquido: R${func.SalarioLiquido():F2}\n");

        Console.Write(">Deseja aumentar o salário? [s/n]: ");
        while (true)
        {
            string resposta = Console.ReadLine().ToLower().Trim();
            if(resposta == "s")
            {
                Console.Clear();
                Console.Write(">Em qual porcentagem? Digite a desejada, %:");
                string por = Console.ReadLine().Trim();
                if(double.TryParse(por, out porcentagem) && porcentagem > 0)
                {
                    func.AumentarSalario(porcentagem);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(">Entrada inválida. Digite um valor 'inteiro' ou 'real', válido!");
                }
            } else if(resposta == "n")
            {
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
            }
        }
        Console.WriteLine($"> Aumento do salário aplicado!\n> Novo Salário Líquido: R${func.SalarioLiquido():F2}\n");
    }
}




