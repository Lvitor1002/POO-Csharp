
/*
Em um banco, para se cadastrar uma conta bancária, é necessário informar o 
número da conta, 
o nome do titular da conta, 
e o valor de depósito inicial que o titular depositou ao abrir a conta. 

Este valor de depósito inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).

Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. 
O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. 

Para cada saque realizado, o banco cobra uma taxa de $ 5.00. 

Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. 
Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação. 
*/

using System;
using System.Globalization;
using System.Linq;

class ContaBancaria
{
    //Atributos private & Propriedades autoimplementadas
    public int NumeroConta { get; private set; } //Pode ser acessado mas não alterado
    
    private string _nomeTitular; //Pode ser acessado e pode ser alterado
    public double Saldo { get; private set; } //Pode ser acessado mas não alterado


    //Propriedade autoimplementada apenas para NOME TITULAR
    public string NomeTitular
    {
        get { return _nomeTitular; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                _nomeTitular = value;
            }
            else
            {
                throw new ArgumentException(">Nome do titular não pode ser vazio!");
            }
        }
    }

    //Construtores
    public ContaBancaria(int numeroConta, string nomeTitular) //Construtor com 2 argumentos
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
    }
    public ContaBancaria(int numeroConta, string nomeTitular, double valorDepositoInicial) : this(numeroConta, nomeTitular) // Puxando dados do outro construtor || //Construtor com 3 argumentos
    {

        Deposito(valorDepositoInicial);
        // Valor de entrada vai direto para o método [Deposito], portanto a lógica está encapsulada no método [Deposito], tornando o código mais flexível a mudanças futuras
        // sem necessidade de criar duas lógicas como anteriormente. Neste caso apenas reutilizamos o método que já contém a lógica necessária
        // Oque for alterado no método [Deposito], refletirá automático aqui no construtor de 3 argumentos
    }


    //Métodos
    public void Deposito(double valorDepositoInicial) 
    {
        Saldo += valorDepositoInicial;
    }
    public void Saque(double valorDepositoInicial)
    {
         Saldo -= (valorDepositoInicial+5);
    }


    //Exibir descrição da conta
    public void DescricaoConta()
    {

        Console.Clear();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
        Console.WriteLine("      Dados bancários\n");
        Console.WriteLine($">Conta: {NumeroConta}\n" +
                          $">Titular: {NomeTitular}\n" +
                          $">Saldo: {Saldo:F2}\n");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n");
    }

}

class Treino
{
    static void Main()
    {
        var cb = Leitura();
        Exibir(cb);
    }
    static ContaBancaria Leitura()
    {
        
        int numeroConta;
        string nomeTitular;
        double valorDepositoInicial = 0;

        

        Console.Clear();
        Console.WriteLine("     Cadastro Bancário\n");
        Console.Write(">Informe o número da conta: ");
        while (true)
        {
            string nConta = Console.ReadLine().Trim();
            if(int.TryParse(nConta, out numeroConta) && numeroConta > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite números 'inteiros' positivos maiores que zero!");
            }
        }
        Console.Clear();
        Console.Write(">Informe o nome do titular da conta: ");
        while (true)
        {
            nomeTitular = Console.ReadLine().Trim().ToLower();
            if (!string.IsNullOrWhiteSpace(nomeTitular) && nomeTitular.All(c => char.IsLetterOrDigit(c) || //Verifica se c é uma letra ou um número.
                                                                                char.IsWhiteSpace(c))) //Permite espaços em branco, garantindo nomes compostos
            {
                nomeTitular = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeTitular.ToLower());
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite nome válido!");
            }
        }
        Console.Clear();
        Console.Write(">Haverá um depósito inicial? [s/n]: ");
        while (true)
        {
            char op = char.Parse(Console.ReadLine().ToLower());
            if (op == 's')
            {
                Console.Clear();
                Console.Write(">Informe o valor do depósito inicial: R$");
                while (true)
                {
                    string vDepositoInicial = Console.ReadLine().Trim();
                    if (double.TryParse(vDepositoInicial, out valorDepositoInicial))
                    {
                        return new ContaBancaria(numeroConta, nomeTitular, valorDepositoInicial); //Retornando Construtor com 3 argumentos
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(">Entrada inválida. Digite números 'inteiros' positivos!");
                    }
                }
            } 
            else if(op == 'n')
            {
                return new ContaBancaria(numeroConta, nomeTitular); //Retornando Construtor com 2 argumentos
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite apenas 's' ou 'n'!");
            }
        }
        
         
    }
    
    static void Exibir(ContaBancaria cb)
    {
        double depositoConta = 0, saqueConta = 0;

        
        cb.DescricaoConta();

        //Realizando um depósito
        Console.Write(">Digite um valor a ser depositado na conta, R$");
        while (true)
        {
            string dconta = Console.ReadLine().Trim();
            if(double.TryParse(dconta, out depositoConta) && depositoConta > 0)
            {
                cb.Deposito(depositoConta);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(">Entrada inválida. Digite um valor 'real' ou 'inteiro', positivo e maior que zero!");
            }
        }
        cb.DescricaoConta();

        //Realizando um saque
        Console.WriteLine($">Saldo atual R${cb.Saldo:F2}");
        while (true)
        {
            Console.Write(">Digite um valor a ser sacado da conta, R$");
            string sconta = Console.ReadLine().Trim();
            if (double.TryParse(sconta, out saqueConta) && saqueConta > 0 && saqueConta <= cb.Saldo)
            {
                cb.Saque(saqueConta);
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($">Entrada inválida. Saldo insulficiênte!\n>Saldo disponível para saque: R${cb.Saldo:F2}\n");
            }
        }

        cb.DescricaoConta();
    }
}




