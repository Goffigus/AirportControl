using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AirportControl
{
    class GetInput
    {
        public static void UserInput(List<int> flightNumbers, List<string> codes, List<string> names, List<string> times)
        {
            WriteLine("Enter Flight number");
            string input = ReadLine();
            int flight;
            if (Int32.TryParse(input, out flight))
            {
                WriteLine(FlightInfo.GetFlightInfo(flight, flightNumbers, codes, names, times));
            }
            else
            {
                WriteLine("Invalid Input");
            }
        }

        public static bool CheckAddFlight(int flight)
        {
            WriteLine("Do you want to add {0}?", flight);
            WriteLine("Type 'Y' to add flight.");

            string input = ReadLine();
            if(input == "Y")
            {
                return true;
            }
            else
            {
                WriteLine("Flight not added");
                return false;
            }
        }

        public static void UserAddFlight(int flight, List<int> flightNumbers, List<string> codes, List<string> names, List<string> times)
        {
            WriteLine("Enter airport code");
            string code = ReadLine();
            WriteLine("Enter airport name");
            string name = ReadLine();
            WriteLine("Enter departure time");
            string time = ReadLine();

            Scheduler.AddFlight(flight, code, name, time, flightNumbers, codes, names, times);
        }
    }
}
