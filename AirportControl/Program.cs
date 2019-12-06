using System;
using static System.Console;
using System.Collections.Generic;

namespace AirportControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> flightNumbers = new List<int>(){ 201, 321, 510, 633 };
            List<string> codes = new List<string>(){ "AUS", "CRP", "DWF", "HOU" };
            List<string> names = new List<string>() { "Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
            List<string> times = new List<string>() { "0710", "0830", "0915", "1140" };

            
            Scheduler.AddFlight(333, "BAD", "Bangor Airport District", "0810", flightNumbers, codes, names, times);


            while(true)
            {
                GetInput.UserInput(flightNumbers, codes, names, times);
            }
        }
    }
}
