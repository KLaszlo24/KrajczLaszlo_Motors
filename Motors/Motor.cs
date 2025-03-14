using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
	internal class Motor
	{
		string brand;
		string nev;
		int releaseYear;
		double performance;
		double priceInEur;

		public Motor(string brand, string nev, int releaseYear, double performance, double priceInEur)
		{
			this.brand = brand;
			this.nev = nev;
			this.releaseYear = releaseYear;
			this.performance = performance;
			this.priceInEur = priceInEur;
		}

		public string Brand { get => brand;  }
		public string Nev { get => nev;  }
		public int ReleaseYear { get => releaseYear; }
		public double Performance { get => performance; }
		public double PriceInEur { get => priceInEur;  }
	}
}
