using System;
using System.Linq;

namespace GoogleMapAPI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter address : ");
            var address = Console.ReadLine();
            if (address != null && address == string.Empty)
            {
                address = "205 108th Ave NE #400, Bellevue, WA 98004, USA";
            }
            var result = GetGoogleAddress.GoogleAddress(address);
            var response = (from n in result.Result.Results
                select new
                {
                    n.geometry.Location.Latitude,
                    n.geometry.Location.Longitude,
                    Address = n.formatted_address,
                    n.geometry.LocationType
                }).ToList();
            if (response.Count > 0)
            {
                foreach (var x in response)
                {
                    Console.WriteLine("The Latitude and Longitude  {0} , {1} for the address is {2} and Location type is {3}",
                        x.Latitude, x.Longitude, x.Address, x.LocationType);
                }
            }
            else
            {
            Console.WriteLine("The Address does not have a location or address might be worng . Please check");

            }

            Console.ReadLine();
        }
    }
}
