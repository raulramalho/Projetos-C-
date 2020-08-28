using System;

namespace Media2Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, reprovado, aprovado, exame;
            float nota1, nota2, media;
            Console.WriteLine("*Calculando Média De Um Aluno*");
            Console.Write("Digite o nome do aluno:");
            nome = Console.ReadLine();
            Console.Write("Digite a primeira nota do aluno:");
            nota1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota do aluno:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Aluno(a):" + nome);
            Console.WriteLine("Primeira nota:" + nota1);
            Console.WriteLine("Segunda nota:" + nota2);
            media = (nota1 + nota2) / 2;
            Console.WriteLine("Média:" + media);
            reprovado = (media < 5 ? "Reprovado" : "");
            Console.Write(reprovado);
            aprovado = (media >= 7 ? "Aprovado" : "");
            Console.Write(aprovado);
            exame = (media >= 5 && media < 7 ? "Precisa fazer um exame" : "");
            Console.Write(exame);
            Console.Write("\nPressione qualquer tecla para sair do programa...");
            Console.ReadKey();
        }
    }
}
