using System;
using System.Reflection;


namespace TREINO.Entities
{
    class LocacaoCarro
    {
        public DateTime InstanteInicialLocacao { get; set; }
        public DateTime InstanteFinalLocacao { get; set; }
        public Carro Carro { get; set; }
        public Cobranca Cobranca { get; set; }


        public LocacaoCarro(DateTime instanteInicialLocacao, DateTime instanteFinalLocacao, Carro carro, Cobranca cobranca)
        {
            InstanteInicialLocacao = instanteInicialLocacao;
            InstanteFinalLocacao = instanteFinalLocacao;
            Carro = carro;
            Cobranca = null; 
        }
    }
}

