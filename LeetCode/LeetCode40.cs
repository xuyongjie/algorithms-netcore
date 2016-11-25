using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    class LeetCode40
    {
        private int[] sorted;
        private IList<IList<int>> finalResults;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            finalResults = new List<IList<int>>();
            sorted = candidates.OrderBy(t => t).ToArray();
            DFS(new List<int>(), target, 0);
            return finalResults;
        }


        private void DFS(IList<int> result, int target, int l)
        {
            if (target == 0)
            {
                bool exist = false;//去重
                foreach (var item in finalResults)
                {
                    if (item.Count != result.Count)
                    {
                        continue;
                    }
                    int t = 0;
                    while (t < item.Count)
                    {
                        if (item[t] != result[t])
                        {
                            break;
                        }
                        t++;
                    }
                    if(t==item.Count)
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    finalResults.Add(new List<int>(result));
                }
                return;
            }
            else if (target < 0)
            {
                return;
            }
            else
            {
                for (int i = l + 1; i < sorted.Length; i++)
                {
                    result.Add(sorted[i]);
                    DFS(result, target - sorted[i], i + 1);
                    result.RemoveAt(result.Count - 1);
                }
            }
        }
        private int Sum(IList<int> res)
        {
            int total = 0;
            foreach (var item in res)
            {
                total += item;
            }
            return total;
        }
    }
}
