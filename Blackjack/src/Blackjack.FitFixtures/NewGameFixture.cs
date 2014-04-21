using Blackjack.Core;
using System;
using fit;
using fitlibrary;

namespace Blackjack.FitFixtures
{
	public class NewGameFixture : DoFixture 
	{
		BlackjackApplication game;
		public NewGameFixture() {
			game = new BlackjackApplication();
			SetSystemUnderTest(game);
		}
	}
}
