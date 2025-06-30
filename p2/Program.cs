/*
 * Created by SharpDevelop.
 * User: pedro
 * Date: 09/06/2025
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace p2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("==========================");
			Console.WriteLine("       MAIOR NÚMERO       ");
			Console.WriteLine("==========================");
			Console.WriteLine("Digite o primeiro número: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.Clear();
			
			Console.WriteLine("==========================");
			Console.WriteLine(" 	  MAIOR NÚMERO       ");
			Console.WriteLine("==========================");
			Console.WriteLine("Digite o segundo número: ");
			int ndois = int.Parse(Console.ReadLine());
			
			Console.Clear();
			
			if (num > ndois)
			{
				Console.WriteLine("============================");
				Console.WriteLine("        MAIOR NÚMERO        ");
				Console.WriteLine("============================");
        		Console.WriteLine("O número " + num + " é maior que " + ndois + ".");
				Console.ReadKey(true);
			}
			if (ndois > num)
			{
				Console.WriteLine("============================");
				Console.WriteLine("        MAIOR NÚMERO        ");
				Console.WriteLine("============================");
        		Console.WriteLine("O número " + ndois + " é maior que " + num + ".");
				Console.ReadKey(true);
			}
			else
			{
				Console.WriteLine("============================");
				Console.WriteLine("        MAIOR NÚMERO        ");
				Console.WriteLine("============================");
        		Console.WriteLine("Os dois números são iguais.");
				Console.ReadKey(true);
			}
		}
	}
}