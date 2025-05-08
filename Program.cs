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
            


        // Exercicio 2 - Calcular a média de 3 números utilizano o else if 



            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine($"{n1} é o maior número.");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine($"{n2} é o maior número.");
            }
            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine($"{n3} é o maior número.");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
            
        }
    }
}
