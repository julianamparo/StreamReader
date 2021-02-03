using System;

namespace StreamReader
{
    public class Program
    {
        Principal p = new Principal();
        static void Main(string[] args)
        {
            string opcao = "0";
            while (opcao != "3")
            {
                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1 - Encontrar Vogal");
                Console.WriteLine("2 - Teste Unitário");
                Console.WriteLine("3 - Sair");

                Console.WriteLine("Selecione uma opção do menu: ");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.WriteLine("Digite o conjunto de caracteres a ser verificado:");
                    string conjunto = Console.ReadLine();

                    char vogal = Principal.EncontraVogal(conjunto);
                    if (vogal != ' ')
                        Console.WriteLine("Vogal Encontrada: " + vogal);
                    else
                        Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");
                }

                if (opcao == "2")
                {
                    //Teste com 5 palavras aleatórias
                    UnitTest testeUnitario = new UnitTest();
                    testeUnitario.Testar();

                }
            }
        }
    }
}

