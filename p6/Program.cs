/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 20:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p6
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            double numero = -15.5;
            double resultado;

            resultado = Math.Abs(numero);

            Console.WriteLine($"O valor absoluto de {numero} é {resultado}.");

            Console.ReadKey(true);
        }
    }
}