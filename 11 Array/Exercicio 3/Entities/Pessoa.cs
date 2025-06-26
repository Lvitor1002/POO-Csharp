

namespace TREINO.Entities
{
    internal class Pessoa
    {
        public string Nome{ get; set; }
        public int Idade{ get; set; }
        public char Sexo { get; set; }

        public Pessoa(string nome, int idade, char sexo ) {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                $"Idade: {Idade}\n" +
                $"Sexo: {Sexo}\n\n";
        }

    }
}
