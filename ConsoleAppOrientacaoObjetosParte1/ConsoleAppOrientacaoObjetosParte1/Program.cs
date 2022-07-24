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
                Pessoa p1 = new Pessoa("Lucas");
                p1.Comer("Pizza");
                p1.Andar();
                p1.Comer("Lazanha");

                Pessoa p2 = new Pessoa("João");
                p2.Comer("Churrasco");
                p2.Comer("Sorvete");
                p2.Andar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, deu um erro: {0}", ex.Message);
            }
        }
    }
}