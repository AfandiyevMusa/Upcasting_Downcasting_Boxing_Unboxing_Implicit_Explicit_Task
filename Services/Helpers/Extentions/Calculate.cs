using System;
namespace Services.Helpers.Extentions
{
    public static class Calculate
    {
        public static int CalculateFactorial(this int num)
        {
            int res = 1;

            for(int i = 1; i <= num; i++)
            {
                res *= i;
            }

            return res;
        }
    }
}

