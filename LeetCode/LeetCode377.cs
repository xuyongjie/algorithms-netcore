using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode377
    {
        //dp[target]=dp[target-nums[i]](i=0->nums.Length-1)
    public int CombinationSum4(int[] nums, int target) {
        int[] dp=new int[target+1];
        dp[0]=1;
        for(int i=1;i<=target;i++)
        {
            for(int j=0;j<nums.Length;j++)
            {
                if(i-nums[j]>=0)
                {
                dp[i]+=dp[i-nums[j]];                    
                }
            }
        }
        return dp[target];
    }
    }
}
