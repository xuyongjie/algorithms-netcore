using System;
using System.Collections.Generic;

namespace Algorithmsnetcore.LeetCode
{
    public class LeetCode310
    {
        public IList<int> FindMinHeightTrees(int n, int[,] edges)
        {
            if(edges.GetLength(0)<1)
            {
                return new List<int>(){0}; 
            }
            Dictionary<int,List<int>> dic=new Dictionary<int,List<int>>();
            for(int i=0;i<edges.GetLength(0);i++)
            {
                if(dic.ContainsKey(edges[i,0]))
                {
                    dic[edges[i,0]].Add(edges[i,1]);
                }else{
                    List<int> value=new List<int>();
                    value.Add(edges[i,1]);
                    dic.Add(edges[i,0],value);
                }

                if(dic.ContainsKey(edges[i,1]))
                {
                    dic[edges[i,1]].Add(edges[i,0]);
                }else{
                    List<int> value=new List<int>();
                    value.Add(edges[i,0]);
                    dic.Add(edges[i,1],value);
                }

            }
            int minheigth=int.MaxValue;
            IList<int> result=new List<int>(); 
            for(int i=0;i<n;i++)
            {
                int currentHeight=GetHeight(n,i,dic);
                if(currentHeight<minheigth)
                {
                    minheigth=currentHeight;
                    result.Clear();
                    result.Add(i);
                }else if(currentHeight==minheigth)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private int GetHeight(int n,int start,Dictionary<int,List<int>> dic)
        {
            int height=0;
            Queue<int> searchQueue=new Queue<int>();
            int[] searched=new int[n];
            int[] level=new int[n];
            searchQueue.Enqueue(start);
            level[start]=0;
            while(searchQueue.Count>0)
            {
                int temp=searchQueue.Dequeue();
                foreach(var item in dic[temp])
                {
                    if(searched[item]==0)
                    {
                        searchQueue.Enqueue(item);
                        level[item]=level[temp]+1;
                        height=level[item]>height?level[item]:height;
                    }
                }
                searched[temp]=1;
            }
            return height;
        }
    }
}