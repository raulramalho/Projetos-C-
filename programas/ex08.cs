using System;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int data1, data2;
            Console.Write("Informe o nome da primeira pessoa: ");
            nome1=Console.ReadLine();
            Console.Write("Informe o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.Write("Informe a data de nascimento de {0}: ",nome1);
            data1 =int.Parse(Console.ReadLine());
            Console.Write("Informe a data de nascimento de {0}: ",nome2);
            data2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("*Operadore Relacional*");
            Console.WriteLine();
            Console.WriteLine("{0}({1}) é mais velho(a) que {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 < data2));
            Console.WriteLine("{0}({1}) é mais novo(a) que {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 > data2));
            Console.WriteLine("{0}({1}) é mais velho(a) ou nasceu no mesmo ano que {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 <= data2));
            Console.WriteLine("{0}({1}) é mais novo(a) ou nasceu no mesmo ano que {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 >= data2));
            Console.WriteLine("{0}({1}) nasceu no mesmo ano que {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 == data2));
            Console.WriteLine("{0}({1}) nasceu em um ano diferente de {2}({3})? {4} ", nome1, data1, nome2, data2, (data1 != data2));
            Console.WriteLine();
            Console.WriteLine("*Operadore Relacionai e Logico*");
            Console.WriteLine();
            Console.WriteLine("{0}({1}) é mais velho(a) que {2}({3}) e nasceu em ano bissexto? {4} ", nome1, data1, nome2, data2, (data1 < data2 && data1 % 4 == 0));
            Console.WriteLine("{0}({1}) é mais velho(a) que {2}({3}) e nasceu em ano bissexto? {4} ", nome2, data2, nome1, data1, (data1 > data2 && data2 % 4 == 0));
            Console.WriteLine("{0}({1}) é mais velho(a) que {2}({3}) ou nasceu em ano bissexto? {4} ", nome1, data1, nome2, data2, (data1 < data2 || data1 % 4 == 0));
            Console.WriteLine("{0}({1}) é mais velho(a) que {2}({3}) ou nasceu em ano bissexto? {4} ", nome2, data2, nome1, data1, (data1 > data2 || data2 % 4 == 0));
            Console.WriteLine("{0} de ({1}) é par e bissexto? {2} ", data1, nome1, (data1 %
                2 == 0 && data1 % 4 == 0));
            Console.WriteLine("{0} de ({1}) é par ou bissexto? {2} ", data1, nome1, (data1 % 2 == 0 || data1 % 4 == 0));
            Console.WriteLine("{0} de ({1}) é par e bissexto? {2} ", data2, nome2, (data2 % 2 == 0 && data2 % 4 == 0));
            Console.WriteLine("{0} de ({1}) é par ou bissexto? {2} ", data2, nome2, (data2 % 2 == 0 || data2 % 4 == 0));
            Console.WriteLine();
            Console.WriteLine("*Operador logico relacional e ternario*");
            Console.WriteLine();
            Console.WriteLine("{0} de ({1}) é par e bissexto? {2} ", data1, nome1, (data1 % 2 == 0 && data1 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é par ou bissexto? {2} ", data1, nome1, (data1 % 2 == 0 || data1 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é par e não bissexto? {2} ", data1, nome1, (data1 % 2 == 0 && data1 % 4 != 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é par ou nao bissexto? {2} ", data1, nome1, (data1 % 2 == 0 || data1 % 4 != 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é impar e bissexto? {2} ", data1, nome1, (data1 % 2 != 0 && data1 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é impar ou bissexto? {2} ", data1, nome1, (data1 % 2 != 0 || data1 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é impar e não bissexto? {2} ", data1, nome1, (data1 % 2 != 0 && data1 % 4 != 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é impar ou nao bissexto? {2} ", data1, nome1, (data1 % 2 != 0 || data1 % 4 != 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é par e bissexto? {2} ", data2, nome2, (data2 % 2 == 0 && data2 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine("{0} de ({1}) é par ou bissexto? {2} ", data2, nome2, (data2 % 2 == 0 || data2 % 4 == 0) ? "SIM" : "NÃO");
            Console.WriteLine();
            Console.Write("Pressione qualquer tecla para encerrar o programa");

            Console.ReadKey();

        }
    }
}
