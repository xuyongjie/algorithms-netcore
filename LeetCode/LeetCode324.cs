using System;

namespace Algorithmsnetcore.LeetCode
{
    public class LeetCode324
    {
        public void WiggleSort(int[] nums)
        {

            int[] cp=new int[nums.Length];
            Array.Copy(nums,cp,nums.Length);
            Array.Sort(cp);
            
        }
    }
}