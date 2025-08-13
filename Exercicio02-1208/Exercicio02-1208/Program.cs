using System;
using System.Runtime.Intrinsics.X86;

namespace Exercicio02_1208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1)Receber 3 números e verificar se são pares ou ímpares (procurar como o C# faz o resto da divisão)

            Console.WriteLine("escreva 3 números para ver se eles são par ou impar");
            for (int i = 0; i < 3; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{num} é par");
                }
                else
                {
                    Console.WriteLine($"{num} é impar");
                }

            }


            //2)Faça um Programa que peça a temperatura em graus Fahrenheit,transforme e mostre a temperatura em graus Celsius.C = 5 * ((F - 32) /9).

            Console.WriteLine("temperatura em Fahrenheit: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"temperatura em Celsius {5 * ((num - 32) / 9)}");

            //3.Crie um programa para resolver uma Equação do 2 grau delta = b * b - 4 * a * c;
            //a1 = (-b + raiz(delta)) / (2 * a);
            //a2 = (-b - raiz(delta)) / (2 * a);
            //Imprima a1 e a2

            Console.WriteLine("Num 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Num 3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = (b * b - 4 * a * c);
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(a1);
            Console.WriteLine(a2);
        }
    }
}
