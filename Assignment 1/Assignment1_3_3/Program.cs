using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }

        public static int[] IndexOfCapitals(string str)
        {
            int len = str.Length;
            IList<int> mlist = new List<int>();

            for (int i = 0; i < len; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    mlist.Add(i);
                }
            }
            int[] ind = mlist.ToArray();

            return ind;
        }
    }
}
