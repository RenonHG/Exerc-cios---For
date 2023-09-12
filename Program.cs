using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios___For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\r\n███╗   ███╗███████╗███╗   ██╗██╗   ██╗\r\n████╗ ████║██╔════╝████╗  ██║██║   ██║\r\n██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║\r\n██║╚██╔╝██║██╔══╝  ██║╚██╗██║██║   ██║\r\n██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝\r\n╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ \r\n                                      \r\n");
            
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("\n1 - Números Pares em um intervalo");
            Console.WriteLine("2 - Sequência de Fibonacci");
            Console.WriteLine("3 - Numeros Primos no intervalo");
            Console.Write("Escolha a opção desejada: ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("███╗   ██╗██╗   ██╗███╗   ███╗███████╗██████╗  ██████╗ ███████╗    ██████╗  █████╗ ██████╗ ███████╗███████╗\r\n████╗  ██║██║   ██║████╗ ████║██╔════╝██╔══██╗██╔═══██╗██╔════╝    ██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝\r\n██╔██╗ ██║██║   ██║██╔████╔██║█████╗  ██████╔╝██║   ██║███████╗    ██████╔╝███████║██████╔╝█████╗  ███████╗\r\n██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══╝  ██╔══██╗██║   ██║╚════██║    ██╔═══╝ ██╔══██║██╔══██╗██╔══╝  ╚════██║\r\n██║ ╚████║╚██████╔╝██║ ╚═╝ ██║███████╗██║  ██║╚██████╔╝███████║    ██║     ██║  ██║██║  ██║███████╗███████║\r\n╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝    ╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝\r\n                                                                                                           ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Digite o intervalo inicial: ");
                    int inicio = int.Parse(Console.ReadLine());

                    Console.Write("Digite o intervalo final: ");
                    int fim = int.Parse(Console.ReadLine());

                    int quantidade = 0;
                    for (int i = inicio; i <= fim; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(i);
                            quantidade++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(i);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\nNesse intervalo há " + quantidade + " número ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("pares!");


                    break;

                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("███████╗██╗██████╗  ██████╗ ███╗   ██╗ █████╗  ██████╗ ██████╗██╗\r\n██╔════╝██║██╔══██╗██╔═══██╗████╗  ██║██╔══██╗██╔════╝██╔════╝██║\r\n█████╗  ██║██████╔╝██║   ██║██╔██╗ ██║███████║██║     ██║     ██║\r\n██╔══╝  ██║██╔══██╗██║   ██║██║╚██╗██║██╔══██║██║     ██║     ██║\r\n██║     ██║██████╔╝╚██████╔╝██║ ╚████║██║  ██║╚██████╗╚██████╗██║\r\n╚═╝     ╚═╝╚═════╝  ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚═════╝╚═╝\r\n                                                                 ");


                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Slv Q-brada, Sequência de Fibonacci presente, fale um número aí de quantas operações tu quer meu princeso: ");
                    int operacao = int.Parse(Console.ReadLine());

                    float fibonacci = 0;
                    float atual = 1;
                    float anterior = 0;

                    Console.Write("\n");
                    for (int i = 1; i <= operacao; i++)
                    {
                        fibonacci = anterior + atual;
                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine(anterior + " + " + atual + " = " + fibonacci);
                        //Console.WriteLine(fibonacci);

                        anterior = atual;
                        atual = fibonacci;
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("██████╗ ██████╗ ██╗███╗   ███╗ ██████╗ ███████╗\r\n██╔══██╗██╔══██╗██║████╗ ████║██╔═══██╗██╔════╝\r\n██████╔╝██████╔╝██║██╔████╔██║██║   ██║███████╗\r\n██╔═══╝ ██╔══██╗██║██║╚██╔╝██║██║   ██║╚════██║\r\n██║     ██║  ██║██║██║ ╚═╝ ██║╚██████╔╝███████║\r\n╚═╝     ╚═╝  ╚═╝╚═╝╚═╝     ╚═╝ ╚═════╝ ╚══════╝\r\n                                               ");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Insira um valor inteiro inicial: ");
                    int inicial = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira um valor inteiro final: ");
                    int final = int.Parse(Console.ReadLine());

                    




                break;

                default:
                    Console.Clear();

                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("\n██╗  ██╗██╗  ██╗██╗  ██╗██╗  ██╗██╗  ██╗    ███╗   ███╗████████╗    ██████╗ ██╗   ██╗██████╗ ██████╗  ██████╗     ██╗██╗██╗\r\n██║ ██╔╝██║ ██╔╝██║ ██╔╝██║ ██╔╝██║ ██╔╝    ████╗ ████║╚══██╔══╝    ██╔══██╗██║   ██║██╔══██╗██╔══██╗██╔═══██╗    ██║██║██║\r\n█████╔╝ █████╔╝ █████╔╝ █████╔╝ █████╔╝     ██╔████╔██║   ██║       ██████╔╝██║   ██║██████╔╝██████╔╝██║   ██║    ██║██║██║\r\n██╔═██╗ ██╔═██╗ ██╔═██╗ ██╔═██╗ ██╔═██╗     ██║╚██╔╝██║   ██║       ██╔══██╗██║   ██║██╔══██╗██╔══██╗██║   ██║    ╚═╝╚═╝╚═╝\r\n██║  ██╗██║  ██╗██║  ██╗██║  ██╗██║  ██╗    ██║ ╚═╝ ██║   ██║       ██████╔╝╚██████╔╝██║  ██║██║  ██║╚██████╔╝    ██╗██╗██╗\r\n╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝    ╚═╝     ╚═╝   ╚═╝       ╚═════╝  ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝     ╚═╝╚═╝╚═╝ \n\n");
                break;
            }




            Console.ReadLine();

        }
    }
}
