using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Cat object from Cat(string,int,int)");


            Cat tom = new Cat("Tom", 3, 20);

            Console.WriteLine("------");

            Console.WriteLine("Name = {0}", tom.Name);
            Console.WriteLine("Age = {0}", tom.Age);
            Console.WriteLine("Height = {0}", tom.Height);

            Console.WriteLine("------");


            tom.Sleep();


            tom.Say();


            Console.ReadLine();
        }
    }
}
