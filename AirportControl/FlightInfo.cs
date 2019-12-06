using System;
using System.Collections.Generic;
using System.Text;

namespace AirportControl
{
    class FlightInfo
    {
        public static string GetFlightInfo(int flight, List<int> flightNumbers, List<string> codes, List<string> names, List<string> times)
        {
            string message;

            int post = flightNumbers.BinarySearch(flight); //return position in the array of the flight number

            if (post > -1) //if found
            {
                message = String.Format("Flight #{0} {1} {2}  Scheduled at: {3}", flightNumbers[post], codes[post], names[post], times[post]);
            }
            else
            {
                message = String.Format("Flight #{0} was not found.", flight);

                if(GetInput.CheckAddFlight(flight))
                {
                    GetInput.UserAddFlight(flight, flightNumbers, codes, names, times);
                }
            }

            return message;
        }
    }
}
