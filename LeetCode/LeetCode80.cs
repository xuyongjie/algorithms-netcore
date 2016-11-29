using System;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode80
    {
        public int RemoveDuplicates(int[] nums)
        {
            if(nums==null||nums.Length<1)
            {
                return 0;
            }
            int resultLength = 1;
            int sameCount = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[resultLength - 1])
                {
                    sameCount++;
                    if (sameCount <= 2)
                    {
                        nums[resultLength] = nums[i];
                        resultLength++;
                    }
                }else{
                    sameCount=1;
                    nums[resultLength]=nums[i];
                    resultLength++;
                }
            }
            return resultLength;
        }
    }
}