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


    }
}
