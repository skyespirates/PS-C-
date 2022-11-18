using System;

namespace input
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Enter your name:");
          String name = Console.ReadLine();
          Console.WriteLine("Enter your age:");
          int age = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine($"My name is {name}, age {age}");
        }
    }
}
