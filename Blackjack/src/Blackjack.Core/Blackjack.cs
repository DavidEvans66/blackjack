using System;

namespace Blackjack.Core
{
	public class BlackjackApplication
	{
		string[] shoe = new string[] {};
   		public static void Main(string[] args)
   		{
       		Console.WriteLine("Number of command line parameters = {0}", args.Length);
       		foreach(string s in args)
       		{
          		Console.WriteLine(s);
       		}
  		}
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
			return "nothing";
		}
		public string DealerCard(){
			return "nothing";
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
		