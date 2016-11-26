namespace Algorithmsnetcore.LeetCode
{
    class LeetCode136
    {
        public int SingleNumber(int[] nums)
        {
            int result=0;
            int len=nums.Length;
            for(int i=0;i<len;i++)
            {
                result=result^nums[i];
            }
            return result;
        }
    }
}