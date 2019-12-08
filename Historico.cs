using System;
using System.IO;
using System.Collections.Generic;

class Historico
{

	public static string CAMINHO_BANCO = "Historico/";

	public Historico()
	{

	}

	public static void GetHistorico(string linha)
	{
		try
		{
			using (StreamReader sr = File.OpenText(CAMINHO_BANCO + linha + ".txt"))
			{
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine(); ;
					Console.WriteLine(line);
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine("LINHA INVÀLIDA");
		}
	}

	public static void Salvar(Voo voo)
	{

		if(voo.GetPartida() > voo.GetRetorno()){
			throw new DomainException("A partida deve ser posterior a data do retorno e igual ou superior a data atual.");
		}

		Directory.CreateDirectory(CAMINHO_BANCO);

		try
		{
			using (StreamWriter sw = File.AppendText(CAMINHO_BANCO + voo.GetLinha() + ".txt"))
			{

				sw.WriteLine("============== DADOS DO VOO ==============");
				sw.WriteLine("Origem: " + voo.GetOrigem());
				sw.WriteLine("Destino: " + voo.GetDestino());
				sw.WriteLine("Data da partida: " + voo.GetPartida());
				sw.WriteLine("Data do retorno: " + voo.GetRetorno());
				sw.WriteLine();

				sw.WriteLine("============== DADOS DO PILOTO ==============");
				sw.WriteLine("Nome: " + voo.GetPiloto().GetNome());
				sw.WriteLine("Idade: " + voo.GetPiloto().GetIdade());
				sw.WriteLine("CPF: " + voo.GetPiloto().GetCPF());
				sw.WriteLine("Habititação: " + voo.GetPiloto().GetHabilitacao());
				sw.WriteLine();

				sw.WriteLine("============== DADOS DO AVIÂO ==============");
				sw.WriteLine("Modelo: " + voo.GetAviao().GetModelo());
				sw.WriteLine("Cor: " + voo.GetAviao().GetCor());
				sw.WriteLine("Fabricante: " + voo.GetAviao().GetFabricante());
				sw.WriteLine("Data fabricação: " + voo.GetAviao().getDataFabricacao());
				sw.WriteLine("Nº Série: " + voo.GetAviao().getNumeroDeSerie());
				sw.WriteLine();

				sw.WriteLine("============== DADOS DOS PASSAGEIROS ==============");
				foreach (Passageiro p in voo.GetListPassageiros())
				{
					sw.WriteLine("Nome: " + p.GetNome());
					sw.WriteLine("Idade: " + p.GetIdade());
					sw.WriteLine("CPF: " + p.GetCPF());
					sw.WriteLine();
				}

			}
		}
		catch (IOException e)
		{
			Console.WriteLine(e.Message);
		}

	}

}