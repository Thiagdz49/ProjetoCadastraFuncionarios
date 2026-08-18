using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaFuncionarios
{
    internal class Funcionario // class Funcionário
    {
        /*
        Cadastro de Funcionarios
        Matricula
        Nome/Sobrenome
        Endereço/numero
        Cidade
        Uf
        Cep
        Cpf 
        Email
        Data de Nascimento
         */

        // Declarando propriedades da class Funcionário
        private int matricula; 
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereço;

        public string Endereço
        {
            get { return endereço; }
            set { endereço = value; }
        }

        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        private string uf;

        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        private string cep;

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime datanasc;

        public DateTime Datanasc
        {
            get { return datanasc; }
            set { datanasc = value; }
        }

        public Funcionario()
        {
            Matricula = 0;
            Nome = "";
            Endereço = "";
            Cidade = "";
            Uf = "";
            Cep = "";
            Cpf = "";
            Telefone = "";
            Email = "";
            Datanasc = DateTime.Now;
        }


        // Declarando Função Idade
        public int Idade()
        { 
            int idade = DateTime.Now.Year - Datanasc.Year;
            int mes = Datanasc.Month;
            int dia = Datanasc.Day;
            if (DateTime.Now.Month >= mes && DateTime.Now.Day > dia)
            {
                idade--;
            }
            return idade;
        }
        // Declarando Construtores
        public Funcionario(int matricula, string nome, string endereço, string cidade, string uf, string cep, string cpf, string telefone, string email, DateTime datanasc)
        {
            Matricula = matricula;
            Nome = nome;
            Endereço = endereço;
            Cidade = cidade;
            Uf = uf;
            Cep = cep;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Datanasc = datanasc;
        }

        // Declarando Método ToString
        public override string ToString()
        {
            return "Funcionario: " +
                $"\nMatrícula:  {Matricula} " +
                $"\nEndereço: {Endereço}" +
                $"\nCidade: {Cidade} " +
                $"\nUf: {Uf} " +
                $"\nCep: {Cep} " +
                $"\nCpf: {Cpf} " +
                $"\nTelefone: {Telefone} " +
                $"\nEmail: {Email} " +
                "\nData nascimento: " +
                Datanasc.ToString("dd/MM/yyyy") +
                "\nIdade: " + Idade();

        }
    }
}
