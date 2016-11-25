using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode453
    {
        /// <summary>
        /// 每次需要将除了最大的数以外的数都加1，即相当于每次把最大的数减1，直到所有的数都等于最小的数为止，所以结果就是所有元素之和减去最小数乘以个数
        /// 即 Total-Min*Length
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinMoves(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int total = 0;
            int min = nums[0];
            foreach (int temp in nums)
            {
                total += temp;
                min = min > temp ? temp : min;
            }
            return total - min * nums.Length;
        }
    }
}
