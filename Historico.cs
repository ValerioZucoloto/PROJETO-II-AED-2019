using System;
using System.IO;
using System.Collections.Generic; 

class Historico {

        public DateTime data { get; set; }
        public Aviao aviao;
        public Piloto piloto;
        private static string reservas = "Historico";

        public static string CAMINHO_BANCO = "../";

        public Historico() {

        }

        public static void GetHistorico(string cpf){
                try{
			using(StreamReader sr = File.OpenText("Historico/" + cpf + ".txt")){
				while(!sr.EndOfStream) {
                                        string line = sr.ReadLine(); ;
                                        Console.WriteLine(line);
                                }
			}

		}
                catch(Exception e) {
                    Console.WriteLine("CPF INVÁLIDO !");
                }
        }

        public static void Salvar(Voo voo){

        }

}