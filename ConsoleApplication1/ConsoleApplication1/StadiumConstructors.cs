using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Stadium
    {
        private bool inDowntown;
        private int seats;
        private bool badTraffic;
        private int games;
        private string garbageDay;

        public Stadium(int intialGames, int intialSeats)
        {
            games = intialGames;
            seats = intialSeats;
        }

        public string Garbage
        {
            get
            {
                return garbageDay;
            }
            set
            {
                garbageDay = value;
            }

        }

        public bool InDowntown
        {
            get
            {
                return inDowntown;
            }
            set
            {
                inDowntown = value;
            }
        }

        public int Seats
        {
            get
            {
                return seats;
            }

            set
            {
                if (value < 1000)
                {
                    seats = 1000;
                }
                else
                {
                    seats = value;
                }
            }
        }

        public bool BadTraffic
        {
            get
            {
                return badTraffic;
            }

            set
            {
                badTraffic = value;
            }
        }

        public int Games
        {
            get
            {
                return games;
            }

            set
            {
                if (value <= 16)
                {
                    games = 16;
                }
                else
                {
                    games = value;
                }
            }
        }

    }
}




