/*
Cliente;
        Nome, 
        Email, 
        Data nascimento.
*/
using System;
using System.Text;
namespace TREINO.Entities
{
    class Cliente
    {
        public string Nome{ get; set; }
        public string Email{ get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente(string nome, string email, DateTime dataNascimento)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
        }
        public override string ToString()
        {
            return  $"\n-=-=-=-= Dados do Cliente: -=-=-=-=:\n\n" +
                    $">Nome do cliente: {Nome}\n" +
                    $">Email do Cliente: {Email}\n" +
                    $">Data de nascimento do Cliente: {DataNascimento.ToString("dd/MM/yyyy")}\n\n";
        }
    }
}
