using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrientacaoObjetosParte1
{
    public abstract class Pessoa
    {
        //Atributos e Métodos
        //Atributos = caracteristicas
        //Métodos = Acões

        //Declaração dos atributos
        private string nome;
        private int idade;
        private double peso;
        private string sexo;

        public string Nome
        {
            get { return nome; }
        }

        public int Idade 
        { 
            get { return idade; }
            set { idade = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
       

        public Pessoa(string _nome)
        {
            this.nome = _nome;
        }


        public void Andar()
        {
            Console.WriteLine("{0} está andando.", this.nome);
        }

        public void Comer(string _comida)
        {
            Console.WriteLine("{0} está comendo {1}.", this.nome, _comida);
        }

        public override string ToString()
        {
            return String.Format("Nome: {0}, Idade: {1}, Sexo: {2}, Peso: {3}", Nome, Idade, sexo, peso);
        }
    }
}
