using System;
using System.Collections.Generic;

namespace Assignment1b
{
    /// <summary>
    /// Class to collect user input for creating animal objects
    /// </summary>
    public class AnimalInputCollector
    {
        private List<ITalkable> _animalList;

        public AnimalInputCollector(List<ITalkable> animalList)
        {
            _animalList = animalList;
        }

        /// <summary>
        /// Collects user input to create and add an animal to the list
        /// </summary>
        public void CollectInput()
        {
            Console.WriteLine("What type of animal would you like to create?");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Teacher");
            
            int choice = 0;
            bool validChoice = false;

            // Validate the user's choice
            while (!validChoice)
            {
                try
                {
                    string input = Console.ReadLine();
                    choice = int.Parse(input);
                    
                    if (choice >= 1 && choice <= 3)
                    {
                        validChoice = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // Based on the choice, collect appropriate data and create object
            switch (choice)
            {
                case 1: // Dog
                    CreateDog();
                    break;
                case 2: // Cat
                    CreateCat();
                    break;
                case 3: // Teacher
                    CreateTeacher();
                    break;
            }
        }

        /// <summary>
        /// Creates a dog based on user input
        /// </summary>
        private void CreateDog()
        {
            string name = GetValidStringInput("Enter the dog's name: ");
            bool friendly = GetValidBooleanInput("Is the dog friendly? (true/false): ");

            Dog dog = new Dog(friendly, name);
            _animalList.Add(dog);
            
            Console.WriteLine($"Dog '{name}' added successfully!");
        }

        /// <summary>
        /// Creates a cat based on user input
        /// </summary>
        private void CreateCat()
        {
            string name = GetValidStringInput("Enter the cat's name: ");
            int mousesKilled = GetValidIntInput("Enter how many mice this cat has killed: ");

            Cat cat = new Cat(mousesKilled, name);
            _animalList.Add(cat);
            
            Console.WriteLine($"Cat '{name}' added successfully!");
        }

        /// <summary>
        /// Creates a teacher based on user input
        /// </summary>
        private void CreateTeacher()
        {
            string name = GetValidStringInput("Enter the teacher's name: ");
            int age = GetValidIntInput("Enter the teacher's age: ");

            Teacher teacher = new Teacher(age, name);
            _animalList.Add(teacher);
            
            Console.WriteLine($"Teacher '{name}' added successfully!");
        }

        /// <summary>
        /// Gets a valid string input from the user
        /// </summary>
        private string GetValidStringInput(string prompt)
        {
            string input = "";
            bool valid = false;

            while (!valid)
            {
                Console.Write(prompt);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Input cannot be empty. Please try again.");
                }
            }

            return input;
        }

        /// <summary>
        /// Gets a valid integer input from the user
        /// </summary>
        private int GetValidIntInput(string prompt)
        {
            int result = 0;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine();
                    result = int.Parse(input);
                    valid = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return result;
        }

        /// <summary>
        /// Gets a valid boolean input from the user
        /// </summary>
        private bool GetValidBooleanInput(string prompt)
        {
            bool result = false;
            bool valid = false;

            while (!valid)
            {
                try
                {
                    Console.Write(prompt);
                    string input = Console.ReadLine().ToLower();
                    
                    if (input == "true" || input == "false")
                    {
                        result = bool.Parse(input);
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'true' or 'false'.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            return result;
        }
    }
}