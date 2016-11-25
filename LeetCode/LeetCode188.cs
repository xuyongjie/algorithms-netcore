using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode188
    {
        private int[,] global;
        private int[,] local;
        public int MaxProfit(int k, int[] prices)
        {
            if (prices == null || prices.Length == 0 || k <= 0)
            {
                return 0;
            }
            int length = prices.Length;
            if(k>length/2)
            {
                int max = 0;
                for(int i=1;i<length;i++)
                {
                    max += Math.Max(prices[i] - prices[i - 1], 0);
                }
                return max;
            }

            global = new int[length, k+1];//存储第i天最多卖出j次的最大利润
            local = new int[length, k+1];//存储第i天最多卖出j次，并且第j次就是第i天卖出的最大利润
            for (int index = 0; index <= k; index++)
            {
                global[0, index] = 0;
                local[0, index] = 0;
            }
            for (int index = 0; index < length; index++)
            {
                global[index, 0] = 0;
                local[index, 0] = 0;
            }
            for (int j = 1; j <= k; j++)
            {
                for (int i = 1; i < length; i++)
                {
                    local[i, j] = Math.Max(global[i - 1, j - 1] + Math.Max(prices[i] - prices[i - 1], 0), local[i - 1, j] + prices[i] - prices[i - 1]);
                    global[i, j] = Math.Max(global[i - 1, j], local[i, j]);
                }
            }

            return global[length - 1, k];
        }
    }
}
