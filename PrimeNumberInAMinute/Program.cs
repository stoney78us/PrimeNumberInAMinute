using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrimeNumberInAMinute
{
    class Program
    {

        static int timeCounter = 0;
        static uint currentPrime = 0;

        static void Main(string[] args)
        {
            TimerCallback timerCallback = new TimerCallback(TimerCallBack);

            //Starting timer thread
            Timer timer = new Timer(timerCallback, null, 0, 1000);

            //setup max prime finding thread
            ThreadStart start = new ThreadStart(() =>
            {
                FoundPrimeCallBack fPrimeCallBack = new FoundPrimeCallBack(FoundPrimeCallBack);
                IMaxPrimeNumber maxPrimeNumber = new MaxPrimeNumber();
                maxPrimeNumber.findMaxPrime(2500000000, fPrimeCallBack);
            });

            Thread pt = new Thread(start);

            //starting max prime finding thread
            pt.Start();

            //checking clock
            while (timeCounter <= 60)
            {

            }

            //Stop timer
            timer.Change(Timeout.Infinite, Timeout.Infinite);

            //aborting prime finding thread
            pt.Abort();

            Console.WriteLine("The max prime number found in 1 min is:" + currentPrime);

            Console.Read();
        }

        private static void FoundPrimeCallBack(uint prime){
            currentPrime = prime;
        }

        private static void TimerCallBack(object state) {
            Console.WriteLine("seconds:" + (timeCounter++) + "     primeNo:" + currentPrime);
        
        }

    }
}
