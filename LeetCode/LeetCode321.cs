using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode321
    {
        public int[] MaxNumber(int[] nums1, int[] nums2, int k)
        {
            if(k==0)
            {
                return null;
            }
            int[] max = null;
            for(int i=0;i<=k;i++)
            {
                int[] tempResult = CombineTwoArray(GetMaxFromOneArray(nums1, i), GetMaxFromOneArray(nums2, k - i));
                if(Bigger(tempResult,max))
                {
                    max = tempResult;
                }
            }
            return max;
        }

        private int[] GetMaxFromOneArray(int[] nums, int count)
        {
            if(count==0)
            {
                return null;
            }
            int length = nums.Length;
            int[,] dp = new int[length, count + 1];
            for (int i = 0; i < length; i++)
            {
                dp[i, 0] = 0;
            }
            dp[0, 1] = nums[0];
            for (int i = 1; i < length; i++)
            {
                for (int j = 1; j <= i + 1 && j <= count; j++)
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i - 1, j - 1] * 10 + nums[i]);
                }
            }
            return IntToArray(dp[length - 1, count]);
        }

        private int[] IntToArray(int number)
        {
            Stack<int> s = new Stack<int>();
            do
            {
                s.Push(number % 10);
                number = number / 10;
            } while (number != 0);
            return s.ToArray();
        }

        private int[] CombineTwoArray(int[] max1, int[] max2)
        {
            if(max1==null)
            {
                return max2;
            }
            if(max2==null)
            {
                return max1;
            }
            int m = max1.Length;
            int n = max2.Length;
            int[] result = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (k < m + n)
            {
                if (i < m && j < n)
                {
                    if (max1[i] > max2[j])
                    {
                        result[k] = max1[i];
                        i++;
                    }
                    else
                    {
                        result[k] = max2[j];
                        j++;
                    }
                }
                else
                {
                    if (i >= m)
                    {
                        result[k] = max2[j];
                        j++;
                    }
                    else
                    {
                        result[k] = max1[i];
                        i++;
                    }
                }
                k++;
            }
            return result;
        }

        private bool Bigger(int[] nums1,int[] nums2)
        {
            if(nums2==null)
            {
                return true;
            }
            for(int i=0;i<nums1.Length;i++)
            {
                if(nums1[i]>nums2[i])
                {
                    return true;
                }
                else if(nums1[i]<nums2[i])
                {
                    return false;
                }
            }
            return false;
        }
        
    }
}
