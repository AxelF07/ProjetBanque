﻿using System;

namespace ProjetBanque
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}

		/*  Création de readInt et readDouble:  */

	public static int readInt()
	{
		int val = -1;
		bool erreurSaisie = false;
		do
		{
			try
			{
				val = int.Parse(Console.ReadLine());
				erreurSaisie = false;
			}
			catch (Exception)
			{
				Console.WriteLine("Veuillez saisir une valeur entiere");
				erreurSaisie = true;
			}
		} while (erreurSaisie);

		return val;
	}

	public static double readDouble()
	{
		double val = -1;
		bool erreurSaisie = false;
		do
		{
			try
			{
				val = double.Parse(Console.ReadLine());
				erreurSaisie = false;
			}
			catch (Exception)
			{
				Console.WriteLine("Veuillez saisir une valeur double");
				erreurSaisie = true;
			}
		} while (erreurSaisie);

		return val;
	}
	}
}
