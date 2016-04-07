using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PrimeNumberInAMinute
{
    public class EratosMaxPrimeNumber : IMaxPrimeNumber
    {

        public uint findMaxPrime(uint n, FoundPrimeCallBack callback)
        {
            if (n < 2)
                throw new Exception("input number must be greater than 1");
            if (n < 3)
                return 2;

            uint currentPrime = 2;

            bool[] isPrimeArray = new bool[n + 1];

            isPrimeArray[0] = false;
            isPrimeArray[1] = false;


            for (uint i = 2; i <= n; i++)
            {
                isPrimeArray[i] = true;
            }

            for (uint i = 2; i <= n; i++)
            {
                if (isPrimeArray[i] == true)
                {
                    currentPrime = i;
                    if (callback != null)
                        callback.Invoke(currentPrime);
                    for (uint j = 2*i; j <= n; j = j + i)
                    {
                        isPrimeArray[j] = false;
                    }
                }
            }

            return currentPrime;
        }
    }
}
