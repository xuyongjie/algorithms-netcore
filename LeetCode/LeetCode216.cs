using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode216
    {
        private IList<IList<int>> results;
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            results = new List<IList<int>>();
            DFS(new List<int>(), n, 0, 1, k);
            return results;
        }

        public void DFS(IList<int> result,int target,int count,int cur,int k)
        {
            if(target==0&&count==k)
            {
                results.Add(new List<int>(result));
                return;
            }
            if(target<0)
            {
                return;
            }
            if(count>=k)
            {
                return;
            }
            for(int i=cur;i<=9;i++)
            {
                result.Add(i);
                DFS(result, target - i, count + 1,i+1,k);
                result.RemoveAt(result.Count - 1);
            }
        }
    }
}
