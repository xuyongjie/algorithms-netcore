using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int[] merge = new int[m + n];
            bool odd = (m + n) % 2 == 1;
            int i = 0, j = 0,index=0;
            while(index<=(m+n)/2)
            {
                if(i==m)
                {
                    merge[index] = nums2[j];
                    j++;
                    index++;
                    continue;
                }
                if (j == n)
                {
                    merge[index] = nums1[i];
                    i++;
                    index++;
                    continue;
                }

                if (nums1[i]<nums2[j])
                {
                    merge[index] = nums1[i];
                    i++;
                }
                else
                {
                    merge[index] = nums2[j];
                    j++;
                }
                index++;
            }
            if(odd)
            {
                return merge[(m + n) / 2];
            }
            else
            {
                return (merge[(m+n)/2-1]+merge[(m + n) / 2])/2.0;
            }
        }
    }
}
