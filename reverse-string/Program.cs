using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reversed = "";
            for(int i=0; i<str.Length; i++) {
              reversed = str[i] + reversed;
            }
            Console.WriteLine(reversed);
        }
    }
}
