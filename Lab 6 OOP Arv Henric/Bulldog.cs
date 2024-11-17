using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv_Henric
{
    public class Bulldog : Dog
    {
        public string Size { get; set; } // Specific property for bulldogs (Small, Medium Large)

        public Bulldog(string name, int age, string color, string enviroment, double weight, string size, bool isHouseTrained)
            : base(name, age, color, enviroment, weight, "Bulldog", isHouseTrained) // Using the Dog constructor
        {
            this.Size = size; // New property for bulldog
        }

        public override void makeSound()
        {
            Console.WriteLine("Boof Boof! säger hunden");// Unique sound
        }

        // Specific method for bulldogs
        public void Snore()
        {
            Console.WriteLine($"{name} Hund snarkar Hoonk mimimimi");
        }
    }
}