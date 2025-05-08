// See https://aka.ms/new-console-template for more information
 
using System;

namespace Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número: ");
            int b = int.Parse(Console.ReadLine());

            int soma = a + b;
            int subtracao = a - b;
            int multiplicacao = a * b;
            int divisao = a / b;
            int resto = a % b;

            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A subtração é: {subtracao}");
            Console.WriteLine($"A multiplicação é: {multiplicacao}");
            Console.WriteLine($"A divisão é: {divisao}");
            Console.WriteLine($"O resto da divisão é: {resto}");

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} é par.");
            }
            else
            {
                Console.WriteLine($"{a} é ímpar.");
            }
            if (b % 2 == 0)
            {
                Console.WriteLine($"{b} é par.");
            }
            else
            {
                Console.WriteLine($"{b} é ímpar.");
            }
            */

            Console.WriteLine("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} é o maior número.");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} é o maior número.");
            }
            else if (c > a && c > b)
            {
                Console.WriteLine($"{c} é o maior número.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
    }
}
