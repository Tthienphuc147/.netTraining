using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    public abstract class Animal
    {
     
        public string Name;


        public Animal()
        {
            Console.WriteLine("- Animal()");
        }

        public Animal(string Name)
        {
  
            this.Name = Name;
            Console.WriteLine("- Animal(string)");
        }
        public virtual void Move()
        {
            Console.WriteLine("Animal Move");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

    }
}
