using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberInAMinute
{
    public delegate void FoundPrimeCallBack(uint prime);

    public interface IMaxPrimeNumber
    {
        //Find max prime number not greater than n. During finding max prime number, callback function will trigger when a new prime is found.
        uint findMaxPrime(uint n, FoundPrimeCallBack callback);
    }
}
