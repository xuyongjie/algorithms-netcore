using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    //该方法保存全排列内存超限
    //其实只要随机化一组下标就可以了
    public class LeetCode384
    {
        private int[] original;
        private List<int[]> all;
        public LeetCode384(int[] nums)
        {
            original = nums;
            used=new bool[nums.Length];
            all=new List<int[]>();
            int[] buffer=new int[nums.Length];
            Permutation(buffer,0);
        }

        /** Resets the array to its original configuration and return it. */
        public int[] reset()
        {
            return original;
        }

        /** Returns a random shuffling of the array. */
        public int[] shuffle()
        {
            int random=new Random().Next(all.Count);
            return all[random];
        }

        private bool[] used;
        private void Permutation(int[] temp,int okCount)
        {
            if(okCount==original.Length)
            {
                int[] res=new int[okCount];
                temp.CopyTo(res,0);
                all.Add(res);
                return;
            }
            for(int i=0;i<original.Length;i++)
            {
                if(!used[i])
                {
                    temp[okCount]=original[i];
                    used[i]=true;
                    Permutation(temp,okCount+1);
                    used[i]=false;
                }
            }
        }
    }
}