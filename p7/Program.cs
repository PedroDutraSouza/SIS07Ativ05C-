/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p7
{
    class Program
    {
        public static void Main(string[] args)
        {

            double numero = -10;

            if (numero > 0)
            {
                Console.WriteLine("O número é positivo.");
            }

            else if (numero < 0)
            {
                Console.WriteLine("O número é negativo.");
            }

            else
            {
                Console.WriteLine("O número é zero.");
            }

            Console.ReadKey(true);
        }
    }
}