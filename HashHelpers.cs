using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    public static class HashHelpers
    {
        public static int GetPrime(int capacity)
        {
            if (capacity <= 1)
                return 2;

            int prime = capacity;
            bool found = false;

            while (!found)
            {
                prime++;

                if (isPrime(prime))
                    found = true;
            }

            return prime;
        }
        private static bool isPrime(int prime)
        {
            if (prime <= 1) return false;
            if (prime <= 3) return true;

            if (prime % 2 == 0 || prime % 3 == 0) return false;

            for (int i = 5; i * i <= prime; i = i + 6)
                if (prime % i == 0 || prime % (i + 2) == 0)
                    return false;

            return true;
        }
        public static int ExpandPrime(int oldSize)
        {
            int newSize = 2 * oldSize;

            if ((uint)newSize > 0x7FEFFFFD && 0x7FEFFFFD > oldSize)
            {
                return 0x7FEFFFFD;
            }

            return GetPrime(newSize);
        }

    }
}

