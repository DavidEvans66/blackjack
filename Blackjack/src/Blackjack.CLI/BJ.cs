﻿using System;
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
			Console.WriteLine("Your Hand is: {0}", game.PlayerCard());
			Console.WriteLine("Dealer Hand is: {0}", game.DealerCard());
			// Player Actions
			
			// Dealer Actions
			
			// Game Outcomes
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}