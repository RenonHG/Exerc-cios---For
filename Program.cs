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
            Console.WriteLine("1 - Números Pares em um intervalo");
            Console.WriteLine("2 - Sequência de Fibonacci");
            Console.WriteLine("3 - Numeros Primos no intervalo");
            Console.Write("Escolha a opção desejada: ");
            //Console.Clear();
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
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
                    Console.ForegroundColor= ConsoleColor.DarkGreen;
                    Console.WriteLine("\nNesse intervalo há " +  quantidade + " número pares!");
                break;

                case 2:
                    Console.Write("Slv Q-brada, Sequência de Fibonacci presente, fale um número aí de quantas operações tu quer meu princeso: ");
                    int operacao = int.Parse(Console.ReadLine());
                    float fibonacci = 0;
                    float atual = 1;
                    float anterior = 0;
                   
                    
                    for (int i = 1; i <= operacao; i++)
                    {
                       
                          






                    }







                break;

            }




            Console.ReadLine();

        }
    }
}
