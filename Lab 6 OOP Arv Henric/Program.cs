namespace Lab_6_OOP_Arv_Henric
{
   
        class Program
        {
            static void Main(string[] args)
            {
            // Create Elephant 
            Elephant dumbo = new Elephant("Dumbo", 10, "Grey", "Savannah", 5000, 150);
            dumbo.ShowInfo();
            dumbo.Eat();
            dumbo.Move();
            dumbo.makeSound();
            dumbo.sleep(false);
            dumbo.SprayWater();
            Console.WriteLine();  // Adds an empty line for separation

            // Create Dog instance
            Dog molly = new Dog("Molly", 5, "Brown", "House", 10, "Yorkie", true);
            molly.ShowInfo();
            molly.Eat();
            molly.Move();
            molly.makeSound();
            molly.sleep(true);
            molly.PlayDead();
            Console.WriteLine();  

            // Create Chihuahua 
            Chihuahua bella = new Chihuahua("Bella", 3, "Tan", "House", 3, true, true);
            bella.ShowInfo();
            bella.Eat();
            bella.Move();
            bella.makeSound();
            bella.Shake();
            bella.sleep(true);
            Console.WriteLine();  

            // Create Bulldog 
            Bulldog tobbe = new Bulldog("Tobbe", 4, "White", "House", 25, "Medium", true);
            tobbe.ShowInfo();
            tobbe.Eat();
            tobbe.Move();
            tobbe.makeSound();
            tobbe.sleep(false);
            tobbe.Snore();
            Console.WriteLine();  

            // Create Turkey 
            Turkey tom = new Turkey("Tom", 3, "Brown", "Farm", 5.0);
            Console.WriteLine("=== Turkey (Tom) ===");
            tom.ShowInfo();
            tom.makeSound();
            tom.Eat();
            tom.Run();
            tom.sleep(true);
            Console.WriteLine();  
        }
        }
    }


            
        