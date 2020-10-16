﻿using System;

namespace exam4._5._2._3
{
    //class CallbackArg { }
    //class PrimeCallbackArg : CallbackArg
    class PrimeCallbackArg : EventArgs
    {
        public int Prime;

        public PrimeCallbackArg(int prime)
        {
            this.Prime = prime;
        }
    }

    class PrimeGenerator
    {
        //public delegate void PrimeDelegate(object sender, CallbackArg arg);
        
        //PrimeDelegate callbacks;

        /*
        public void AddDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
        }

        public void RemoveDelegate(PrimeDelegate callback)
        {
            callbacks = Delegate.Remove(callbacks, callback) as PrimeDelegate;
        }
        */

        public EventHandler PrimeGenerated;

        public void Run(int limit)
        {
            for(int i=2;i<=limit;i++)
            {
                if(IsPrime(i) == true && PrimeGenerated != null)
                {
                    //callbacks(this, new PrimeCallbackArg(i));
                    PrimeGenerated(this, new PrimeCallbackArg(i));
                }
            }
        }

        private bool IsPrime(int candidate)
        {
            if((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for(int i=3; (i*i) <= candidate; i+=2)
            {
                if((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }
    }

    class Program
    {
        //static void PrintPrime(object sender, CallbackArg arg)
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ", ");
        }

        static int Sum;

        //static void SumPrime(object sender, CallbackArg arg)
        static void SumPrime(object sender, EventArgs arg)
        {
            Sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            /*
            PrimeGenerator.PrimeDelegate callprint = PrintPrime;
            gen.AddDelegate(callprint);

            PrimeGenerator.PrimeDelegate callsum = SumPrime;
            gen.AddDelegate(callsum);
            */

            gen.PrimeGenerated += PrintPrime;
            gen.PrimeGenerated += SumPrime;

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(Sum);

            //gen.RemoveDelegate(callsum);
            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}
