using System;

class Aeronave {

        private string Modelo { get; set; }
        private string Cor { get; set; }
        private string Fabricante { get; set; }
        private DateTime DataFabricacao { get; set; } 
        private string NumeroDeSerie { get; set; }
            
        public Aeronave (string modelo, string cor, string fabricante, DateTime data, string numeroDeSerie) {
                Modelo = modelo;
                Cor = cor;
                Fabricante = fabricante;
                DataFabricacao = data;
                NumeroDeSerie = numeroDeSerie;
        }

        public Aeronave() {

        }

		public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

		public string GetCor() {
            return Cor;
        }

        public void SetCor(string cor) {
            Cor = cor;
        }

		public string GetFabricante() {
            return Fabricante;
        }

        public void SetFabricante(string fabricante) {
            Fabricante = fabricante;
        }

        public string getNumeroDeSerie() {
                return NumeroDeSerie;
        }

        public void setNumeroDeSerie(string novoNumero) {
                NumeroDeSerie = novoNumero;
        }

        public DateTime getDataFabricacao() {
                return DataFabricacao;
        }

        public void setDataFabricacao (DateTime novaData) {
                DataFabricacao = novaData;
        }

}