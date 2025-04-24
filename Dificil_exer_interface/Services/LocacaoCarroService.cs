/*
Uma locadora brasileira de carros cobra um [valor por hora] para locações de até 12 horas. 

Porém, se a duração da locação ultrapassar 12 horas, a locação será cobrada com base em um [valor diário].
*/

using System;
using TREINO.Entities;

namespace TREINO.Services
{
    class LocacaoCarroService
    {
        public double ValorPorHora { get; private set; }//Private: Posso apenas obter os valores, não posso modificalos de outra classe
        public double ValorDiario { get; private set; }//Private: Posso apenas obter os valores, não posso modificalos de outra classe
        
        private I_ImpostoServices _impostoServices;


        public LocacaoCarroService(double valorPorHora, double valorDiario, I_ImpostoServices impostoServices)
        {
            ValorPorHora = valorPorHora;
            ValorDiario = valorDiario;
            _impostoServices = impostoServices;
        }


        public void GerarCobranca(LocacaoCarro locacaoCarro)
        {

            TimeSpan tempo = locacaoCarro.InstanteFinalLocacao.Subtract(locacaoCarro.InstanteInicialLocacao); //Diferença dos dois (InstanteFinal) e (InstanteInicial)

            double valorLocacao = 0;
            if(tempo.TotalHours <= 12)
            {
                //Lógica | Valor para locacao será; Valor por Hora * Hora total
                valorLocacao = ValorPorHora * Math.Ceiling(tempo.TotalHours); //[Ceiling] - Arredonda pra cima
            }
            else
            {
                //Lógica | Valor para locacao será; Valor por Dia * Dia total
                valorLocacao = ValorDiario * Math.Ceiling(tempo.TotalDays); //[Ceiling] - Arredonda pra cima
            }

            

            //Valor do imposto cobrado
            double valorImposto = _impostoServices.Imposto(valorLocacao);


            //Valor final da locação
            locacaoCarro.Cobranca = new Cobranca(valorLocacao, valorImposto);
        }
    }
}
