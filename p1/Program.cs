/*
 * Created by SharpDevelop.
 * User: pedro
 * Date: 09/06/2025
 * Time: 17:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("==========================");
			Console.WriteLine(" VERIFICAÇÃO PAR OU IMPAR ");
			Console.WriteLine("==========================");
			Console.WriteLine("Digite um numero: ");
			int numero = int.Parse(Console.ReadLine());
			
			Console.Clear();
			
        	string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
        	
			Console.WriteLine("==========================");
			Console.WriteLine(" VERIFICAÇÃO PAR OU IMPAR ");
			Console.WriteLine("==========================");
        	Console.WriteLine("O número " + numero + " é " + resultado + ".");
			Console.ReadKey(true);
		}
	}
}