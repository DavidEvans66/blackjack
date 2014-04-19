using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures
{
    public class PlayerOutcomeFixture: ColumnFixture{
        public string PlayerCard, DealerCard;
        public string PlayerOutcome() {
        	BlackjackApplication game = new BlackjackApplication();
        	return game.Result(PlayerCard, DealerCard);
        }
    }
}

