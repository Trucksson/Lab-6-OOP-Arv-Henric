using System;

namespace Lab_6_OOP_Arv_Henric 

{ 

public class Chihuahua : Dog
{
    public bool IsYappy { get; set; } // IsYappy for chihuahuas

    public Chihuahua(string name, int age, string color, string enviroment, double weight, bool isHouseTrained, bool isYappy)
        : base(name, age, color, enviroment, weight, "Chihuahua", isHouseTrained) // Using the Dog constructor
    {
        this.IsYappy = isYappy; // New property for chihuahua
    }

    public override void makeSound() //Make sound method
    {
        if (IsYappy) //If statement
        {
            Console.WriteLine("YipYip! Chihuahuan håller aldrig käften D:");
        }
        else
        {
            Console.WriteLine("Chihuahuan är äntligen tyst :D.");
        }
    }

    // method for chihuahuas
    public void Shake()
    {
        Console.WriteLine($"{name} Darrar lite");
    }
    }
}
