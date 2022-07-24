namespace ConsoleAppArraysIntrodução
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] semana = new string[] {"Segunda", "Terça", "Quarta", 
                                             "Quinta", "Sexta", "Sabado", "Domingo"
                                            };

            // sem iteração
            Console.WriteLine("O dia da semana é: " + semana[2]);
            Console.WriteLine("------------------------------");

            // iteração com o for
            for (int i=0; i < semana.Length; i++)
            {
                Console.WriteLine("O dia da semana é: " + semana[i]);
            }
            Console.WriteLine("------------------------------");
            // iteração com for each
            foreach (string dia in semana)
            {
                Console.WriteLine("O dia da semana é: " + dia);
            }

            Console.WriteLine("A posição de quarta é: " + Array.IndexOf(semana, "Quartaa")); // retorno -1 = não foi encontrado

            
        }
    }
}