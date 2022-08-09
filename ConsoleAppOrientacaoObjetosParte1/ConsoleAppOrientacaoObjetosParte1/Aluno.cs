using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrientacaoObjetosParte1
{
    public class Aluno : Pessoa
    {
        public Aluno(string _nome) : base(_nome)
        {

        }
        public void Estudar (string _disciplina)
        {
            Console.WriteLine("{0} está estudando {1}",Nome, _disciplina);
        }
    }
}
