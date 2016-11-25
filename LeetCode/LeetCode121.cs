using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode121
    {
        public int MaxProfit(int[] prices)
        {
            int max = 0;
            int formerDaySaleMax = 0;
            int length = prices.Length;
            for (int i = 1; i < length; i++)
            {
                //formerDaySaleMax = Math.Max(formerDaySaleMax + prices[i] - prices[i - 1],prices[i]-prices[i-1]);
                formerDaySaleMax = formerDaySaleMax > 0 ? formerDaySaleMax + prices[i] - prices[i - 1] : prices[i] - prices[i - 1];
                max = formerDaySaleMax > max ? formerDaySaleMax : max;
            }
            return max;
        }
    }
}
