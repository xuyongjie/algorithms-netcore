using Algorithmsnetcore.Common.Map.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.Map.DFS
{
    class ForDFSNode<T>:Node<T>
    {
        public ForDFSNode()
        {
            Parent = null;
            Color = NodeColor.WHITE;
            StartTime = 0;
            EndTime = 0;
        }
        public ForDFSNode<T> Parent { get; set; }
        public NodeColor Color { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
    }
}
