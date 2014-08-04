using System;

namespace Blackjack.Core
{
	public class BlackjackApplication
	{
		string[] shoe = new string[] {};
		string _playerCard, _dealerCard;
  		public void SetupShoe(string[] Cards){
			shoe = Cards;
		}
		public string[] Shoe(){
			return shoe;
		}
		public bool DealCards(){
			_playerCard = shoe[0];
			_dealerCard = shoe[1];
			return true; 
		}
		public string PlayerCard(){
			return _playerCard;
		}
		public string DealerCard(){
			return _dealerCard;
		}
		public string PlayerResult(){
			return Result(GetCardValue(PlayerCard()),GetCardValue(DealerCard()));
		}
		public string Result( int PlayerValue, int DealerValue) {
			if ( PlayerValue >= DealerValue )
				return "Win";
			return "Lose";
		}
		public int GetCardValue(string Card) {
			Card aCard = new Card(Card);
			return aCard.Value();
		}
	}
}
		