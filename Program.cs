// PEDAC

// PROBLEM

// Create a simple console application that manages the dinosaurs in your zoo.
// View
// This command will show the all the dinosaurs in the list, ordered by WhenAcquired
//  Add
// This command will let the user type in the information for a dinosaur and add it to the list. Prompt for the Name, Diet Type, Weight and Enclosure Number, but the WhenAcquired must be supplied by the code.
//  Remove
// This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name.
//  Transfer
// This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.
//  Summary
//  This command will display the number of carnivores and the number of herbivores.
//  Quit
//  This will stop the program


// EXAMPLES

// Name - string
// DietType - string either carnivore or herbivore
// WhenAcquired - supplied by the code
// Weight - int represented in pounds
// EnclosureNumber - int

// Name: Charlie
// DietType: Carnivore
// WhenAcquired - supplied by the code DateTime
// Weight - 400 pounds
// EnclosureNumber - 101

// DATA

// CLASS Dinosaurs
// PROPERTIES
// Name, DietType, WhenAcquired, Weight, EnclosureNumber
// METHOD
// Create a method called Description that includes all of the properties
// LIST
// Make a list that houses them List<Dinosaur>


// ALGORITHM
// Welcome the user to the application
// While the user hasn't quit the application
// Show them a menu of options they can do
// Name - string
// DietType - string either carnivore or herbivore
// WhenAcquired - supplied by the code
// Weight - int represented in pounds
// EnclosureNumber - string
// Quit the app
using System;
using System.Collections.Generic;
using System.Linq;

namespace JurasicPark
{
    class Dinosaur
    {
        // Name - string
        public string Name { get; set; }
        // DietType - string either carnivore or herbivore
        public string DietType { get; set; }
        // WhenAcquired - supplied by the code
        public DateTime WhenAcquired { get; set; } = DateTime.Now;
        // Weight - int represented in pounds
        public int Weight { get; set; }
        // EnclosureNumber - int
        public int EnclosureNumber { get; set; }

        public string Description()
        {
            var description = $"This is {Name}, been at the zoo since {WhenAcquired}. Located in {EnclosureNumber} and they are a {DietType} that weighs {Weight} pounds";
            return description;
        }
    }
    class Program
    {
        static Dinosaur PromptAndFindDinosaur(List<Dinosaur> dinosaursToSearchWithin)
        {
            Console.Write("Name: ");
            var nameOfDinosaurToSearchFor = Console.ReadLine();
            var foundDinosaur = dinosaursToSearchWithin.FirstOrDefault(dinosaur => dinosaur.Name == nameOfDinosaurToSearchFor);
            return foundDinosaur;
        }

        static void Main(string[] args)
        {
            var whenAcquired = DateTime.Now;
            var dinosaurs = new List<Dinosaur> {
              new Dinosaur
              {
                Name = "Charlie",
                DietType = "Carnivore",
                WhenAcquired = whenAcquired,
                Weight = 400,
                EnclosureNumber = 101,
              },
              new Dinosaur
              {
                Name = "Tiny",
                DietType = "Carnivore",
                WhenAcquired = whenAcquired,
                Weight = 12000,
                EnclosureNumber = 102,
              },
              new Dinosaur
              {
                Name = "Susan",
                DietType = "Herbivore",
                WhenAcquired = whenAcquired,
                Weight = 400,
                EnclosureNumber = 103,
              },

            };
            // Welcome the user to the application
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Welcome to our Dino Zoo!");
            Console.WriteLine();
            Console.WriteLine();
            // While the user hasn't quit the application
            var hasQuitTheApplication = false;
            while (hasQuitTheApplication == false)
            { // Show them a menu of options they can do
                Console.WriteLine("Select an option from the Menu below:");
                Console.WriteLine(" VIEW - View the dinosaurs we have in the order in which they got here!");
                Console.WriteLine(" ADD - Add a new dinosaur to the zoo!");
                Console.WriteLine(" REMOVE - Remove a dinosaur from the zoo!");
                Console.WriteLine(" TRANSFER - Transfer a dinosaur to a new Enclosure!");
                Console.WriteLine(" SUMMARY - Show the number of carnivores and herbivores in the zoo!");
                Console.WriteLine(" QUIT - Quit the program!");
                Console.WriteLine();
                Console.Write("Choice: ");

                var choice = Console.ReadLine();

                if (choice == "QUIT")
                {
                    hasQuitTheApplication = true;
                }
                if (choice == "VIEW")
                {
                    foreach (var dinosaur in dinosaurs)
                    {
                        Console.WriteLine(dinosaur.Description());
                    }
                    Console.WriteLine(" GOODBYE ");
                }
                if (choice == "ADD")
                {
                    Console.WriteLine("Name: ");
                    var name = Console.ReadLine();

                    Console.WriteLine("Diet Type: Carnivore or Herbivore ");
                    var dietType = Console.ReadLine();

                    Console.WriteLine("Weight: ");
                    var weight = Console.ReadLine();
                    var newWeight = int.Parse(weight);

                    Console.WriteLine("Located: ");
                    var enclosureNumber = Console.ReadLine();
                    var newEnclosureNumber = int.Parse(enclosureNumber);


                    Console.WriteLine($"Arrived: {whenAcquired}");

                    var dinosaur = new Dinosaur()
                    {
                        Name = name,
                        DietType = dietType,
                        Weight = newWeight,
                        EnclosureNumber = newEnclosureNumber,
                        WhenAcquired = whenAcquired,
                    };

                    dinosaurs.Add(dinosaur);

                }
                if (choice == "TRANSFER")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);
                    if (foundDinosaur != null)
                    {
                        Console.WriteLine(foundDinosaur.Description());
                        Console.Write("Is this the right dinosaur?, YES or NO:");
                        var answer = Console.ReadLine();
                        if (answer == "YES")
                        {
                            Console.Write("New Enclosure Number: ");
                            var newEnclosureNumber = Console.ReadLine();
                            foundDinosaur.EnclosureNumber = int.Parse(newEnclosureNumber);
                        }
                    }
                }
                if (choice == "REMOVE")
                {
                    var foundDinosaur = PromptAndFindDinosaur(dinosaurs);
                    if (foundDinosaur != null)
                    {
                        Console.WriteLine(foundDinosaur.Description());
                        Console.Write("Is this the right dinosaur?, YES or NO:");
                        var answer = Console.ReadLine();
                        if (answer == "YES")
                        {
                            dinosaurs.Remove(foundDinosaur);
                        }
                        else
                        {
                            Console.WriteLine($"There is no dinosaur named {answer}");
                        }
                    }
                }
                if (choice == "SUMMARY")
                {
                    var HerbivoreCount = dinosaurs.Count(dinosaur => dinosaur.DietType == ("Herbivore"));
                    var CarnivoreCount = dinosaurs.Count(dinosaur => dinosaur.DietType == ("Carnivore"));
                    Console.WriteLine($"There are {HerbivoreCount} herbivores and {CarnivoreCount} carnivores in the park");
                }


                // Name - string
                // DietType - string either carnivore or herbivore
                // WhenAcquired - supplied by the code
                // Weight - int represented in pounds
                // EnclosureNumber - string
                // Quit the app
            }
        }
    }
}
