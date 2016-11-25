using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithmsnetcore.Common.Map.Base;

namespace Algorithmsnetcore.Common.Map.BFS
{
    class BFSTest
    {
        private BFS<int> _bfs;
        private ForBFSNode<int> _startNode;
        public BFSTest()
        {
            AdjacencyList<int> adjacencyList = new AdjacencyList<int>();
            ForBFSNode<int> firstHead = new ForBFSNode<int> { Data = 1 };
            _startNode = firstHead;
            ForBFSNode<int> secondHead = new ForBFSNode<int> { Data = 2 };
            ForBFSNode<int> thirdHead = new ForBFSNode<int> { Data = 3 };
            ForBFSNode<int> forthHead = new ForBFSNode<int> { Data = 4 };
            adjacencyList.Nodes.AddRange(new List<ForBFSNode<int>>{ firstHead,secondHead,thirdHead,forthHead});
            adjacencyList.NeighborsList.Add(firstHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(secondHead, new List<Node<int>> { firstHead,thirdHead, forthHead });
            adjacencyList.NeighborsList.Add(thirdHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(forthHead, new List<Node<int>> { firstHead, secondHead, thirdHead });
            _bfs = new BFS<int>(adjacencyList);
        }

        public void DoBFS()
        {
            _bfs.DoSearch(_startNode);
        }
    }
}
