namespace Algorithmsnetcore.LeetCode
{
    class LeetCode137
    {
        //记录二进制位1出现的次数，模3余1就说明单独那个数该位为1
        public int SingleNumber(int[] nums)
        {
            int[] t=new int[32];
            for(int i=0;i<nums.Length;i++)
            {
                for(int j=0;j<32;j++)
                {
                    t[j]+=nums[i]>>(32-j)&1;
                }
            }
            int result=0;
            for(int i=0;i<32;i++)
            {
                result|=t[i]%3<<(32-i);
            }
            return result;
        }
    }
}