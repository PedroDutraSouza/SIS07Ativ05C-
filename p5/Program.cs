/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 19:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int idade = 20;
            int idadeMinima = 18;

            if (idade >= idadeMinima)
            {
                Console.WriteLine("A condição é verdadeira! A pessoa é maior de idade.");
            }
            else
            {
                Console.WriteLine("A condição é falsa! A pessoa é menor de idade.");
            }

            Console.ReadKey(true);
        }
    }
}
