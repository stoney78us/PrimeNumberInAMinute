using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberInAMinute
{
    public class MaxPrimeNumber : IMaxPrimeNumber
    {
        //The obvious way to find max prime number
        public uint findMaxPrime(uint n, FoundPrimeCallBack callback) {

            if(n < 2)
                throw new Exception("input number must be greater than 1");

            if (n < 3)
                return 2;

            uint currentPrime = 2;

            for (uint i = 3; i <= n; i = i + 2) {
                bool isPrime = true;

                for (uint j = 3; j <= Math.Sqrt(i); j = j + 2) {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime) {
                    currentPrime = i;
                    if (callback != null)
                        callback.Invoke(currentPrime);
                }
            }

            return currentPrime;
        }
    }
}
