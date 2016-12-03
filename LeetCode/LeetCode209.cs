using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode209
    {
        public int MinSubArrayLen(int s, int[] nums)
        {
            if(nums==null||nums.Length==0)
            {
                return 0;
            }
            int start = 0, end = 0;
            int sum = nums[0];
            int result = int.MaxValue;
            while (true)
            {
                if (sum >= s)
                {
                    result = Math.Min(result, end - start + 1);
                    if (result == 1)
                    {
                        return 1;
                    }
                    sum -= nums[start];
                    start++;
                }
                else
                {
                    end++;
                    if (end < nums.Length)
                    {
                        sum += nums[end];
                    }else{
                        break;
                    }
                }
            }
            return result == int.MaxValue ? 0 : result;
        }
    }
}