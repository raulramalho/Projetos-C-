using System;

namespace desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int diametro = 5;
            double profundidade = 1.5;
            double pi = 3.14;
            double raio = diametro / 2;
            double cubico = raio * raio * pi * profundidade;
            Console.WriteLine("O tamanho do diametro é: " + diametro);
            Console.WriteLine("O raio é o diametro dividido por 2 " + raio);
            Console.WriteLine("A profundidade é: " + profundidade);
            Console.WriteLine("Pi=" + pi);
            Console.WriteLine("Volume em metros cubicos: "+(raio * raio * pi * profundidade));
            Console.WriteLine("Volume em litros: " + (cubico*1000));
            Console.ReadKey();
        }
    }
}
