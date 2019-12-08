using System;

public class Pessoa {

    public string Nome { get; set; }
    public int Idade { get; set; }
    private string CPF {get; set;}

    public Pessoa(){
    }

	public Pessoa(string nome, int idade, string cpf){
		Nome = nome;
		Idade = idade;
		CPF = cpf;
	}

	public string GetNome(){
		return Nome;
	} 

	public void SetNome(string nome){
		Nome = nome;
	}

	public int GetIdade(){
		return Idade;
	}

	public void SetIdade(int idade){
		Idade = idade;
	}

	public string GetCPF() {
			return CPF;
	}

	public void SetCPF(string novoCpf){
			CPF = novoCpf;
	}

}
