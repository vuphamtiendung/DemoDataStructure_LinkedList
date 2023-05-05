using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T> where T : IComparable
    {
        public T data { get; set; } 
        public Node<T> next { get; set; }
        public Node()
        {
            data = default;
            next = null;
        }

        public Node(T element)
        {
            data = element;
            next = null;
        }
    }
}
