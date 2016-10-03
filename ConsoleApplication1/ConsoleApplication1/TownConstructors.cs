using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{


    public class Town
    {
        private bool hasSchool;
        private int restaurants;
        private bool hasBus;
        private int gyms;
        private bool freewayAccess;

        public Town(int intialRestaurants, int intialGyms)
        {
            gyms = intialGyms;
            restaurants = intialRestaurants;
        }



        public bool HasSchool
        {
            get
            {
                return hasSchool;
            }
            set
            {
                hasSchool = value;
            }
        }

        public int Restaurants
        {
            get
            {
                return restaurants;
            }

            set
            {
                if (value < 1)
                {
                    restaurants = 1;
                }
                else
                {
                    restaurants = value;
                }
            }
        }

        public bool HasBus
        {
            get
            {
                return hasBus;
            }

            set
            {
                hasBus = value;
            }
        }

        public int Gyms
        {
            get
            {
                return gyms;
            }

            set
            {
                if (value < 1)
                {
                    gyms = 1;
                }
                else
                {
                    gyms = value;
                }
            }
        }
        public bool FreewayAccess
        {
            get
            {
                return freewayAccess;
            }

            set
            {
                freewayAccess = value;
            }

        }
    }
}






