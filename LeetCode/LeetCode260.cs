namespace Algorithmsnetcore.LeetCode
{
    public class LeetCode260
    {
        //首先所有元素异或得出a^b
        //找出a^b的其中一位1（可以用t&-t）,然后以此位作为标志将数组分成两组，这样就把a和b分到了两个数组里，然后分别对每个数组异或，就得到a和b的值了
        public int[] SingleNumber(int[] nums)
        {
            int t=0;
            for(int i=0;i<nums.Length;i++)
            {
                t^=nums[i];
            }
            t&=-t;
            int[] result=new int[2];
            for(int i=0;i<nums.Length;i++)
            {
                if((t&nums[i])==0)
                {
                    result[0]^=nums[i];
                }else{
                    result[1]^=nums[i];
                }
            }
            return result;
        }
    }
}