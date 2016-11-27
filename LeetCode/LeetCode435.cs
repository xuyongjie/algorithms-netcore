using System.Linq;

namespace Algorithmsnetcore.LeetCode
{
    /****
    Given a collection of intervals, find the minimum number of intervals you need to remove to 
    make the rest of the intervals non-overlapping.

    Note:
    You may assume the interval's end point is always bigger than its start point.
    Intervals like [1,2] and [2,3] have borders "touching" but they don't overlap each other.
    
    Example 1:
    Input: [ [1,2], [2,3], [3,4], [1,3] ]

    Output: 1

    Explanation: [1,3] can be removed and the rest of intervals are non-overlapping.
    */

    //Definition for an interval.
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }
    //遇到区间问题往往可以考虑先排个序
    //将所有区间按end进行排序，然后从前往后比较当前区间end与下一个区间start值，若end<=start说明不相交，继续往后比较，若end>start则相交
    //remove第二个节点继续向后比较
    class LeetCode435
    {
        public int EraseOverlapIntervals(Interval[] intervals)
        {
            if (intervals == null || intervals.Length == 0)
            {
                return 0;
            }
            int removes = 0;
            var sorted = intervals.OrderBy(i => i.end).ToArray();
            Interval cur = sorted[0];
            for (int i = 0; i < sorted.Length - 1; i++)
            {
                if (cur.end <= sorted[i + 1].start)
                {
                    cur = sorted[i + 1];
                }
                else
                {
                    removes++;
                }
            }
            return removes;
        }
    }
}