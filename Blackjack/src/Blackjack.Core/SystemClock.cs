using System;

namespace Blackjack.Core {
	public static class SystemClock {

		private static DateTime? fixedTime;

		public static DateTime Now {
			get {
				if (fixedTime.HasValue)
					return fixedTime.Value;
				return DateTime.Now;
			}
		}

		public static void Set(DateTime value) {
			fixedTime = value;
		}

		public static void Reset() {
			fixedTime = null;
		}
	}
}

