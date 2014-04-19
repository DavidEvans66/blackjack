using System;

namespace Blackjack.Core
{
	public class BlackjackApplication
	{
		public string Result( int PlayerValue, int DealerValue) {
			if ( PlayerValue >= DealerValue )
				return "Win";
			return "Lose";
		}
		public int GetCardValue(string Card) {
			int _value = 0;
			if (Card == "A")
			{	_value = 11; }
			else {
				if ( Card == "K" || Card == "Q" || Card == "J" )
				{	_value = 10; }
				else {
					try { _value = int.Parse(Card); }
					catch { Exception e; }
				}
			}
			if ( _value >= 2 && _value <=11 )
			{	return _value; }
			else
			{	return 0; }
		}
	}
}
		