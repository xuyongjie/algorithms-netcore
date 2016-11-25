using Algorithmsnetcore.Common.Map.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.Map.BFS
{
    class ForBFSNode<T>:Node<T>
    {
        public ForBFSNode()
        {
            Parent = null;
            Color = NodeColor.WHITE;
        }
        public ForBFSNode<T> Parent { get; set; }
        public NodeColor Color { get; set; }
    }
}
