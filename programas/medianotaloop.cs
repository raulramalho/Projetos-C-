using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNotarLoop
{
    class Program
    {
        static double notaparaclasse,nota1, nota2, nota3, nota4, media,mediaescola;
        static string nomeclasse, nome;
        static int quantnotas, quantalunos, vezes , escolha,progvezes;
      

        static void Main(string[] args)
        {
            

        
                Console.WriteLine("Media de notas de classes");
                do{
                    quantnotas = 0;
                    quantalunos = 0;
                    vezes = 0;
                    escolha = 0;
                    nota1 = 0;
                    nota2 = 0;
                    nota3 = 0;
                    nota4 = 0;
                    media = 0;
                    notaparaclasse = 0;
                  
                    Console.Write("Digite o nome da classe:");
                    nomeclasse = Console.ReadLine();
                    Console.Write("\nQuantas notas serão necessarias para compor a media?");
                while (!int.TryParse(Console.ReadLine(), out quantnotas) || (quantnotas < 2 || quantnotas > 4))
                {
                    Console.Write("Digite um valor entre 2 e 4:");
                }
                    Console.Write("\nDigite quantas notas de alunos voce ira registrar(maximo 10): ");                   
                while (!int.TryParse(Console.ReadLine(), out quantalunos) || (quantalunos > 10 || quantalunos < 1))
                    {
                        Console.Write("\nDigite um valor entre 1 e 10:");                        
                    }
                    do
                    {
                         
                        if (quantnotas == 2)
                        {
                                Console.Write("\nDigite o nome do aluno:");
                                nome = Console.ReadLine();                            
                                Console.Write("\nDigite a nota 1 do aluno:");
                        while(!double.TryParse(Console.ReadLine(),out nota1)|| (nota1 < 0 || nota1 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                                Console.Write("\nDigite a nota 2 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota2) || (nota2 < 0 || nota2 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }

                        mediaconta();
                            
                        } 
                        else if (quantnotas == 3)
                        {
                                Console.Write("\nDigite o nome do aluno:");
                                nome = Console.ReadLine();
                           
                                Console.Write("\nDigite a nota 1 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota1) || (nota1 < 0 || nota1 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                                Console.Write("\nDigite a nota 2 do aluno:");
                                while (!double.TryParse(Console.ReadLine(), out nota2) || (nota2 < 0 || nota2 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                                Console.Write("\nDigite a nota 3 do aluno:");
                                while (!double.TryParse(Console.ReadLine(), out nota3) || (nota3 < 0 || nota3 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                        mediaconta();

                        }
                        else if (quantnotas == 4)
                        {
                                Console.Write("\nDigite o nome do aluno:");
                                nome = Console.ReadLine();
                                Console.Write("\nDigite a nota 1 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota1) || (nota1 < 0 || nota1 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }                        
                                Console.Write("\nDigite a nota 2 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota2) || (nota2 < 0 || nota2 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                                Console.Write("\nDigite a nota 3 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota3) || (nota3 < 0 || nota3 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }
                                Console.Write("\nDigite a nota 4 do aluno:");
                        while (!double.TryParse(Console.ReadLine(), out nota4) || (nota4 < 0 || nota4 > 10))
                        {
                                Console.Write("\nValor invalido digite um valor entre 0 e 10");
                        }

                        mediaconta();
                        }
                    } while (vezes != quantalunos);
                    mediaclasse();
                
                } while (escolha != 0); 
            
            Console.WriteLine("\nObrigado por utilizar nosso programa");
            Console.Write("Aperte qualquer tecla para encerrar o programa");
            Console.ReadKey();

            void mediaconta()
            {
                vezes = vezes + 1;
                media = (nota1 + nota2 + nota3 + nota4) / quantnotas;
                notaparaclasse = notaparaclasse + media;
                Console.WriteLine("O aluno {0} recebeu a media {1}", nome, media);
                if (media < 5)
                {
                    Console.WriteLine("Reprovado\n");
                }
                else if (media >= 7)
                {
                    Console.WriteLine("Aprovado\n");
                }
                else
                {
                    Console.WriteLine("Precisa fazer um novo exame\n");
                }
            }
            void mediaclasse()
            {
                notaparaclasse = notaparaclasse / quantalunos;
                progvezes ++;
                
                Console.WriteLine("A classe {0} com {1} alunos teve media {2}", nomeclasse, quantalunos, notaparaclasse);                Console.Write("Para finalizar o programa digite 0 pra repetir digite 1...");
                mediadaescola();
                while(!int.TryParse(Console.ReadLine(),out escolha))
                {
                    Console.Write("Digite 1 para repetir e 0 para sair");
                }
                void mediadaescola()
                {
                    mediaescola += notaparaclasse;
                    mediaescola =mediaescola / progvezes;
                    Console.WriteLine("A media da escolha é {0}", mediaescola);
                }
            }         
        }
    }
}


