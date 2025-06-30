/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p10
{
    class Program
    {
        public static void Main(string[] args)
        {

            string meuTexto = null; 
            VerificarSeEhNulo(meuTexto);

            meuTexto = "Olá, mundo!"; 
            VerificarSeEhNulo(meuTexto);
        }

        static void VerificarSeEhNulo(string variavel)
        {
            
            if (variavel == null)
            {
                Console.WriteLine("A variável é nula.");
            }

            else
            {
                Console.WriteLine($"A variável não é nula. Seu valor é: '{variavel}'");
            }

            string textoSeguro = variavel ?? "Valor Padrão (porque era nulo)";
            Console.WriteLine($"Usando ??, o texto seguro é: '{textoSeguro}'\n");
        }
    }
    
}
