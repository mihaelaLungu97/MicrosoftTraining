using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftTraining.Lessons
{
    public  class TimeComplexity
    {
        /*
         A small frog wants to get to the other side of the road. The frog is currently 
        located at position X and wants to get to a position greater than or equal to Y.
        The small frog always jumps a fixed distance, D.

         Count the minimal number of jumps that the small frog must perform to reach its target.
        Write a function:
        that, given three integers X, Y and D, returns the minimal number of jumps from 
        position X to a position equal to or greater than Y.

For example, given:
  X = 10
  Y = 85
  D = 30

the function should return 3, because the frog will be positioned as follows:

        after the first jump, at position 10 + 30 = 40
        after the second jump, at position 10 + 30 + 30 = 70
        after the third jump, at position 10 + 30 + 30 + 30 = 100


         */
        public static int FrogJump(int X, int Y, int D)
        {
            int nr = 0;
            while (X < Y)
            {
                nr++;
                X += D;
            }
            return nr;
        }

        public static int FrogJumpEfficient(int X, int Y, int D)
        {
            if((Y-X) % D == 0)
            {
                return (Y - X) % D;
            }
            else
            {
                return (Y - X) % D +1;
            }
        }
        /*
         An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], which means that exactly one element is missing.

        Your goal is to find that missing element.

        Write a function:

            class Solution { public int solution(int[] A); }

        that, given an array A, returns the value of the missing element.

        For example, given array A such that:
          A[0] = 2
          A[1] = 3
          A[2] = 1
          A[3] = 5

        the function should return 4, as it is the missing element.*/
        public static int PermMissingElem(int[] A)
        {

            return ((A.Length + 1) * (A.Length + 2)) / 2 - A.Sum();
        }

        /*
         For example, consider array A such that:
  A[0] = 3
  A[1] = 1
  A[2] = 2
  A[3] = 4
  A[4] = 3

We can split this tape in four places:

        P = 1, difference = |3 − 10| = 7
        P = 2, difference = |4 − 9| = 5
        P = 3, difference = |6 − 7| = 1
        P = 4, difference = |10 − 3| = 7

Write a function:
that, given a non-empty array A of N integers, returns the minimal difference that
        can be achieved. for example above the result should be 1.
         */
        public int TapeEquilibrium(int[] A)
        {
            // write your code in C# with .NET 2.0
            int sumRight = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumRight += A[i];
            }

            int sumLeft = 0;
            int min = int.MaxValue;
            for (int P = 1; P < A.Length; P++)
            {
                int currentP = A[P - 1];
                sumLeft += currentP;
                sumRight -= currentP;

                int diff = Math.Abs(sumLeft - sumRight);
                if (diff < min)
                {
                    min = diff;
                }
            }
            return min;
        }
    }
}
