using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoogleMapAPI.Model;

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
            List<Result> response;
            try
            {
                response = (from n in result.Result.Results
                                         select new Result()
                                         {
                                             geometry = n.geometry,
                                             address_components = n.address_components,
                                             formatted_address = n.formatted_address,
                                             place_id = n.place_id,
                                             types = n.types
                                         }).ToList();
            }
           

            catch (System.AggregateException ex)
            {
                Console.WriteLine("Issue occured {0}",ex.Message);
                throw new Exception(ex.Message);
            }
            if (response.Count > 0)
            {
                foreach (var x in response)
                {
                    Console.WriteLine("The Latitude and Longitude  {0} , {1} for the address is {2} and Location type is {3}",
                          x.geometry.Location.Latitude, x.geometry.Location.Longitude, x.address_components, x.geometry.LocationType);
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
