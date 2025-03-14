using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
	internal class Statisztika
	{
		List<Motor> motors = [];

		public void Readfromfile(string filename)
		{
			StreamReader sr = new StreamReader(filename);
			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				string sor = sr.ReadLine() ?? ""; //?? ""  - két kérdőjel után meg lehet adni hogy mit írjon null érték esetén
				string[] szavak = sor.Split(';');

				Motor ujMotor = new Motor(szavak[0], szavak[1], Convert.ToInt16(szavak[2]), 
					Convert.ToDouble(szavak[3]), Convert.ToDouble(szavak[4]));

				motors.Add(ujMotor);
			}
		}

		public int SumPrices()
		{
			double sum = 0;

			for (int i = 0; i < motors.Count; i++)
			{
				sum += motors[i].PriceInEur;
			}
			return (int)sum;
		}

		public bool Contains(string motorName)
		{
			bool isThere = false;

			for (int i = 0;i < motors.Count; i++)
			{
				if (motors[i].Nev == motorName)
				{
					isThere = true;
				}
			}
			return isThere;
		}

		public Motor Oldest()
		{
			Motor oldestMotor = motors[0];

			for (int i = 1; i < motors.Count; i++)
			{
				if (oldestMotor.ReleaseYear > motors[i].ReleaseYear)
				{
					oldestMotor = motors[i];
				}
			}
			return oldestMotor;
		}

		public int SumBaseOnBrand(string BrandName, string filename)
		{
			List<Motor> brandMotors = new List<Motor>();

			for (int i = 0; i<motors.Count ; i++)
			{
				if (motors[i].Brand == BrandName)
				{
					brandMotors.Add(motors[i]);
				}
			}
			motors = brandMotors;
			int sum = this.SumPrices();
			motors.Clear();
			this.Readfromfile(filename);

			return sum;
		}

		public void Sort()
		{
			for (int i = motors.Count;i > 0; i--)
			{
				for (int j = 0; j < motors.Count-1; j++)
				{
					if (motors[j].Performance < motors[j+1].Performance)
					{
						Motor temp = motors[j];
						motors[j] = motors[j+1];
						motors[j+1] = temp;
					}
				}
			}
			Console.WriteLine("A motorok, teljesítményük szerint növekvő sorrendben:");
			for (int i = 0;i < motors.Count; i++)
				{
                
                Console.WriteLine("Neve: "+ motors[i].Nev + ", teljesítménye: " + motors[i].Performance);
				}
		}
	}
}
