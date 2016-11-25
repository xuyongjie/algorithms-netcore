using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode442
    {
        //如果nums[i]第一次出现，则置nums[Abs(nums[i])-1]的值乘以-1
        //若检查nums[Abs(nums[i])-1]的值小于0，则nums[i]一定是第二次出现
        public IList<int> FindDuplicates(int[] nums)
        {
            List<int> results = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                if(nums[Math.Abs(nums[i])-1]<0)
                {
                    results.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }
            return results;
        }
    }
}
