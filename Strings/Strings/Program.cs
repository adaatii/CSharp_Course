namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string nomecompleto;
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();

            nomecompleto = nome + " " + sobrenome;
            Console.WriteLine("Seu nome completo é: " + nomecompleto);
            Console.WriteLine("Seu nome tem " + nome.Length + " caracteres");
            Console.WriteLine("Olá " + nome.ToUpper());
            Console.WriteLine("Olá " + nome.ToLower());
            Console.WriteLine("Olá " + nomecompleto.ToUpper());

            string fragmento = nomecompleto.Substring(0, 3);
            Console.WriteLine("Fragmento = {0} ", fragmento);
        }
    }
}