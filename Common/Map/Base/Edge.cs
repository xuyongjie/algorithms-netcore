using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithmsnetcore.Common.Map.Base
{
    /// <summary>
    /// 图的边
    /// </summary>
    class Edge<T>
    {
        public Edge(Node<T> from,Node<T> to)
        {
            From = from;
            To = to;
        }
        public Node<T> From { get; set; }
        public Node<T> To { get; set; }
    }
}
