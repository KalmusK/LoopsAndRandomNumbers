using System;

namespace LoopsAndRandomNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajal sisestada pin kood
			//programm võrdleb pin koodi arvuga 1234
			//kui on pin kood on sama mis arv 1234 siis konsool kuvab tere tulemast
			//kui sisestatud pin kood on muud siis ütleb "Vale PIN. proovi uuesti"
			//kasutajal on kolm katset. i on alguses 0. kuni i < 3.


			int i = 0; //i on iteration

			while (i < 3)  // seni kuni i on väiksem kui 3 siis laseb programmi uuesti läbi.
			{
		
				Console.WriteLine("Sisesta PIN:");
				int userPIN = Convert.ToInt32(Console.ReadLine());


				if (userPIN == 1234)
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}

				else // kui paneb valesti, siis lisab i +1 ehk siis katsete arv väheneb.
				{
					//i = i + 1;
					i++;
					Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
				}


				
			}
									

			Console.WriteLine("Kena päeva!");
		}
	}
}
