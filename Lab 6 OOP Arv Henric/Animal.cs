using System;

namespace Lab_6_OOP_Arv_Henric
{
    public abstract class Animal
    {
        public string name { get; set; } = "NoName";
        public int age { get; set; } = 0;
        public string color { get; set; } = "Unknown";
        public string enviroment { get; set; } = "Unknown";
        public double weight { get; set; } = 0.0;

        // Konstruktor
        public Animal(string name = "NoName", int age = 0, string color = "Unknown", string enviroment = "Unknown", double weight = 0.0)
        {
            this.name = name;
            this.age = age;
            this.color = color;
            this.enviroment = enviroment;
            this.weight = weight;
        }

        // Metod för att sova
        public void sleep(bool noise)
        {
            if (noise)
            {
                Console.WriteLine($"{name} Kan inte sova");
            }
            else
            {
                Console.WriteLine($"{name} Sover gott");
            }
        }

        public virtual void makeSound() // Make sound method
        {
            Console.WriteLine("Buu!");
        }

        public virtual void ShowInfo() //Shows the info for the Animal
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Color: {color}, Birthplace: {enviroment}, Weight: {weight}");
        }

        public void Eat()
        {
            Console.WriteLine($"{name} äter mat.");
        }

        public void Move()
        {
            Console.WriteLine($"{name} rör på sig.");
        }
    }
}