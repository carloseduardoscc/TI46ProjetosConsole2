using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI46ProjetosConsole2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escolherLista();
        }

        public static void escolherLista()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- GERENCIADOR DE LISTAS -----------\nDigite o número da lista [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Lista1.escolherExercicio();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
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
    }
}
