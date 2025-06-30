/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 20:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p8
{
    class Program
    {
        public static void Main(string[] args)
        {

            string textoNumero = "123";
            int numeroConvertido;

            bool sucesso = int.TryParse(textoNumero, out numeroConvertido);

            if (sucesso)
            {
                Console.WriteLine($"Conversão bem-sucedida! O número é: {numeroConvertido}");
                Console.WriteLine($"Podemos agora fazer cálculos com ele: {numeroConvertido} * 2 = {numeroConvertido * 2}");
            }
            else
            {
                Console.WriteLine($"Falha na conversão. A string '{textoNumero}' não é um número inteiro válido.");
            }

            Console.ReadKey(true);
        }
    }
}
