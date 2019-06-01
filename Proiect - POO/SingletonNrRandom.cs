using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect___POO
{
    class SingletonNrRandom
    {
        private static SingletonNrRandom uniqueInstance;
        Random rnd;

        private SingletonNrRandom()
        {
            rnd = new Random();
        }

        public static SingletonNrRandom Instance
        {
            get
            {
                if (uniqueInstance == null)
                    uniqueInstance = new SingletonNrRandom();
                return uniqueInstance;
            }
        }

        public int getRandom()
        {
            return rnd.Next(10);
        }
    }
}
