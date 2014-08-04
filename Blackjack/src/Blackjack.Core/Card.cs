
using System;

namespace Blackjack.Core
{

	public class Card
	{
		string _rank, _suit;
		int _value = 0;
		public Card(string rank, string suit)
		{
			_rank = rank;
			_suit = suit; 
		}
		public Card(string rank)
		{
			_rank = rank;
			_suit = "Spades";
		}
		public string Rank(){
			return _rank;
		}
		public string Suit(){
			return _suit;
		}
		public int Value(){
			if (_rank == "A")
			{	_value = 11; }
			else {
				if ( _rank == "K" || _rank == "Q" || _rank == "J" )
				{	_value = 10; }
				else {
					try { _value = int.Parse(_rank); }
					catch { Exception e; }
				}
			}
			if ( _value >= 2 && _value <=11 )
			{	return _value; }
			else
			{	return 0; }
		
		}
		public override string ToString(){
			return Rank();
		}
		public static Card Parse(string rank){
			return new Card(rank);
		}
			
	}
}
