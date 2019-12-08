using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

class MainClass {
	public static void Main (string[] args) {

		Console.Clear();

		try{

			Console.Write("Digite a Data da Partida: ");
			DateTime partida = DateTime.Parse(Console.ReadLine());

			Console.Write("Digite a Data do Retorno: ");
			DateTime retorno = DateTime.Parse(Console.ReadLine());
			
			//Aviao
			Aviao f35 = new Aviao("F35", "Cinza", "Lockheed", DateTime.Now, "ASSS256");

			//Piloto
			Piloto pt1 = new Piloto("Arley Pereira", 24, "000.000.000-00", "ZZ");

			//Pessoas
			Passageiro ps1 = new Passageiro("Arley Pereira", 24, "000.000.000-00");
			Passageiro ps2 = new Passageiro("Maria dos Santos", 35, "000.000.000-00");
			Passageiro ps3 = new Passageiro("Josè Almeida", 48, "000.000.000-00");
			Passageiro ps4 = new Passageiro("Marcela Silva", 18, "000.000.000-00");
			Passageiro ps5 = new Passageiro("Fabio Santana", 68, "000.000.000-00");

			//Lista Pessoas
			List<Passageiro> listPassageiros = new List<Passageiro>();
			listPassageiros.Add(ps1);
			listPassageiros.Add(ps2);
			listPassageiros.Add(ps3);
			listPassageiros.Add(ps4);
			listPassageiros.Add(ps5);

			//Voo
			Voo v1 = new Voo();
			v1.SetPiloto(pt1);
			v1.SetPartida(partida);
			v1.SetRetorno(retorno);
			v1.SetListPassageiro(listPassageiros);
			v1.SetAviao(f35);
			v1.SetLinha("300");
			v1.SetOrigem("Eurico de Aguiar Salles");
			v1.SetDestino("Santos Dumont");

			//Salva as informacoes no arquivo
			Historico.Salvar(v1);
			//Historico.Salvar(v1, data);

			Console.WriteLine();
			Console.Write("Digite o número da linha para consultar o histórico: ");
			String numLinha = Console.ReadLine();

			Console.WriteLine();

			Historico.GetHistorico(numLinha);

		}catch(DomainException e){
			Console.WriteLine();
			Console.WriteLine("Ocorreu um Erro: " + e.Message);
		}
		
		catch(FormatException e){
			Console.WriteLine();
			Console.WriteLine("Ocorreu um Erro: Formato de Data Inválida");
		}
	
  	}
}