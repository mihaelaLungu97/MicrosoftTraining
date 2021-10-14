using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftTraining.Lessons
{
    public class Array_Lesson2
    {
        /*
         An array A consisting of N integers is given. Rotation of the array means that each element
        is shifted right by one index, and the last element of the array is moved to the first place.
        For example, the rotation of array A = [3, 8, 9, 7, 6] is [6, 3, 8, 9, 7]
        (elements are shifted right by one index and 6 is moved to the first place).
         The goal is to rotate array A K times; that is, each element of A will be shifted to the 
        right K times.
        For example, given
            A = [3, 8, 9, 7, 6]
            K = 3

        the function should return [9, 7, 6, 3, 8]. Three rotations were made:
          [3, 8, 9, 7, 6] -> [6, 3, 8, 9, 7]
          [6, 3, 8, 9, 7] -> [7, 6, 3, 8, 9]
          [7, 6, 3, 8, 9] -> [9, 7, 6, 3, 8]
         
         */
        public static int[] CyclinRotation(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] newArr = new int[A.Length];

            if (A.Length == 0) return A;
            K = K % A.Length;
            for (int i = 0; i < A.Length; i++)
            {

                newArr[i] = A[(i + (A.Length - K)) % (A.Length)];

            }

            return newArr;
        }

        /*
         
        A non-empty array A consisting of N integers is given. 
        The array contains an odd number of elements, and each element of the array can be 
        paired with another element that has the same value, except for one element that is left unpaired.
         For example, in array A such that:
             A[0] = 9  A[1] = 3  A[2] = 9
             A[3] = 3  A[4] = 9  A[5] = 7
             A[6] = 9

        the elements at indexes 0 and 2 have value 9,
        the elements at indexes 1 and 3 have value 3,
        the elements at indexes 4 and 6 have value 9,
        the element at index 5 has value 7 and is unpaired.

        Write a function:
        that, given an array A consisting of N integers fulfilling the above conditions, 
        returns the value of the unpaired element.

        */
        public static int OddOccurrencesInArray(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
            {
                return 0;
            }
            if (A.Length == 1)
            {
                return A[0];
            }
            Array.Sort(A);
            for (int i = 0; i < A.Length - 2; i += 2)
            {
                if (A[i] != A[i + 1])
                    return A[i];
            }
            return A[A.Length - 1];
        }
    }
}
