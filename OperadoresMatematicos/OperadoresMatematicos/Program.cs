using System;

namespace OperadoresMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;

            Console.WriteLine("Digite o primeiro numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            total = a + b;

            Console.WriteLine("A soma de a + b = " + total);
            Console.WriteLine("A soma de a + b = " + a + b); // concatena tudo (console entende que são todas strings) retornando "a" ao lado de "b"
            Console.WriteLine("A soma de a + b = " + (a + b)); // regra do parenteses, o codigo é executado dentro de cada unidade de parenteses.
            Console.WriteLine("A subtração de a - b = " + (a - b));
            Console.WriteLine("A multiplicação de a * b = " + (a * b));
            Console.WriteLine("A divisão de a / b = " + (a / b));
            Console.WriteLine("O resto da divisão de a % b = " + (a % b));




        }
    }

}