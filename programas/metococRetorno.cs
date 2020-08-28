using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodocRetorno
{
    class Program
    {
        static double numero;
        static int repetir=0;
        static void Main(string[] args)
        {
            do
            {
                Console.Write("digite um numero:");
                while ((!double.TryParse(Console.ReadLine(), out numero)))
                {
                    Console.Write("\ndigite um valor valido:");

                }
                if (numero == 0)
                {
                    Console.WriteLine("O numero é nulo\n");                    
                }else if (parimpar() == true)
                {  
                    Console.WriteLine("\no numero é par");
                }
                else
                {
                    Console.WriteLine("\no numero é impar");
                }
                Console.Write("Deseja repetir? se sim digite 1 se n digite 0:");
                while((!int.TryParse(Console.ReadLine(), out repetir))||(repetir!=1 || repetir!=0))
                {
                    Console.Write("digite um valor valido:");
                }
                
             
            } while (repetir != 0);
            Console.Write("Pressione qualquer tecla para finalizar o programa...");
            Console.ReadKey();               
            Boolean parimpar()
            {
                if (numero % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
