﻿using System;

namespace GuessingGameInfinite
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm genereerib juhusliku numbri 1 kuni 10
			//kasutaja peab arvama numbri
			//kui kasutaja arvab õigesti siis on võitja
			//katsete arv piiramatu
			//programm genereerib juhuslikku numbrit ühte korda

			Random rnd = new Random();
			int cpuNumber = rnd.Next(1, 11);

			bool win = false;

			while (win == false)
			{
				Console.WriteLine("Vali number 1-10");
				string userNumber = Console.ReadLine();

				int i = int.Parse(userNumber);

				if (i == cpuNumber)
				{
					Console.WriteLine("Arvasid õigesti!");
					break;
				}

				else
				{
					Console.WriteLine("Arvasid valesti!");
				}

			}
			

		}
	}
}
