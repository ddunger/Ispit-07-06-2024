using System;

namespace Ispit.Model


{
	public class Ucenik
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public DateTime DatumRodjenja { get; set; }
		public double Prosjek { get; set; }


		public Ucenik(string ime, string prezime, DateTime datumRodjenja, double prosjek)
		{
			Ime = ime;
			Prezime = prezime;
			DatumRodjenja = datumRodjenja;
			Prosjek = Math.Round(prosjek, 2);
		}


		public int Starost()
		{
			DateTime today = DateTime.Now;
			int years = today.Year - DatumRodjenja.Year;

			if (DatumRodjenja.Month < today.Month)
			{
				years--;
			}
			return years;
		}

		public string IspisProsjeka()
		{
			string ispis = string.Empty;

			if (Prosjek >= 1.00 && Prosjek <= 1.49)
			{
				ispis = "nedovoljan";
			}
			else if (Prosjek >= 1.50 && Prosjek <= 2.49)
			{
				ispis = "dovoljan";
			}
			else if (Prosjek >= 2.50 && Prosjek <= 3.49)
			{
				ispis = "dobar";
			}
			else if (Prosjek >= 3.50 && Prosjek <= 4.49)
			{
				ispis = "vrlo dobar";
			}
			else if (Prosjek >= 4.50 && Prosjek <= 5.00)
			{
				ispis = "odličan";
			}
			else
			{
				ispis = $"Došlo je do pogreške, unijeli ste prosjek {Prosjek}.";
			}

			return ispis;

		}
	}


}
