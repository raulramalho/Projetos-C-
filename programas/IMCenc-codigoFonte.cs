using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCencB
{
    class Program
    {
        // Declaração das Variáveis Globais
        static float peso, altura, imc, pesomin, pesomax;
        static char sexo;
        static string situacao;

        static void Main(string[] args)
        {
            char repetir;
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine("IMC - Calcula o Índice de Massa Corporal e apresenta Situação\n");
                Entrada(); // chamada do método do tipo procedimento sem passagem de parâmetros
                Processamento(); // chamada de método do tipo procedimento
                Saida(); // chamada de método do tipo procedimento
                Console.Write("\nDeseja executar este programa novamente? (s/n): ");
                repetir = Char.ToUpper(Console.ReadKey().KeyChar);
                while(repetir!='S' && repetir != 'N')
                {
                    Console.Write("\nInformação inválida! Digite N para Não ou S para Sim: ");
                    repetir = Char.ToUpper(Console.ReadKey().KeyChar);
                }
            } while (repetir == 'S');
            Console.Write("\n\n\nObrigado por utilizar o programa IMCENC!\nDigite qualquer tecla para encerrar o programa...");
            Console.ReadKey(); // leitura de uma tecla que serve apenas de paradinha
        } // fim do método Main

        static void Entrada() // detalhamento do método do tipo procedimento
        {
            Console.Write("Digite o peso em Kilos: ");
            while((!float.TryParse(Console.ReadLine(), out peso)) || peso < 10 || peso > 200)
            {
                Console.Write("Peso inválido! Digite número entre 10 e 200: ");
            }
            Console.Write("Digite a altura em metros: ");
            while ((!float.TryParse(Console.ReadLine(), out altura)) || altura < 1.0 || altura > 2.5)
            {
                Console.Write("Altura inválida! Digite número entre 1,0 e 2,5: ");
            }
            Console.Write("Informe o gênero (M para masculino ou F para feminino): ");
            while ((!char.TryParse(Console.ReadLine().ToUpper(), out sexo)) || (sexo != 'M' && sexo != 'F'))
            {
                Console.Write("Gênero inválido! Digite M ou F: ");
            }
        }// fim do método Entrada

        static void Processamento() // detalhamento do método do tipo procedimento
        {
            imc = peso / (float)Math.Pow((double)altura, 2);
            if (sexo=='F')
            {
                pesomin = (float)19.1 * (float)Math.Pow((double)altura, 2);
                pesomax = (float)25.8 * (float)Math.Pow((double)altura, 2);
                if (imc < 19.1)
                    situacao = "1"; // "Pessoa do sexo feminino abaixo do peso ideal";
                else
                    if (imc <= 25.8)
                    situacao = "2"; // "Pessoa do sexo feminino com peso ideal";
                else if (imc <= 32.3)
                    situacao = "3"; // "Pessoa do sexo feminino acima do peso ideal";
                else situacao = "4"; // "Pessoa do sexo feminino muito acima do peso ideal";
            }
            else // caso do sexo = 'M'
            {
                pesomin = (float)20.7 * (float)Math.Pow((double)altura, 2);
                pesomax = (float)26.4 * (float)Math.Pow((double)altura, 2);
                if (imc < 20.7)
                    situacao = "5"; // "Pessoa do sexo masculino abaixo do peso ideal";
                else
                    if (imc <= 26.4)
                    situacao = "6"; // "Pessoa do sexo masculino com peso ideal";
                else if (imc <= 31.1)
                    situacao = "7"; // "Pessoa do sexo masculino acima do peso ideal";
                else situacao = "8"; // "Pessoa do sexo masculino muito acima do peso ideal";
            }
        } // fim do método Processamento

        static void Saida() // detalhamento do método do tipo procedimento
        {
            Monta_Situacao();
            Console.WriteLine("IMC = {0:N} - Situação: {1}\n", imc, situacao);
            Console.ForegroundColor = ConsoleColor.Black;
            if (sexo == 'M')
                Console.WriteLine("Faixa de peso ideal para masculino de altura {0:N}: de {1:N} Kg até {2:N} Kg\n",altura, pesomin, pesomax);
            else
                Console.WriteLine("Faixa de peso ideal para feminino de altura {0:N}: de {1:N} Kg até {2:N} Kg\n", altura, pesomin, pesomax);
        } // fim do método Saida

        static void Monta_Situacao()
        {
            switch (situacao)
            {
                case "1":
                    situacao = "Pessoa do sexo feminino abaixo do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "2":
                    situacao = "Pessoa do sexo feminino com peso ideal";
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "3":
                    situacao = "Pessoa do sexo feminino acima do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "4":
                    situacao = "Pessoa do sexo feminino muito acima do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "5":
                    situacao = "Pessoa do sexo masculino abaixo do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "6":
                    situacao = "Pessoa do sexo masculino com peso ideal";
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "7":
                    situacao = "Pessoa do sexo masculino acima do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case "8":
                    situacao = "Pessoa do sexo masculino muito acima do peso ideal";
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
            }
        }
    }// fim da class Program
}
