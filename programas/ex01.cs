using System;

namespace ExercicioPA01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            double a2 = 10, b2 = 3;
            Console.WriteLine("A soma do numero " + a + " com o numero " + b + " é " + (a + b));
            Console.WriteLine("A subtração de " + a + " por " + b + " é " + (a - b));
            Console.WriteLine("A multiplicação de " + a + " com " + b + " é " + (a * b));
            Console.WriteLine("A divisão inteira de " + a + " por " + b + " é " + (a / b));
            Console.WriteLine("O resto da divisão de " + a + " por " + b + " é " + (a % b));
            Console.WriteLine("A divisão de " + a2 + " por " + b2 + " é " + (a2 / b2));
            Console.ReadKey();
        }
    }
}
