using System;

namespace Lab_6_OOP_Arv_Henric
{
    public class Dog : Animal
    {
        public string Breed { get; set; } // Specific property for dogs
        public bool IsHouseTrained { get; set; } // shows if the dog is house trained

        public Dog(string name, int age, string color, string enviroment, double weight, string breed, bool isHouseTrained)
            : base(name, age, color, enviroment, weight) // Passes all information to the Animal constructor
        {
            this.Breed = breed;
            this.IsHouseTrained = isHouseTrained;
        }

        public override void makeSound()
        {
            Console.WriteLine("Voff! :D");
        }

        // Show info for all information
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Breed: {Breed}, House trained: {(IsHouseTrained ? "Yes" : "No")}");
        }

        // Specific to this dog (Play Dead)
        public void PlayDead()
        {
            Console.WriteLine($"{name} rullar över och låtsas vara död!");
        }
    }
}