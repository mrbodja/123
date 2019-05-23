using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProj
{
   public  class MyMath
    {
        public double Sum(int[] intArray)
        {
            double sum = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            return sum;
        }
        public double SerAryf(int []intArray)
        {
            double ser = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                ser += intArray[i];
            }
            return ser / intArray.Length;
        }
        public int MaxValue(int[] intArray)
        {
            int maxVal = intArray[0];
            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }
    }
}
