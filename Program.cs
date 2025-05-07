// See https://aka.ms/new-console-template for more information
 
using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            int subtracao = a - b;
            int multiplicacao = a * b;
            int divisao = a / b;
            int resto = a % b;

            Console.WriteLine($"A soma é: {soma}");
        }
    }
}
