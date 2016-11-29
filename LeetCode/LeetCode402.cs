using System.Text;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode402
    {
        public string RemoveKdigits(string num, int k)
        {
            StringBuilder minResultBuilder = Remove(new StringBuilder(num), k);
            string minResult=minResultBuilder.ToString();
            while (!string.IsNullOrEmpty(minResult)&& minResult[0] == '0')
            {
                minResult = minResult.Remove(0, 1);
            }
            return string.IsNullOrEmpty(minResult) ? "0" : minResult;
        }

        private StringBuilder Remove(StringBuilder num, int k)
        {
            int removedCount = 0;
            while (removedCount < k)
            {
                int i = 0;
                for (i = 0; i < num.Length - 1; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        break;
                    }
                }
                num = num.Remove(i, 1);
                removedCount++;
            }
            return num;
        }
    }
}