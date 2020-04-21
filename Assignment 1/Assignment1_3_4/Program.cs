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

        public static string LettersOnly(string str)
        {
            int len = str.Length;
            List<char> mlist = new List<char>();

            for (int i = 0; i < len; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z' || str[i] >= 'a' && str[i] <= 'z')
                {
                    mlist.Add(str[i]);
                }
            }
            
            var ind = new string(mlist.ToArray());

            return ind;
        }
    }
}
