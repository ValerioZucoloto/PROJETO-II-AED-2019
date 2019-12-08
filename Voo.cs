using System;
using System.Collections.Generic;

class Voo {

	private Piloto _piloto { get; set; }
	private List<Passageiro> listaPassageiro = new List<Passageiro>();
	private Aviao _aviao { get; set; }
	private string Linha { get; set; }
	private String Origem { get; set; }
	private String Destino { get; set; }
	private DateTime Partida { get; set; }
	private DateTime Retorno { get; set; }

	public Voo() {

	}

	public Voo (Piloto piloto, List <Passageiro> passageiros, Aviao aviao, string linha, string origem, string destino, DateTime partida, DateTime retorno) {
		_piloto = piloto;
		listaPassageiro = passageiros;
		_aviao = aviao; 
		Linha = linha;  
		Origem = origem;
		Destino = destino;
		Partida = partida;
		Retorno = retorno;
	}

	public Piloto GetPiloto(){
		return _piloto;
	}

	public void SetPiloto(Piloto piloto){
		this._piloto = piloto;
	}

	public List<Passageiro> GetListPassageiros(){
		return listaPassageiro;
	}

	public void SetListPassageiro(List<Passageiro> listaPassageiro){
		this.listaPassageiro = listaPassageiro;
	}

	public Aviao GetAviao(){
		return _aviao;
	}

	public void SetAviao(Aviao aviao){
		this._aviao = aviao;
	}

	public string GetLinha(){
		return Linha;
	}

	public void SetLinha(string linha){
		this.Linha = linha;
	}

	public string GetOrigem(){
		return Origem;
	}

	public void SetOrigem(string origem){
		this.Origem = origem;
	}

	public string GetDestino(){
		return Destino;
	}

	public void SetDestino(string destino){
		this.Destino = destino;
	}

	public DateTime GetPartida(){
		return Partida;
	}

	public void SetPartida(DateTime partida){
		Partida = partida;
	}

	public DateTime GetRetorno(){
		return Retorno;
	}

	public void SetRetorno(DateTime retorno){
		Retorno = retorno;
	}

}