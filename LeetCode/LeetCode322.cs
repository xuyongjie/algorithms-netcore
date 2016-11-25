using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    //dp[amount]=Min(dp[amount-conin[i]]+1),(0<=i<m)
    class LeetCode322
    {
        public int CoinChange(int[] coins, int amount)
        {
            int length = coins.Length;
            if(amount==0||length==0)
            {
                return 0;
            }
            int[] dp = new int[amount + 1];
            for(int i=0;i<=amount;i++)
            {
                dp[i] = amount + 1;
            }
            dp[0] = 0;
            for(int i=1;i<=amount;i++)
            {
                int tempMin = dp[i];
                for(int j=0;j<length;j++)
                {
                    if(i>=coins[j]&&dp[i-coins[j]]+1<tempMin)
                    {
                        tempMin = dp[i - coins[j]] + 1;
                    }
                }
                dp[i] = tempMin;
            }
            if(dp[amount]==amount+1)
            {
                return -1;
            }
            else
            {
                return dp[amount];
            }
        }
    }
}
