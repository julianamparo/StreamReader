using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReader
{
    public class UnitTest
    {
        string teste1 = "Abbgaababacfe";
        string teste2 = "poaekaekke";
        string teste3 = "BaliVXG234ea";
        string teste4 = "hu";
        string teste5 = "Ah";
        string teste6 = "Uhuuuueuuu";
        string teste7 = "Apeporosmameq";
        string teste8 = "b";
        string teste9 = "a";
        
        public void Testar()
        {
            char vogal = ' ';
            Console.WriteLine(teste1);
            vogal = Principal.EncontraVogal(teste1);
            if (vogal != ' ')
                Console.WriteLine("Vogal Encontrada: " + vogal);
            else
                Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");

            Console.WriteLine(teste2);
            vogal = Principal.EncontraVogal(teste2);
            if (vogal != ' ')
                Console.WriteLine("Vogal Encontrada: " + vogal);
            else
                Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");

            Console.WriteLine(teste3);
            vogal = Principal.EncontraVogal(teste3);
            if (vogal != ' ')
                Console.WriteLine("Vogal Encontrada: " + vogal);
            else
                Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");

            Console.WriteLine(teste4);
            vogal = Principal.EncontraVogal(teste4);
            if (vogal != ' ')
                Console.WriteLine("Vogal Encontrada: " + vogal);
            else
                Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");

            Console.WriteLine(teste5);
            vogal = Principal.EncontraVogal(teste5);
            if (vogal != ' ')
                Console.WriteLine("Vogal Encontrada: " + vogal);
            else
                Console.WriteLine("Nenhuma vogal atendeu os critérios necessários");
        }
    }
}
