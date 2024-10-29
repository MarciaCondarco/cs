using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aula02
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExibirCabecalho();
            ExibirOpcoesMenu();
            
        }
        public static void ExibirCabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("═════════════════════════");
            Console.WriteLine("autor: Marcia Condarco");
            Console.WriteLine("\n*********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
░██████╗███████╗███╗░░██╗░█████╗░░█████╗░░░░░░░░█████╗░███╗░░░███╗███████╗██████╗░██╗░█████╗░░█████╗░███╗░░██╗░█████╗░
██╔════╝██╔════╝████╗░██║██╔══██╗██╔══██╗░░░░░░██╔══██╗████╗░████║██╔════╝██╔══██╗██║██╔══██╗██╔══██╗████╗░██║██╔══██╗
╚█████╗░█████╗░░██╔██╗██║███████║██║░░╚═╝█████╗███████║██╔████╔██║█████╗░░██████╔╝██║██║░░╚═╝███████║██╔██╗██║███████║
░╚═══██╗██╔══╝░░██║╚████║██╔══██║██║░░██╗╚════╝██╔══██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║██║░░██╗██╔══██║██║╚████║██╔══██║
██████╔╝███████╗██║░╚███║██║░░██║╚█████╔╝░░░░░░██║░░██║██║░╚═╝░██║███████╗██║░░██║██║╚█████╔╝██║░░██║██║░╚███║██║░░██║
╚═════╝░╚══════╝╚═╝░░╚══╝╚═╝░░╚═╝░╚════╝░░░░░░░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝╚═╝░╚════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
            Console.WriteLine("═════════════════════════");
            Console.ResetColor();
            Console.WriteLine("ajkajfafdf");
        }
        public static void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nDigite 1 para registrar informações");
            Console.WriteLine("\nDigite 2 para listar informações");
            Console.WriteLine("\nDigite 3 para apagar informações");
            Console.WriteLine("\nDigite -1 para sair \n");
            Console.WriteLine("\nDigite a opções Escolhida");
            int opcaoEscolhidaNumero = int.Parse(Console.ReadLine());
            //string opcaoEscolhido=Console.ReadLine();
            //int opcaoEscolhidoNumero = int.Parse(opcaoEscolhido);

            /*
            if (opcaoEscolhidaNumero == 1)
            {
                Console.WriteLine("você escolheu o 1");
            }
            if (opcaoEscolhidaNumero == 2)
            {
                Console.WriteLine("você escolheu o 2");
            }
            */

            switch(opcaoEscolhidaNumero) 
            {
                case 1:
                    Cadinfo();
                    
                    break;
                case 2:
                    Console.WriteLine("você escolheu o 2");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;
                case 3:
                    Console.WriteLine("você escolheu o 3");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;
                case 0:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(@"

█▀ ▄▀█ █ █▄░█ █▀▄ █▀█
▄█ █▀█ █ █░▀█ █▄▀ █▄█");
                    Thread.Sleep(3000);
                    break;

                default:
                    Console.WriteLine("\nVocê digitou a opção invalida");
                    Thread.Sleep(3000);
                    Console.Clear();
                    ExibirCabecalho();
                    ExibirOpcoesMenu();
                    break;
            }
        }
private static void Cadinfo()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de cliente");
            Console.WriteLine("Digte seu nome");
            string NomeDoUsuario = Console.ReadLine();  
            Console.WriteLine($"\n Nome Cadastrado com Sucesso!! {NomeDoUsuario}");
            Thread.Sleep(3000);
            ExibirCabecalho();
            ExibirOpcoesMenu();

        }

    }
}
