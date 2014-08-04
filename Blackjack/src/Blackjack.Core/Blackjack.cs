using System;

namespace Blackjack.Core
{
	public class BlackjackApplication
	{
		Card[] shoe = new Card[52];
		Card _playerCard, _dealerCard;
  		public void SetupShoe(string[] CardRanks){
			for (int i = 0; i< CardRanks.Length; i++)
			{
				shoe[i] = new Card(CardRanks[i]);
			}
		}
		public Card[] Shoe(){
			return shoe;
		}
		public bool DealCards(){
			_playerCard = shoe[0];
			_dealerCard = shoe[1];
			return true; 
		}
		public Card PlayerCard(){
			return _playerCard;
		}
		public Card DealerCard(){
			return _dealerCard;
		}
		public string PlayerResult(){
			return Result(_playerCard.Value(), _dealerCard.Value());
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
		