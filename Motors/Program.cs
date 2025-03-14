using System;

namespace Motors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika stat = new Statisztika();
			stat.Readfromfile("motors.txt");

			Console.WriteLine();
			Console.WriteLine("Ennyi az össz ár a megadott motorból: " + stat.SumBaseOnBrand("Royal Enfield", "motors.txt"));


			Console.WriteLine();
			Console.WriteLine("Össz ár: " + stat.SumPrices() + " Euro");

			Console.WriteLine();
			Console.WriteLine("Tratalmazza a lista a megadott nevet: " + stat.Contains("Pulsar NS400Z"));

			Console.WriteLine();
			Console.WriteLine("A legidősebb motor: " + stat.Oldest().Nev);

			Console.WriteLine();
			stat.Sort();
		}
	}
}
