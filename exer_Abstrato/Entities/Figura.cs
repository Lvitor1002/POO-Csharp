

//Cor[preto, azul, vermelho]:,
//                            Largura:,
//                            Altura:,
//                            Cor[preto, azul, vermelho]:,
//                            Raio:
//mostrar as áreas destas figuras na mesma ordem em que foram digitadas

using TREINO.Entities.Enums;

namespace TREINO.Entities
{
    abstract class Figura
    {
        //Nos atributos da FIGURA, permane apenas os que são repetidos, por exemplo: cores, tem no retangulo e circulo 

        public Cores Cor { get; set; }
        public Formas Forma { get; set; }

        public Figura()
        {
        }
        public Figura(Cores cor,Formas forma)
        {
            Cor = cor;
            Forma = forma;
        }


        //Apenas declarados, porque é abstract, se não, poderia usar o método aqui mesmo.
        public abstract double Area();

    }
}
