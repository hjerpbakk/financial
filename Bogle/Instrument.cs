using System;

namespace Bogle {
    public class Instrument {
        public Instrument(string name, Category category, decimal value) {
            Name = name;
            Category = category;
            Value = value;
        }

        public string Name { get; }
        public Category Category { get; }
        public decimal Value { get; }
    }
}
