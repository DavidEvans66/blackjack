using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures {

	public class SetSystemClockFixture: Fixture {
		public override void DoTable(fit.Parse table) {
			if (Args.Length < 1) {
				throw new ArgumentException("Date and time must be supplied");
			}
			SystemClock.Set(DateTime.Parse(Args[0]));
		}
	}

	public class ResetSystemClockFixture : Fixture {
		public override void DoTable(fit.Parse table) {
			SystemClock.Reset();
		}
	}
	
	public class CheckTimeFixture: ColumnFixture {
		public DateTime? SystemClockTime {
			get { return SystemClock.Now; }
		}
		public DateTime? DateTimeNow {
			get { return DateTime.Now; }
		}
		public TimeSpan? Diff {
			get { return SystemClock.Now - DateTime.Now; }
		}
	}


}

