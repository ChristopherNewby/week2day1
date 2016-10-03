using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class House
    {
        private bool hasBath;
        private int numBath;
        private bool hasRoom;
        private int numRoom;
        private bool hasBasement;

        public House(int intialNumBath, int intialNumRoom)
        {
            numBath = intialNumBath;
            numRoom = intialNumRoom;
            
            
        }
        
        //This is a polymorphised constructor
        public House(int intialNumRoom)
        {
            numRoom = intialNumRoom;
        }

        public bool HasBath
        {
            get
            {
                return hasBath;
            }
            set
            {
                hasBath = value;
            }
        }

        public int NumBath
        {
            get
            {
                return numBath;
            }

            set
            {
                if (value < 1)
                {
                    numBath = 1;
                }
                else
                {
                    numBath = value;
                }
            }
        }

        public bool HasRoom
        {
            get
            {
                return hasRoom;
            }

            set
            {
                hasRoom = value;
            }
        }

        public int NumRoom
        {
            get
            {
                return numRoom;
            }

            set
            {
                if (value < 1)
                {
                    numRoom = 1;
                }
                else
                {
                    numRoom = value;
                }
            }
        }
        public bool HasBasement
        {
            get
            {
                return hasBasement;
            }
            set
            {
                hasBasement = value;
            }
        }
    }
}





