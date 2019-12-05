public class Piloto : Pessoa
    {

        public string Habilitacao { get; set; }

        public Piloto()
        {
        }

        public Piloto(string nome, int idade, double salario, string habilitacao) : base (nome, idade, salario)
        {
            Habilitacao = habilitacao;
        }

        public string GetHabilitacao()
        {
            return Habilitacao;
        }

        public void SetHabilitacao(string tipo)
        {
            Habilitacao = tipo;
        }

    }