using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXERCITANDO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exibircabecalho();
            MenuExercicio();
        }
        public static void Exibircabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Marcia Gisseli Mamani Condarco");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
██████╗░██████╗░░█████╗░░░░░░██╗███████╗████████╗░█████╗░██╗
██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝╚══██╔══╝██╔══██╗╚═╝
██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░░░░██║░░░██║░░██║░░░
██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░░░░██║░░░██║░░██║░░░
██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗░░░██║░░░╚█████╔╝██╗
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝░░░╚═╝░░░░╚════╝░╚═╝

███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗████████╗░█████╗░███╗░░██╗██████╗░░█████╗░
██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║╚══██╔══╝██╔══██╗████╗░██║██╔══██╗██╔══██╗
█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║░░░██║░░░███████║██╔██╗██║██║░░██║██║░░██║
██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║░░░██║░░░██╔══██║██║╚████║██║░░██║██║░░██║
███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║░░░██║░░░██║░░██║██║░╚███║██████╔╝╚█████╔╝
╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
            MenuExercicio();

        }
        public static void MenuExercicio()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - exercicio 01");
            Console.WriteLine("2 - exercicio 02");
            Console.WriteLine("3 - exercicio 03");
            Console.WriteLine("4 - exercicio 04");
            Console.WriteLine("5 - exercicio 05");
            Console.WriteLine("6 - exercicio 06");
            Console.WriteLine("Escolha o exercicio que você gostaria de fazer?");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            switch(numeroEscolhido)
            {
                case 1:
                    Console.Clear();
                    ExercicioNumeroUm();
                    break;
                case 2:
                    Console.Clear();
                    ExercicioNumeroDois();
                    break;
                case 3:
                    Console.Clear();
                    ExercicioNumeroTres();
                    break;
                case 4:
                    Console.Clear();
                    ExercicioNumeroQuarto();
                    break;
                case 5:
                    Console.Clear();
                    ExercicioNumeroCinco();
                    break;
                case 6: 
                    Console.Clear();
                    ExercicioNumeroSexto();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
            
        }
        public static void ExercicioNumeroUm()
        {
            Console.WriteLine("Crie um programa que leia a idade de uma pessoa e informe se ela é maior de idade (18 anos ou mais) ou menor de idade.\n");
            Console.WriteLine("Informe sua idade:");
            int primeiroexercicio = int.Parse(Console.ReadLine());
            if ( primeiroexercicio >=18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(@"Você é 
█▀▄▀█ ▄▀█ █ █▀█ █▀█   █▀▄ █▀▀   █ █▀▄ ▄▀█ █▀▄ █▀▀
█░▀░█ █▀█ █ █▄█ █▀▄   █▄▀ ██▄   █ █▄▀ █▀█ █▄▀ ██▄\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"Você é 
█▀▄▀█ █▀▀ █▄░█ █▀█ █▀█   █▀▄ █▀▀   █ █▀▄ ▄▀█ █▀▄ █▀▀
█░▀░█ ██▄ █░▀█ █▄█ █▀▄   █▄▀ ██▄   █ █▄▀ █▀█ █▄▀ ██▄\n");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();

        }
        public static void ExercicioNumeroDois()
        {
            Console.WriteLine("Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).\n");
            Console.WriteLine("Informe a nota que recebeu na prova");
            int segundoexercicio = int.Parse(Console.ReadLine());
            if (segundoexercicio > 6)
            {
                Console.WriteLine(@"
░█████╗░██████╗░██████╗░░█████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗
███████║██████╔╝██████╔╝██║░░██║╚██╗░██╔╝███████║██║░░██║██║░░██║
██╔══██║██╔═══╝░██╔══██╗██║░░██║░╚████╔╝░██╔══██║██║░░██║██║░░██║
██║░░██║██║░░░░░██║░░██║╚█████╔╝░░╚██╔╝░░██║░░██║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░");
            }
            if (segundoexercicio <5)
            {
                Console.WriteLine(@"
██████╗░███████╗██████╗░██████╗░░█████╗░██╗░░░██╗░█████╗░██████╗░░█████╗░
██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██████╔╝██████╔╝██║░░██║╚██╗░██╔╝███████║██║░░██║██║░░██║
██╔══██╗██╔══╝░░██╔═══╝░██╔══██╗██║░░██║░╚████╔╝░██╔══██║██║░░██║██║░░██║
██║░░██║███████╗██║░░░░░██║░░██║╚█████╔╝░░╚██╔╝░░██║░░██║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░╚════╝░");
                
            }
            if(segundoexercicio >= 5)
            {
                Console.WriteLine(@"
██████╗░███████╗░█████╗░██╗░░░██╗██████╗░███████╗██████╗░░█████╗░░█████╗░░█████╗░░█████╗░
██╔══██╗██╔════╝██╔══██╗██║░░░██║██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░╚═╝██║░░░██║██████╔╝█████╗░░██████╔╝███████║██║░░╚═╝███████║██║░░██║
██╔══██╗██╔══╝░░██║░░██╗██║░░░██║██╔═══╝░██╔══╝░░██╔══██╗██╔══██║██║░░██╗██╔══██║██║░░██║
██║░░██║███████╗╚█████╔╝╚██████╔╝██║░░░░░███████╗██║░░██║██║░░██║╚█████╔╝██║░░██║╚█████╔╝
╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝░╚════╝░╚═╝░░╚═╝░╚════╝░");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();

        }
        public static void ExercicioNumeroTres()
        {
            Console.WriteLine("Escreva um programa que verifique se um número fornecido pelo usuário é positivo, negativo ou zero.\n");
            Console.WriteLine("Informe um numero");
            int NumeroEscolhidoExercicioTres = int.Parse(Console.ReadLine());
            if(NumeroEscolhidoExercicioTres >= 1)
            {
                Console.WriteLine(@"
██████╗░░█████╗░░██████╗██╗████████╗██╗██╗░░░██╗░█████╗░
██╔══██╗██╔══██╗██╔════╝██║╚══██╔══╝██║██║░░░██║██╔══██╗
██████╔╝██║░░██║╚█████╗░██║░░░██║░░░██║╚██╗░██╔╝██║░░██║
██╔═══╝░██║░░██║░╚═══██╗██║░░░██║░░░██║░╚████╔╝░██║░░██║
██║░░░░░╚█████╔╝██████╔╝██║░░░██║░░░██║░░╚██╔╝░░╚█████╔╝
╚═╝░░░░░░╚════╝░╚═════╝░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░░╚════╝░");
            }
            if(NumeroEscolhidoExercicioTres <0)
            {
                Console.WriteLine(@"
███╗░░██╗███████╗░██████╗░░█████╗░████████╗██╗██╗░░░██╗░█████╗░
████╗░██║██╔════╝██╔════╝░██╔══██╗╚══██╔══╝██║██║░░░██║██╔══██╗
██╔██╗██║█████╗░░██║░░██╗░███████║░░░██║░░░██║╚██╗░██╔╝██║░░██║
██║╚████║██╔══╝░░██║░░╚██╗██╔══██║░░░██║░░░██║░╚████╔╝░██║░░██║
██║░╚███║███████╗╚██████╔╝██║░░██║░░░██║░░░██║░░╚██╔╝░░╚█████╔╝
╚═╝░░╚══╝╚══════╝░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░░╚════╝░");
            }
            if(NumeroEscolhidoExercicioTres == 0)
            {
                Console.WriteLine(@"
███████╗███████╗██████╗░░█████╗░
╚════██║██╔════╝██╔══██╗██╔══██╗
░░███╔═╝█████╗░░██████╔╝██║░░██║
██╔══╝░░██╔══╝░░██╔══██╗██║░░██║
███████╗███████╗██║░░██║╚█████╔╝
╚══════╝╚══════╝╚═╝░░╚═╝░╚════╝░");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();

        }
        public static void ExercicioNumeroQuarto()
        {
            Console.WriteLine(" Crie um programa que leia três números e determine qual é o maior.\n");
            Console.WriteLine("informe um numero");
            int numeroprimeiro = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("informe outro numero");
            int numerosegundo = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("informe o ultimo numero");
            int numeroterceiro = int.Parse(Console.ReadLine());
            Console.Clear();
            if(numeroprimeiro > numerosegundo && numeroprimeiro > numeroterceiro)
            {
                Console.WriteLine($"{numeroprimeiro} é o maior numero\n");
            }
            if (numerosegundo>numeroprimeiro && numerosegundo > numeroterceiro)
            {
                Console.WriteLine($"{numerosegundo} é o maior numero\n");
            }
            if(numeroterceiro > numeroprimeiro && numeroterceiro > numerosegundo)
            {
                Console.WriteLine($"{numeroterceiro} é o numero maior\n");
            }

            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();
        }
        public static void ExercicioNumeroCinco()
        {
            Console.WriteLine("Crie um programa que determine se um ano é bissexto.");
            Console.WriteLine("Informe um ano desejado");
            int numeroAno = int.Parse(Console.ReadLine());
            Console.Clear();
            if (numeroAno % 4==0) 
            {
                Console.WriteLine("ano bissexto\n");
            }
            else
            {
                Console.WriteLine("Não é ano bissexto\n");
            }

            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();
        }
        public static void ExercicioNumeroSexto()
        {
            Console.WriteLine("Escreva um programa que leia o nome e a idade de uma pessoa e informe se ela pode votar e dirigir (idade mínima de 18 anos).\n");
            Console.WriteLine("Insira o seu nome:");
            string nome = (Console.ReadLine());
            Console.WriteLine("Insira a sua idade:");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($"{nome} pode dirigir e votar\n");
            }
            else
            {
                Console.WriteLine($"{nome} não pode dirigir e votar\n");
            }

            Thread.Sleep(3000);
            Console.Clear();
            Exibircabecalho();
        }
    }
}
