using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_OOP_Arv_Henric
{
    public class Turkey : Animal
    {
        // Here is the constructor relating to the base animal Class 
        public Turkey(string name, int age, string color, string enviroment, double weight)
            : base(name, age, color, enviroment, weight) // Calling the Animal constructor
        {
        }

      
        public override void makeSound() 
        {
            Console.WriteLine("Gobble gobble!"); //Unique sound
        }

        
        public override void ShowInfo()//Again the showinfo method
        {
            base.ShowInfo(); //ShowInfo from Animal class
        }

        // Specific method for Turkey
        public void Run()
        {
            Console.WriteLine($"{name} Springer fort!");
        }
    }
}