/*
 * Created by SharpDevelop.
 * User: pedro
 * Date: 24/06/2025
 * Time: 19:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p3
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<String> listaVazia = new List<String>();
            if (listaVazia.Count == 0)
            {
                Console.WriteLine("A lista está vazia.");
            }

            else
            {
                Console.WriteLine("Lista não está vazia.");
            }

            Console.ReadKey(true);
        }
    }
}
