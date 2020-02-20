using System;
using System.Collections.Generic;

namespace InterfaceEX
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string name,gender;
            int age;

            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Enter age:");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter gender:");
                gender = Console.ReadLine();
                try
                {
                    switch (command)
                    {
                        case "Cat":
                            animals.Add(new Cat(name, age, gender)); break;
                        case "Dog":
                            animals.Add(new Dog(name, age, gender)); break;
                      
                        default:
                            throw new ArgumentException("Invalid input!");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
