using System;
using Lab_6_OOP_Arv_Henric;
using System.Xml.Linq;

public class Elephant : Animal
{
    public int Betlängd { get; set; } // Betlängd (Tusk length) for Elephant

    public Elephant(string name, int age, string color, string enviroment, double weight, int tuskLength)
        : base(name, age, color, enviroment, weight) // Calling the Animal constructor
    {
        this.Betlängd = tuskLength;
    }

    public override void makeSound()
    {
        Console.WriteLine("TUUUUUUT!");
    }

    //ShowInfo to include Betlängd (TuskLength)
    public override void ShowInfo()
    {
        base.ShowInfo(); // Shows the base showinfo 
        Console.WriteLine($"Betlängd: {Betlängd} cm");
    }

    // Specific method for elephants
    public void SprayWater()
    {
        Console.WriteLine($"{name} sprutar vatten med sin snabel ");
    }
}
