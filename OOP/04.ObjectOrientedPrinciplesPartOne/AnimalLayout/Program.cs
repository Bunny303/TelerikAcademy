using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalLayout
{
    class Program
    {
        static void Main()
        {
            // Test method MakeSound
            List<ISound> animalSounds = new List<ISound>();
            animalSounds.Add(new Kitten(1, "Unita"));
            animalSounds.Add(new Dog(5, "Sharo", true));
            animalSounds.Add(new Frog(2, "Frogi", false));
            animalSounds.Add(new Tomcat(2, "Tamerland"));
            
            foreach (var sound in animalSounds)
            {
                sound.MakeSound();
            }
            
            // Make array of different animals
            Animal[] testAnimals = new Animal[5]
            {
                new Kitten(1, "Unita"), 
                new Dog(5, "Sharo", true),
                new Frog (2, "Frogi", false),
                new Tomcat(2, "Tamerland"),
                new Dog(7,"Snoopy", true)
            };

            // Find average years of each type animal - LINQ
            var averageAges =
                from animal in testAnimals
                group animal by animal.GetType() into animalType
                select new {Type = animalType.Key.Name, Average = animalType.Average(a => a.Age)};
            
            foreach (var item in averageAges)
            {
                Console.WriteLine("{0}: {1}", item.Type, item.Average); 
            }
        }
    }
}
