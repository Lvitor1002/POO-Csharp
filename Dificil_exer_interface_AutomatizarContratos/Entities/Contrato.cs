
/*
 Fazer um programa para ler os dados de um contrato; 
                                                  número do contrato, 
                                                  data do contrato,
                                                  valor total do contrato. 
Em seguida, o programa deve ler; 
                                número de meses para parcelamento do contrato
 */

using System;
using System.Collections.Generic;


namespace TREINO.Entities
{
    class Contrato
    {
        public int Id { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato{get;set;}
        public List<Parcelamento> ListaParcelas { get; set; }// [1]|UM CONTRATO POSSUI [*]|VÁRIAS PARCELAS


        public Contrato(int id, DateTime dataContrato, double valorTotalContrato)
        {
            Id = id;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;
            ListaParcelas = new List<Parcelamento>();
        }

        public void AdicionaParcela(Parcelamento parcelas)
        {
            ListaParcelas.Add(parcelas);
        }
    }
}
