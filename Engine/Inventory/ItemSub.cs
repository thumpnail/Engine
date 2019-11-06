using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Inventory {
    public class Effect {
        public string ID { get; }
        public string name { get; }
        public double value { get; }
        public string description { get; }
        public Effect(string ID, string name, double value, string description) {
            this.ID = ID;
            this.name = name;
            this.value = value;
            this.description = description;
        }
    }
    public class Buff {
        public string ID { get; }
        public string name { get; }
        public int value { get; }
        public string description { get; }
    }
    public class Book {

    }
    public class Paper {

    }
    public class Map {

    }
}
