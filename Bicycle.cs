using System;
using Lab5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
      public class Bicycle : IComparable<Bicycle>
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public double Price { get; set; }
        public int FrameLoadCapacity { get; set; }
        public double Weight { get; set; }
        public bool WasUsed { get; set; }
        public bool WasDamaged { get; set; }

        public double CalculateMaxPassengerWeight()
        {
            return FrameLoadCapacity - Weight;
        }
        public Bicycle() { }
        public Bicycle(string model, int year, string colour, double price, int frameLoadCapacity,
            double weight, bool wasUsed, bool wasDamaged)
        {
            Model = model;
            Year = year;
            Colour = colour;
            Price = price;
            FrameLoadCapacity = frameLoadCapacity;
            Weight = weight;
            WasUsed = wasUsed;
            WasDamaged = wasDamaged;
        }
          public string Info()
        {
            return $"{Model}, {Year}, {Colour}, {Price}, {FrameLoadCapacity}, {Weight}, Used: {WasUsed}, Damaged: {WasDamaged}";
        }

        public int CompareTo(Bicycle? other)
        {
            if (other == null) return 1;
            return this.Year.CompareTo(other.Year);
        }

    }
}
