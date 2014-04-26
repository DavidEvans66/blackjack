using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures
{
    public class PlayerOutcomeFixture: ColumnFixture{
        public int PlayerValue, DealerValue;
        public string PlayerOutcome() {
        	BlackjackApplication game = new BlackjackApplication();
        	return game.Result(PlayerValue, DealerValue);
        }
    }
}

