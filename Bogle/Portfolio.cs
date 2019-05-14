using System;
using System.Collections.Generic;
using System.Linq;

namespace Bogle {
    public class Portfolio {
        readonly Instrument[] instruments;

        public Portfolio(params Instrument[] instruments) {
            this.instruments = instruments;
        }

        public Dictionary<Category, Transaction> RebalanceInternally(Dictionary<Category, double> targets) {
            var totalInvestment = instruments.Sum(i => i.Value);
            var orderedInstruments = instruments.OrderByDescending(i => i.Value).ToArray();
            var deltas = new Dictionary<Category, Transaction>();

            Console.WriteLine("---Start---");
            for (int j = 0; j < 2; j++) {
                Console.WriteLine("Iteration " + j + 1 + ":");
                for (int i = 0; i < orderedInstruments.Length; i++) {
                    var investment = orderedInstruments[i];
                    var target = totalInvestment * (decimal)targets[investment.Category];
                    var delta = target - investment.Value;
                    totalInvestment += delta;
                    var ratio = (investment.Value + delta) / totalInvestment;
                    var transaction = new Transaction(target, delta, (double)ratio);
                    Console.WriteLine(transaction);
                    //deltas.Add(investment.Category, transaction);
                }
                Console.WriteLine("");
            }

            Console.WriteLine("---End---");
            return deltas;
        }

        // RebalanceUsingLumpSum

        // RebalanceSellingToValue
    }
}
