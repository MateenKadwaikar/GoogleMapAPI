# GoogleMapAPI-NET

Introduction
C# google maps api interface for interacting with the backend web services for Google Maps.

It is a Console applicaton to show you the basic idea about integrating Google Map API in your application.

Get location details from Google API by passing Address.

You just have to pass the Address and it will give you the details.

 

For E.g.

Please enter address : Buffalo

The Latitude and Longitude  42.8864468 , -78.8783689 for the address is Buffalo, NY, USA and Location type is APPROXIMATE

The Latitude and Longitude  45.1717846 , -93.8747929 for the address is Buffalo, MN 55313, USA and Location type is APPROXIMATEThe Latitude and Longitude  44.3483072 , -106.6989375 for the address is Buffalo, WY 82834, USA and Location type is APPROXIMATE

The Latitude and Longitude  31.4637866 , -96.0580197 for the address is Buffalo, TX 75831, USA and Location type is APPROXIMATE

The Latitude and Longitude  37.5120048 , -85.6985727 for the address is Buffalo, KY 42716, USA and Location type is APPROXIMATEThe Latitude and Longitude  39.9158025 , -81.5207692 for the address is Buffalo, OH, USA and Location type is APPROXIMATE


You can verify the details with the google api from your browser

https://maps.google.com/maps/api/geocode/json?address=Buffalo

C#
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
