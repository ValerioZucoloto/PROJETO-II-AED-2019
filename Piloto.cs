public class Piloto : Pessoa
    {

        public string Habilitacao { get; set; }

        public Piloto()
        {
        }

        public Piloto(string nome, int idade, string cpf, string habilitacao) : base (nome, idade, cpf)
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