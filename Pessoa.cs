using System;

public class Pessoa {

    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Salario { get; set; }
    private string Cpf {get; set;}

    public Pessoa(){
    }

	public Pessoa(string nome, int idade, double salario){
		Nome = nome;
		Idade = idade;
		Salario = salario;
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

	public double GetSalario(){
		return Salario;
	}

	public void SetSalario(double salario){
		Salario = salario;
	}

        public string GetCpf() {
                return Cpf;
        }

        public void SetCpf (string novoCpf){
                Cpf = novoCpf;
        }

}
