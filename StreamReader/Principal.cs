using System;
using System.Collections.Generic;
using System.Text;

namespace StreamReader
{
    public class Principal
    {
        public static char EncontraVogal(string conjuntoLetras)
        {
            conjuntoLetras = conjuntoLetras.ToLower();
            bool consoante = false;
            char vogalEncontrada = ' ';
            string vogais = "aeiou";

            foreach (char letra in conjuntoLetras)
            {
                if (vogais.Contains(letra))
                {
                    //Verificação se já passou por uma consoante
                    if (consoante)
                        //Se sim, verifica se vogal é valida (não se repete no resto da string)
                        vogalEncontrada = VerificaVogalVálida(conjuntoLetras, letra);
                    if (vogalEncontrada != ' ')
                        return letra;
                    
                }
                else
                {
                    consoante = true;
                }
            }

            return vogalEncontrada;
        }

        private static char VerificaVogalVálida(string conjunto, char letra)
        {
            //Verifica quantas vezes a vogal se repete na string
            int qtd = conjunto.Split(letra).Length;

            if (qtd == 2)
                return letra;

            return ' ';
        }
    }
}
