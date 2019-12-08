using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

	Console.Clear();
    
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
	v1.SetListPassageiro(listPassageiros);
	v1.SetAviao(f35);
	v1.SetLinha("300");
	v1.SetOrigem("Eurico de Aguiar Salles");
	v1.SetDestino("Santos Dumont");

	//Salva as informacoes no arquivo
	Historico.Salvar(v1, DateTime.Now);

	Console.Write("Digite o número da linha: ");
	String numLinha = Console.ReadLine();

	Console.WriteLine();

	Historico.GetHistorico(numLinha);
	
  }
}