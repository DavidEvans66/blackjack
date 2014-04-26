using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures
{
	public class CardValuesFixture: ColumnFixture{
        public string Card;
        public int Value() {
        	BlackjackApplication game = new BlackjackApplication();
        	return game.GetCardValue(Card);
        }
    }
}

