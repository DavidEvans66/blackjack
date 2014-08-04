using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures
{
	public class CardValuesFixture: ColumnFixture{
        public string Rank;
        public int Value() {
        	Card aCard = new Card(Rank);
        	return aCard.Value();
        }
    }
}

