using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AirportControl
{
    class Scheduler
    {
        public static void AddFlight(int flight, string code, string name, string time, List<int> flightNumbers, List<string> codes, List<string> names, List<string> times)
        {
            int flightPost = flightNumbers.BinarySearch(flight);


            if(flightPost <= -1) //see if flight already exists
            {
                flightNumbers.Add(flight);
                flightNumbers.Sort();
                flightPost = flightNumbers.BinarySearch(flight); //get new postion
                codes.Insert(flightPost, code);
                names.Insert(flightPost, name);
                times.Insert(flightPost, time);

                WriteLine("Flight Added");
                WriteLine(FlightInfo.GetFlightInfo(flight, flightNumbers, codes, names, times));
            }
            else
            {
                WriteLine("That flight already exists");
            }
        }
    }
}
