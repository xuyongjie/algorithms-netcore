using Algorithmsnetcore.Common.Map.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.Map.BFS
{
    class BFS<DataType>
    {
        private AdjacencyList<DataType> _list;
        public BFS(AdjacencyList<DataType> list)
        {
            _list = list;
        }

        public void DoSearch(ForBFSNode<DataType> start)
        {
            Queue<ForBFSNode<DataType>> queue = new Queue<ForBFSNode<DataType>>();
            start.Color = NodeColor.GRAY;
            start.Parent = null;
            queue.Enqueue(start);
            while(queue.Count>0)
            {
                ForBFSNode<DataType> item = queue.Dequeue();
                Console.WriteLine("node {0},parent is {1}",item.Data,item.Parent==null?"null": item.Parent.Data.ToString());
                foreach(var each in _list.NeighborsList[item])
                {
                    ForBFSNode<DataType> bfsNode = (ForBFSNode<DataType>)each;
                    if(bfsNode.Color==NodeColor.WHITE)
                    {
                        bfsNode.Color = NodeColor.GRAY;
                        bfsNode.Parent = item;
                        queue.Enqueue(bfsNode);
                    }
                }
                item.Color = NodeColor.BLACK;
            }
        }

    }
}
