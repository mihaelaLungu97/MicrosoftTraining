namespace MicrosoftTraining
{
    internal class Program
    {
        public static void Gap(int n)
        {
            string binaryString = Convert.ToString(n, 2);
            int zeroHit = 0;
            int longest = 0;
            for (int i = 0; i < binaryString.Length; i++)
            {
                if (binaryString.Substring(i, i + 1).Equals('1'))
                {
                    if (zeroHit > longest) { longest = zeroHit; }
                    zeroHit = 0;
                }
                else { zeroHit++; }
            }
            Console.WriteLine(longest);
            //return longest;

            /* string binary = Convert.ToString(32, 2);
             string[] binaryList = binary.Split('1');
             int max = 0;
             foreach( var element  in binaryList)
             {
                 Console.WriteLine("Elementul din lista "+ element + " " + element.Length);
                 if(max <element.Length)
                 {
                     max = element.Length;
                 }


             }

             Console.WriteLine(max);*/
        }


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
        public static int[] ArrayTask1(int[] A, int K)
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
        static void Main(string[] args)
        {
            //Console.WriteLine(ArrayTask1( new int[] { 3, 8, 9, 7, 6, 0 }, 3));
            //var a = ArrayTask1(new int[] { 3, 8, 9, 7, 6, 0 }, 3);
            //Console.WriteLine("aaaaa");
        }
    }
}
