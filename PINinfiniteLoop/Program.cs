using System;

namespace PINinfiniteLoop
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada pin kood
			//programm võrdleb pin koodi arvuga 1234
			//kui on pin kood on sama mis arv 1234 siis konsool kuvab tere tulemast
			//kui sisestatud pin kood on muud siis ütleb "Vale PIN. proovi uuesti"
			//kasutajal on lõpmatu arv katseid

			bool loopActive = true; //boolean --> true/false
			int i = 0;


			while (loopActive)
			{
				Console.WriteLine("Sisesta PIN:");
				int userPIN = Convert.ToInt32(Console.ReadLine());

				if (userPIN == 1234)
				{
					Console.WriteLine("Tere tulemast!");
					loopActive = false;
				}

				else
				{
					i++;
					Console.WriteLine("Vale PIN, proovi uuesti.");
					Console.WriteLine($"Oled vale PIN koodi {i} korda sisestanud");
				}
			}

			Console.WriteLine("Kena päeva!");
		}
	}
}
