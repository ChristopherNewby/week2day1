using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            House newHouse = new House(2,4);
            int newHouseBath = newHouse.NumBath;
            int newHouseRoom = newHouse.NumRoom;
            newHouse.HasRoom = true;
            bool RoomQuestion = newHouse.HasRoom;
            newHouse.HasBath = true;
            bool bathQuestion = newHouse.HasBath;
            newHouse.HasBasement = true;
            bool basementQuestion = newHouse.HasBasement;

            Console.WriteLine("This is a house");           
            Console.WriteLine("True or false: This house has a bath. - " + newHouse.HasBath);
            Console.WriteLine("This number of baths in this house - " + newHouseBath);
            Console.WriteLine("True or false: This house has a room. - " + newHouse.HasRoom);
            Console.WriteLine("This number of room in this house - " + newHouseRoom);
            Console.WriteLine("True or false: This house has a basement. - " + newHouse.HasBasement);
            Console.WriteLine(" ");




            House apartment = new House(1);
            int newApartmentBath = apartment.NumBath;
            int newApartmentRoom = apartment.NumRoom;
            apartment.HasRoom = true;
            bool apartmentRoom = newHouse.HasRoom;
            apartment.HasBath = false;
            bool apartmentBath = newHouse.HasBath;
            newHouse.HasBasement = false;
            bool apartmentBasement = newHouse.HasBasement;

            Console.WriteLine("This is an apartment");
            Console.WriteLine("True or false: This apartment has a bath. - " + apartment.HasBath);
            Console.WriteLine("This number of baths in this apartment - " + newApartmentBath);
            Console.WriteLine("True or false: This apartment has a room. - " + apartment.HasRoom);
            Console.WriteLine("This number of rooms in this apartment - " + newApartmentRoom);
            Console.WriteLine("True or false: This apartment has a basement. - " + newHouse.HasBasement);
            Console.WriteLine(" ");


            Town city = new Town(10,4);
            int numberOfRestaurants = city.Restaurants;
            int numberOfGyms = city.Gyms;
            city.HasSchool = false;
            bool citySchool = city.HasSchool;
            city.HasBus = true;
            bool Bus = city.HasBus;
            city.FreewayAccess = true;
            bool accessToFreeway = city.FreewayAccess;

            Console.WriteLine("This is a city");
            Console.WriteLine("This city has " + numberOfGyms + " gym/gyms.");
            Console.WriteLine("This city has " + numberOfRestaurants + " restaurant/restaurants.");
            Console.WriteLine("True or false: This city has access to a bus system. - " + city.HasBus);
            Console.WriteLine("True or False: This city has access to a school. " + city.HasSchool);
            Console.WriteLine("True or false: This city has access to the freeway " + city.FreewayAccess);
            Console.WriteLine(" ");


            Town rural = new Town(1,1);
            int ruralRestaurants = rural.Restaurants;
            int ruralGyms = rural.Gyms;
            city.HasSchool = true;
            bool ruralSchool = city.HasSchool;
            city.HasBus = true;
            bool RuralBus = city.HasBus;
            city.FreewayAccess = false;
            bool ruralAccessToFreeway = city.FreewayAccess;

            Console.WriteLine("This is a rural city");
            Console.WriteLine("This city has " + ruralGyms + " gym/gyms.");
            Console.WriteLine("This city has " + ruralRestaurants + " restaurant/restaurants.");
            Console.WriteLine("True or false: This city has access to a bus system. - " + rural.HasBus);
            Console.WriteLine("True or False: This city has access to a school. " + rural.HasSchool);
            Console.WriteLine("True or false: This city has access to the freeway " + rural.FreewayAccess);
            Console.WriteLine(" ");

            Stadium footballStadium = new Stadium(16, 60000);
            int footballGames = footballStadium.Games;
            int footballSeats = footballStadium.Seats;
            footballStadium.BadTraffic = true;
            bool footballStadiumTraffic = footballStadium.BadTraffic;
            footballStadium.InDowntown = true;
            bool footballStadiumDowntown = footballStadium.InDowntown;
            footballStadium.Garbage = ("Wednesday");
            string whatDay = footballStadium.Garbage;

            Console.WriteLine("This is a football stadium");
            Console.WriteLine("This stadium has " + footballGames + "number of games" );
            Console.WriteLine("This stadium holds " + footballSeats + "number of fans");
            Console.WriteLine("True or false: This stadium has bad traffic on game day - " + footballStadium.BadTraffic);
            Console.WriteLine("True or false: This stadium is located downtown - " + footballStadium.InDowntown);
            Console.WriteLine("This stadium is closed for garbage day on " + footballStadium.Garbage);
            Console.WriteLine(" ");


            Stadium baseballStadium = new Stadium(162, 42000);
            int BaseballGames = baseballStadium.Games;
            int BaseballSeats = baseballStadium.Seats;
            baseballStadium.BadTraffic = false;
            bool baseballStadiumTraffic = baseballStadium.BadTraffic;
            baseballStadium.InDowntown = true;
            bool baseballStadiumDowntown = baseballStadium.InDowntown;
            footballStadium.Garbage = ("Sunday");
            string whatDayBaseball = baseballStadium.Garbage;

            Console.WriteLine("This is a football stadium");
            Console.WriteLine("This stadium has " + footballGames + "number of games");
            Console.WriteLine("This stadium holds " + footballSeats + "number of fans");
            Console.WriteLine("True or false: This stadium has bad traffic on game day - " + footballStadium.BadTraffic);
            Console.WriteLine("True or false: This stadium is located downtown - " + footballStadium.InDowntown);
            Console.WriteLine("This stadium is closed for garbage day on " + footballStadium.Garbage);
            Console.WriteLine(" ");
            Console.ReadLine();

            
        }
    }
}
