using System;
using System.Collections.Generic;
using Ispit.Model;

namespace Ispit.Konzola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Ucenik> popisUcenika = new List<Ucenik>();

			for (int i = 0; i < 3; i++)
			{
				Ucenik noviUcenik = DodajUcenika();
				if (noviUcenik != null)
				{
					popisUcenika.Add(noviUcenik);
				}
			}

			foreach (var ucenik in popisUcenika)
			{
				string ocjena = ucenik.IspisProsjeka();
				Console.WriteLine($"\n{ucenik.Ime} {ucenik.Prezime}, Starost: {ucenik.Starost()} godina, Prosjek: {ocjena}");
			}

			Console.ReadLine();
		}

		static Ucenik DodajUcenika()
		{
			Console.Write("\nUnesite ime ucenika:");
			string ime = Console.ReadLine();

			Console.Write("Unesite prezime ucenika:");
			string prezime = Console.ReadLine();

			Console.Write("Unesite datum rodjenja u formatu yyyy-MM-dd:");
			string dateInput = Console.ReadLine();

			DateTime datumRodjenja = new DateTime(1900, 1, 1);

			if (DateTime.TryParse(dateInput, out DateTime date))
			{
				datumRodjenja = DateTime.Parse(dateInput);
			}
			else
			{
				Console.WriteLine("Datum nije unesen u pravilnom formatu");
			}

			Console.Write("Unesite prosjek ucenika:");
			double prosjek = double.Parse(Console.ReadLine());

			if (prosjek < 1.00 || prosjek > 5.01)
			{
				Console.Write("Prosjek mora biti izmedju 1 i 5");
			}

			return new Ucenik(ime, prezime, datumRodjenja, prosjek);
		}
	}
}