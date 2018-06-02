using System;
namespace cSharpProjectEulerSolutions
{
    public partial class ProjectEuler
    {
        // The following problem is taken from Project Euler.
       // http://projecteuler.net/problem=2
         /*********** Even Fibonacci numbers  ****************** */
       /*
       Each new term in the Fibonacci sequence is generated by adding the previous two terms.
       By starting with 1 and 2, the first 10 terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
        find the sum of the even-valued terms.
        */
        public void p2()
        {
            Console.WriteLine("ProjectEuler Problem #2:");
            //Formula Fn=(Fn-2) + (Fn-1)
            //        next Fibonacci= First Fibonacci + Second Fibonacci
            //        fn=fn2 + fn1
            //        1= 0 + 1
            int fn2 = 0;
            int fn1 = 1;
            int fn = 1;
            int sum = 0;
            while (fn < 4000000)  // continue until the fibonacci number fn is not exceed four million.
            {
                fn = fn1 + fn2; // calculate the next fibonacci sequence number
                if (fn % 2 == 0)  // if the fibonacci number is even calculate the sum.
                {
                    sum = sum + fn;
                }
                fn2 = fn1;
                fn1 = fn;
            }
            Console.WriteLine("Answer for the Problem #2 is : {0}", sum.ToString());
        }
    }
}