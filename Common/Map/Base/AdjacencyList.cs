using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.Map.Base
{
    /// <summary>
    /// 图的邻接表表示
    /// </summary>
    class AdjacencyList<T>
    {
        public AdjacencyList()
        {
            Nodes = new List<Node<T>>();
            NeighborsList = new Dictionary<Node<T>, List<Node<T>>>();
        }
        public List<Node<T>> Nodes { get; set; }
        public Dictionary<Node<T>,List<Node<T>>> NeighborsList { get; set; }

    }
}
