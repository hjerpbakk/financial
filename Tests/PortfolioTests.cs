using System;
using System.Collections.Generic;
using Bogle;
using Xunit;

namespace Tests {
    public class PortfolioTests {
        [Fact]
        public void Rebalance() {
            var largeGrowth = new Instrument("LargeGrowth", Category.LargeGrowth, 130m);
            var smallValue = new Instrument("SmallValue", Category.SmallValue, 40m);
            var mediumBlend = new Instrument("MediumBlend", Category.MediumBlend, 40m);
            var targets = new Dictionary<Category, double> {
                { Category.LargeGrowth, 0.60D },
                { Category.SmallValue, 0.20D },
                { Category.MediumBlend, 0.20D }
            };

            var portfolio = new Portfolio(smallValue, largeGrowth, mediumBlend);
            var delta = portfolio.RebalanceInternally(targets);

            Assert.NotNull(delta);
        }
    }
}
