using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    /// <summary>
    /// 深度优先搜索，回溯
    /// </summary>
    class LeetCode39
    {
        private int[] sorted;
        private IList<IList<int>> finalResults;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            finalResults = new List<IList<int>>();
            sorted=candidates.OrderBy(t => t).ToArray();
            DFS(new List<int>(), target, 0);
            return finalResults;
        }


        private void DFS(IList<int> result,int target,int l)
        {
            if(target==0)
            {
                finalResults.Add(new List<int>(result));
                return;
            }else if(target<0)
            {
                return;
            }
            else
            {
                for(int i= l;i<sorted.Length;i++)
                {
                    result.Add(sorted[i]);
                    DFS(result, target-sorted[i], i);
                    result.RemoveAt(result.Count-1);
                }
            }
        }
    }
}
