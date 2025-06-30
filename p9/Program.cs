/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p9
{
    class Program
    {
        public static void Main(string[] args)
        {

            int dividendo = 10;
            int divisor = 2;

            if (dividendo % divisor == 0)
            {
                Console.WriteLine($"{dividendo} é divisível por {divisor}.");
            }

            else
            {
                Console.WriteLine($"{dividendo} não é divisível por {divisor}. O resto é {dividendo % divisor}.");
            }

            Console.ReadKey(true);
        }
    }
}