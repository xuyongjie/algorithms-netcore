namespace Algorithmsnetcore.LeetCode
{
    class LeetCode204
    {
        public int CountPrimes(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            
            bool[] prime = new bool[n];
            for(int i=2;i<n;i++)
            {
                prime[i]=true;
            }
            for (int i = 2; i < n; i++)
            {
                if (prime[i])
                {
                    int temp = i+i;
                    while(temp<n)
                    {
                        prime[temp]=false;
                        temp+=i;
                    }
                }
            }
            int count = 0;            
            for(int i=0;i<n;i++)
            {
                if(prime[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}