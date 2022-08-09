namespace ConsoleAppOrientacaoObjetosParte1
{
    internal class Program
    {
        // Classes, Atributos, Métodos, Laço try catch, Método Construtor

        static void Main(string[] args)
        {
            try
            {
                //Instanciando o objeto pessoa (classe "vira" objeto)
                /*Pessoa p1 = new Pessoa("Lucas");
                p1.Idade = 30;
                p1.Peso = 85.0;
                p1.Sexo = "Masculino";
                p1.Comer("Pizza");
                p1.Andar();
                p1.Comer("Lazanha");

                Console.WriteLine("Info da p1 = {0}", p1.ToString());
                Console.WriteLine("A pessoa p1 é {0}", p1.Nome);*/

                /*Pessoa p2 = new Pessoa("João")
                {
                    Idade = 20,
                    Peso = 65.0,
                    Sexo = "Masculino"
                };
                Console.WriteLine("Info da p1 = {0}", p2.ToString());

                p2.Comer("Churrasco");
                p2.Comer("Sorvete");
                p2.Andar();*/

                Aluno a1 = new Aluno("Marcos")
                {
                    Sexo = "Masculino",
                    Peso = 70,
                    Idade = 27
                };
                a1.Estudar("Programação");
                Console.WriteLine("Info de aluno {0}", a1.ToString());

                Professor pro1 = new Professor("Lucas");
                pro1.Lecionar("CSharp");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, deu um erro: {0}", ex.Message);
            }
        }
    }
}