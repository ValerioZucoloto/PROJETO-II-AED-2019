using System;

class Aeronave {
        public string Modelo;
        public string Cor;
        public string Fabricante;
        private DateTime DataFabricacao {get; set;} 
        private string NumeroDeSerie {get; set;}
        public static int QuantidadePassageiros;
        public static double DistanciaPercorrida;
        public static double LitrosDeCombustivel;
        


        public Aeronave (string modelo, string cor, string fabricante, DateTime data, string numeroDeSerie) {
                Modelo = modelo;
                Cor = cor;
                Fabricante = fabricante;
                DataFabricacao = data;
                NumeroDeSerie = numeroDeSerie;
        }

        public Aeronave() {

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

        public static void AutonomiaDeVoo() {

        }

        

        


}