using System;

namespace Assignment1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }

        public static bool IsValidPhoneNumber(string str)
        {
            int len = str.Length;
            if(len == 14)
            {
                if(str[0] == '(' && str[4] == ')' && str[5] == ' ' && str[9] == '-')
                {
                    for(int i=1; i<len; i++)
                    {
                        if (i == 4) i = i + 2;
                        if (i == 9) i++;
                        if(str[i] < '0' || str[i] > '9')
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
