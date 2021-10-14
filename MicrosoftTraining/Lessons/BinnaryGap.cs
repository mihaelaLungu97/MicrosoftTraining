using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftTraining.Lessons
{
    public class BinnaryGap
    {
        public static void BinaryGap(int n)
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

    }
}
