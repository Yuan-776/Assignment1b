using System;
using System.Collections.Generic;

namespace Assignment1b
{
    /// <summary>
    /// Main program class
    /// </summary>
    class Program
    {
        private static readonly FileOutput OutFile = new FileOutput("animals.txt");
        private static readonly FileInput InFile = new FileInput("animals.txt");

        static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();

            // Create the animal input collector and use it to add an animal to the list
            AnimalInputCollector inputCollector = new AnimalInputCollector(zoo);
            inputCollector.CollectInput();

            // Process each animal in the list
            foreach (ITalkable thing in zoo)
            {
                PrintOut(thing);
            }
            
            OutFile.FileClose();
            InFile.FileRead();
            InFile.FileClose();

            // Read the file line by line
            FileInput indata = new FileInput("animals.txt");
            string line;
            while ((line = indata.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            indata.FileClose();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints out information about a talkable object and writes it to file
        /// </summary>
        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine($"{p.Name} says={p.Talk()}");
            OutFile.FileWrite($"{p.Name} | {p.Talk()}");
        }
    }
}