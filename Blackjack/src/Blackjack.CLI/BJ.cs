using System;
using Blackjack.Core;

namespace Blackjack.CLI
{
	class BJ
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Blackjack!");
			Console.WriteLine("(c) 2014 Dylan and Dad");
			// Start the game
			BlackjackApplication game = new BlackjackApplication();
			game.SetupShoe(args);
			// Deal
			game.DealCards();
			// Show hands
			Console.WriteLine("Your Hand is: {0}", game.PlayerCard().ToString());
			Console.WriteLine("Dealer Hand is: {0}", game.DealerCard().ToString());
			// Player Actions
			
			// Dealer Actions
			
			// Game Outcomes
			Console.WriteLine("The result is ...:{0}", game.PlayerResult());
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}