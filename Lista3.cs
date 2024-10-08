using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TI46ProjetosConsole2
{
    internal class Lista3
    {

        public static void escolherExercicio()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- LISTA 3 -----------\nDigite o número do exercício para executar [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Exercício 1");
                        exercicio1();
                        break;

                    case "2":
                        Console.WriteLine("\nExercício 2");
                        exercicio2();
                        break;

                    case "3":
                        Console.WriteLine("\nExercício 3");
                        exercicio3();
                        break;

                    case "4":
                        Console.WriteLine("\nExercício 4");
                        exercicio4();
                        break;

                    case "5":
                        Console.WriteLine("\nExercício 5");
                        exercicio5();
                        break;

                    case "6":
                        Console.WriteLine("\nExercício 6");
                        exercicio6();
                        break;

                    case "7":
                        Console.WriteLine("\nExercício 7");
                        exercicio7();
                        break;

                    case "8":
                        Console.WriteLine("\nExercício 8");
                        exercicio8();
                        break;

                    case "9":
                        Console.WriteLine("\nExercício 9");
                        exercicio9();
                        break;

                    case "10":
                        Console.WriteLine("\nExercício 10");
                        exercicio10();
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Opção inválida!\n\n");
                        break;
                }
                Console.WriteLine("\n[ Enter ]");
                Console.ReadKey();
            } while (input != "0");
        }

        private static void exercicio10()
        {
        }

        private static void exercicio9()
        {
        }

        private static void exercicio8()
        {
        }

        private static void exercicio7()
        {
        }

        private static void exercicio6()
        {
        }

        private static void exercicio5()
        {
        }

        private static void exercicio4()
        {
        }

        private static void exercicio3()
        {
        }

        private static void exercicio2()
        {
        }

        private static void exercicio1()
        {
        }
    }
}
