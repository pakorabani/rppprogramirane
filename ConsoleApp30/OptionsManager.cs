using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public static class OptionsManager
    {
        public static int  ConuntLess100(int[] arr)
        {
            return arr.Count(x => x < 100);
        }

        public static int MaxNum(int[] arr)
        {
            return arr.Max();
        }

        public static int[] ReverseArr(int[] arr)
        {
            return arr.Reverse().ToArray();
        }

        public static void PrintArr(int[] arr)
        {
            Console.WriteLine(string.Join(", ",arr));
        }

        public static void EvenNums(int[] arr)
        {
            int even = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even += arr[i];
                }
            }
      

            Console.WriteLine(even);
        }
    }
}
