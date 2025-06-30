/*
 * Created by SharpDevelop.
 * User: Pedro
 * Date: 24/06/2025
 * Time: 19:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string vazia = "";
            if (vazia.Length == 0)
            {
                Console.WriteLine("A string está vazia.");
            }

            else
            {
                Console.WriteLine("String não está vazia.");
            }

            Console.ReadKey(true);
        }
    }
}
