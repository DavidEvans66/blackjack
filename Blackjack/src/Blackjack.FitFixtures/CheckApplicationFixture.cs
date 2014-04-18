using System;
using fit;
using Blackjack.Core;

namespace Blackjack.FitFixtures
{
    public class CheckApplicationFixture: ColumnFixture{
        public string Name() {
            return ApplicationInfo.ApplicationName;
        }
    }
}


