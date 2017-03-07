using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    //AC，先对数组进行排序，然后两个指针往后遍历
    public class LeetCode350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> result=new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int len1=nums1.Length;
            int len2=nums2.Length;
            int i=0,j=0;
            while(i<len1&&j<len2)
            {
                if(nums1[i]<nums2[j])
                {
                    i++;
                }else if(nums1[i]==nums2[j])
                {
                    result.Add(nums1[i]);
                    i++;
                    j++;
                }else{
                    j++;
                }
            }
            return result.ToArray();
        }
        //二分搜索
        private bool BinarySearch(int[] nums,int start,int end,int data)
        {
            if(start>end||(start==end&&nums[start]!=data))
            {
                return false;
            }
            int middle=(start+end)/2;
            int temp=nums[middle];
            if(temp<data)
            {
                return BinarySearch(nums,middle+1,end,data);
            }else if(temp==data)
            {
                return true;
            }else{
                return BinarySearch(nums,start,middle-1,data);
            }
        }
    }
}