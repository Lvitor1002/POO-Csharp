

//Cor[preto, azul, vermelho]:,
//Formas
//mostrar as áreas destas figuras na mesma ordem em que foram digitadas

using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    abstract class AbstractFigura : IFigura
    {

        public Cores Cor { get; set; }
        public Formas Forma { get; set; }

        protected AbstractFigura(Cores cor, Formas forma)
        {
            Cor = cor;
            Forma = forma;
        }


        //Apenas declarados herdados de IFigura, porque a classe é abstract!
        public abstract double Area();
    }
}
