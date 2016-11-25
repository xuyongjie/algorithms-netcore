using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithmsnetcore.Common.Map.Base;

namespace Algorithmsnetcore.Common.Map.DFS
{
    class DFS<T>
    {
        private int time;
        private AdjacencyList<T> _list;
        public DFS(AdjacencyList<T> list)
        {
            _list = list;
            time = 0;
        }


        public void DoSearch()
        {
            foreach(var item in _list.Nodes)
            {
                var node = (ForDFSNode<T>)item;
                if(node.Color==Base.NodeColor.WHITE)
                {
                    DoVisit(node);
                }
            }
        }

        private void DoVisit(ForDFSNode<T> node)
        {
            node.Color = Base.NodeColor.GRAY;
            node.StartTime = time;
            time++;
            Console.WriteLine("node {0} found in time {1} parent is {2}",node.Data,node.StartTime,node.Parent==null?"null":node.Parent.Data.ToString());
            foreach(var item in _list.NeighborsList[node])
            {
                var temp = (ForDFSNode<T>)item;
                if(temp.Color==Base.NodeColor.WHITE)
                {
                    temp.Parent = node;
                    DoVisit(temp);
                }
            }
            node.Color = Base.NodeColor.BLACK;
            node.EndTime = time;
            time++;
            Console.WriteLine("node {0} visited in time {1}", node.Data, node.EndTime);
        }
    }
}
