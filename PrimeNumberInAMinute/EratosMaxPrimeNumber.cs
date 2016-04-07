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
        //ver1
        //public uint findMaxPrime(uint n, FoundPrimeCallBack callback)
        //{
        //    if (n < 2)
        //        throw new Exception("input number must be greater than 1");
        //    if (n < 3)
        //        return 2;

        //    uint currentPrime = 2;

        //    bool[] isPrimeArray = new bool[n + 1];

        //    isPrimeArray[0] = false;
        //    isPrimeArray[1] = false;


        //    for (uint i = 2; i <= n; i++)
        //    {
        //        isPrimeArray[i] = true;
        //    }

        //    for (uint i = 2; i <= n; i++)
        //    {
        //        if (isPrimeArray[i] == true)
        //        {
        //            currentPrime = i;
        //            if (callback != null)
        //                callback.Invoke(currentPrime);
        //            for (uint j = i*i; j <= n; j = j + i)
        //            {
        //                isPrimeArray[j] = false;
        //            }
        //        }
        //    }

        //    return currentPrime;
        //}


        //ver2
        public uint findMaxPrime(uint n, FoundPrimeCallBack callback)
        {
            if (n < 2)
                throw new Exception("input number must be greater than 1");

            if (n == 2)
                return 2;

            if (n == 3)
                return 3;

            uint currentPrime = 2;
            uint arraySize = 0;

            //getting ceiling of n/2. Math.Ceiling function doesn't suppurt uint as an input.
            if (n % 2 != 0)
                arraySize = n / 2 + 1;
            else
                arraySize = n / 2;



            bool[] isPrimeArray = new bool[arraySize];

            isPrimeArray[0] = false;
            //isPrimeArray[1] = false;


            for (uint i = 1; i < arraySize; i++)
            {
                isPrimeArray[i] = true;
            }

            for (uint i = 1; i < arraySize; i++)
            {
                if (isPrimeArray[i] == true)
                {
                    currentPrime = i * 2 + 1;
                    if (callback != null)
                        callback.Invoke(currentPrime);
                    for (uint j = (currentPrime ^ 2 - 1) / 2; j < arraySize; j = ((j * 2 + 1) + 2 * currentPrime - 1) / 2)
                    {
                        isPrimeArray[j] = false;
                    }
                }
            }

            return currentPrime;
        }



    }
}
