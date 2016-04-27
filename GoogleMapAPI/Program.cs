using System;


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

            foreach (var respose in result.Result.Results)
            {
                  Console.WriteLine("The Latitude and Longitude  {0} , {1} for the address is {2} and Location type is {3}", 
                      respose.geometry.Location.Latitude, respose.geometry.Location.Longitude, respose.formatted_address, respose.geometry.LocationType);
            }
            Console.ReadLine();
        }
    }
}
