using System;
namespace MethodOverloading
{
    public class Methods
    {
        public static int Add (int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add (decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add( int num1, int num2, bool isMoney)
        {
            int sum = num1 + num2;
            if (isMoney == true)
            {
                if (sum == 1)
                {
                    return $"{num1 + num2} dollar";
                }
                else if (sum >= 0)
                {
                    return $"{sum} dollars";
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}

