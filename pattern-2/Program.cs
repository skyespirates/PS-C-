using System;

namespace pattern_2
{
    class Program
    {
        /*

        *****
        ****
        ***
        **
        *

        */
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            for(int i=0; i<n; i++) {
              for(int j=0; j<temp; j++) {
                Console.Write("*");
              }
              Console.Write("\n");
              temp--;
            }
        }
    }
}
