using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    public class LeetCode1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < nums.Length; i++)
            {
                Item temp = new Item();
                temp.value = nums[i];
                temp.originalIndex = i;
                items.Add(temp);
            }
            items.Sort(new Comparison<Item>((item1, item2) => { return item1.value - item2.value; }));
            int start = 0, end = items.Count - 1;
            while (start < end)
            {
                int total = items[start].value + items[end].value;
                if (total == target)
                {
                    return new int[2] { items[start].originalIndex, items[end].originalIndex };
                }
                else if (total < target)
                {
                    start++;
                    continue;
                }
                else
                {
                    end--;
                    continue;
                }
            }
            return new int[2] { -1, -1 };
        }
    }

    public struct Item
    {
        public int value;
        public int originalIndex;
    }
}
