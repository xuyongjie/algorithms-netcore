using System;
using System.Collections.Generic;
namespace Algorithmsnetcore.LeetCode
{
    public class LeetCode228 {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> results=new List<string>();
        if(nums==null||nums.Length<=0)
        {
            return results;
        }
        int start=nums[0];
        int end=start;
        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i]!=end+1)
            {
                results.Add(start==end?(start+""):(start+"->"+end));
                start=end=nums[i];
            }else
            {
                end++;
            }
        }
        results.Add(start==end?(start+""):(start+"->"+end));
        return results;
    }
}
}
