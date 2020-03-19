using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Player
    {
        private string firstName;
        private string secondName;

        private int min;
        private int max;
        private int rand;

        public Player(string fisrtName, string secondName)
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        public void Trhow()
        {
            rand = RandomNumber(0, 3);
            Console.WriteLine(rand);
        }

        //Function to get a random number 

        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
