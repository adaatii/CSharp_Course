using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrientacaoObjetosParte1
{
    public class Pessoa
    {
        //Atributos e Métodos
        //Atributos = caracteristicas
        //Métodos = Acões

        //Declaração dos atributos
        public string nome;
        public int idade;
        public double peso;
        public string sexo;

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
    }
}
