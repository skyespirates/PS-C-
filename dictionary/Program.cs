using System;
using System.Collections.Generic;


namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> teams = new Dictionary<string, int>();
            teams.Add("Liverpool", 0);
            teams.Add("Chelsea", 0);
            teams.Add("Arsenal", 0);
            teams["Liverpool"] = teams["Liverpool"]+3;
            teams["Liverpool"] = teams["Liverpool"]+3;
            teams["Liverpool"] = teams["Liverpool"]+3;
            teams["Liverpool"] = teams["Liverpool"]+3;
            foreach(object e in teams) {
            Console.WriteLine(e);
            }
            
        }
    }
}
