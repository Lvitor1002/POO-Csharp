

/* 
                Comentários:
                            Tenham uma boa viagem
                            Uau, isso é demais!
*/

namespace TREINO.Entities
{
    class Comentarios 
    {
        public string Comentario { get; set; }

        public Comentarios()
        {
        }

        public Comentarios(string comentario)
        {
            Comentario = comentario;
        }

        public override string ToString()
        {
            return $"{Comentario}\n";
        }
    }
}
