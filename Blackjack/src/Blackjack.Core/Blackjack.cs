using System;

namespace Blackjack.Core
{
	public class BlackjackApplication
	{
		string[] shoe = new string[] {};
  		public void SetupShoe(string[] Cards){
			// TODO
		}
		public string[] Shoe(){
			return shoe;
		}
		public bool DealCards(){
			return false; // TODO return true when implemented
		}
		public string PlayerCard(){
			return "0";
		}
		public string DealerCard(){
			return "0";
		}
		
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
		