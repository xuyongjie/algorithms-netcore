using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithmsnetcore.Common.Map.Base;

namespace Algorithmsnetcore.Common.Map.DFS
{
    class DFSTest
    {
        private DFS<int> _dfs;
        public DFSTest()
        {
            AdjacencyList<int> adjacencyList = new AdjacencyList<int>();
            ForDFSNode<int> firstHead = new ForDFSNode<int> { Data = 1 };
            ForDFSNode<int> secondHead = new ForDFSNode<int> { Data = 2 };
            ForDFSNode<int> thirdHead = new ForDFSNode<int> { Data = 3 };
            ForDFSNode<int> forthHead = new ForDFSNode<int> { Data = 4 };
            adjacencyList.Nodes.AddRange(new List<ForDFSNode<int>> { firstHead, secondHead, thirdHead, forthHead });
            adjacencyList.NeighborsList.Add(firstHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(secondHead, new List<Node<int>> { firstHead, thirdHead, forthHead });
            adjacencyList.NeighborsList.Add(thirdHead, new List<Node<int>> { secondHead, forthHead });
            adjacencyList.NeighborsList.Add(forthHead, new List<Node<int>> { firstHead, secondHead, thirdHead });
            _dfs = new DFS<int>(adjacencyList);
        }
        public void DoDFS()
        {
            _dfs.DoSearch();
        }
    }
}
