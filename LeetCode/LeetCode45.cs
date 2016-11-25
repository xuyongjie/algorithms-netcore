using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.LeetCode
{
    public class Node
    {
        public int Index { get; set; }
        public int Data { get; set; }
        public int Step { get; set; }
        public int Color { get; set; }//0 white,1 gray,2 black
    }
    /// <summary>
    /// BFS广度优先搜索，超时，投机取巧，for循环从后往前并达到最后一个立马返回可以AC
    /// 有待寻找更好方式解决此问题
    /// </summary>
    class LeetCode45
    {
        public int Jump(int[] nums)
        {
            int length = nums.Length;
            Node[] nodes = new Node[length];
            for (int i = 0; i < length; i++)
            {
                nodes[i] = new Node();
                nodes[i].Index = i;
                nodes[i].Data = nums[i];
                nodes[i].Step = 0;
                nodes[i].Color = 0;
            }
            Node start = nodes[0];
            start.Color = 1;
            start.Step = 0;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                Node cur = queue.Dequeue();
                for (int i = cur.Index + 1; i <= cur.Index + cur.Data && i < length; i++)
                {
                    if (nodes[i].Color == 0)
                    {
                        nodes[i].Step = cur.Step + 1;
                        nodes[i].Color = 1;
                        if (i == length - 1)//发现最后一个节点，直接返回step
                        {
                            return nodes[i].Step;
                        }
                        queue.Enqueue(nodes[i]);
                    }
                }
                cur.Color = 2;
            }
            return nodes[length - 1].Step;
        }

        public int jump2(int[] A, int n)
        {
            int ret = 0;//当前跳数  
            int last = 0;//上一跳可达最远距离  
            int curr = 0;//当前一跳可达最远距  
            for (int i = 0; i < n; ++i)
            {
                //无法向前继跳直接返回  
                if (i > curr)
                {
                    return -1;
                }
                //需要进行下次跳跃，则更新last和当执行的跳数ret  
                if (i > last)
                {
                    last = curr;
                    ++ret;
                }
                //记录当前可达的最远点  
                curr = Math.Max(curr, i + A[i]);
            }
            return ret;
        }

    }
}
