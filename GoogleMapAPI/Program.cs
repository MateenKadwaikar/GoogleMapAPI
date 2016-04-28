using System;
using System.Linq;


namespace GoogleMapAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = "";
            Console.WriteLine("Please enter address : ");
            address = Console.ReadLine(); 
            var result =  GetGoogleAddress.GoogleAddress(address);
            var response = (from n in result.Result.Results
                            select new
                            {
                                n.geometry.Location.Latitude, n.geometry.Location.Longitude,
                                Address = n.formatted_address, n.geometry.LocationType
                            }).ToList();
            foreach (var x in response)
            {
                Console.WriteLine("The Latitude and Longitude  {0} , {1} for the address is {2} and Location type is {3}",
                     x.Latitude,x.Longitude,x.Address,x.LocationType);
            }
            
            Console.ReadLine();
        }
    }
}
