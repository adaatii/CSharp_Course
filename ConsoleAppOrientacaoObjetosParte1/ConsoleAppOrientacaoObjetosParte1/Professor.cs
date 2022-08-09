using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOrientacaoObjetosParte1
{
    public class Professor :Pessoa
    {
        public Professor(string _nome) : base(_nome)
        {

        }
        public void Lecionar (string _disciplina)
        {
            Console.WriteLine ("{0} está lecionando {1}",Nome, _disciplina);
        }
    }
}
