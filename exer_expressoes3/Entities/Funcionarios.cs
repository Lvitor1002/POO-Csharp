﻿using System;


namespace exer_expressoes3.Entities
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionarios(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }
    }
}
