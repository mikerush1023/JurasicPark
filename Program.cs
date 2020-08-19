using System;

namespace JurasicPark
{
    class Program
    {
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
        // EnclosureNumber - string

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
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
        }
    }
}
