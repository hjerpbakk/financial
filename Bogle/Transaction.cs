using System;
namespace Bogle {
    public class Transaction {
        public Transaction(decimal target, decimal delta, double ratio) {
            Target = target;
            Delta = delta;
            Ratio = ratio;
        }

        public decimal Target { get; }
        public decimal Delta { get; }
        public double Ratio { get; }

        public override string ToString() =>
        $"Target {Target}, Delta {Delta}, Ratio {Ratio}";
    }
}
