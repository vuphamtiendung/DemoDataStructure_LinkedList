using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class CustomeLinkedList<T> where T : IComparable
    {
        public Node<T> Header { get; set; } = new Node<T>(); // 
        /// <summary>
        /// Find data at node in the next node
        /// Find node has value follow require
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<T> Find(T data)
        {
            var currentNode = Header;
            while(currentNode.next != null && currentNode.data?.CompareTo(data) != 0) currentNode = currentNode.next;
            if (currentNode != Header) return currentNode;
            return null;
        }
        /// <summary>
        /// FindPrevious find node in front of the node has value corresponding
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<T> FindPrevious(T data)
        {
            var currentNode = Header;
            while (currentNode.next != null && currentNode.next.data?.CompareTo(data) != 0) currentNode = currentNode.next;
            if (currentNode != Header) return currentNode;
            return null;
        }

        /// <summary>
        /// Insert a node behind node difference with two overloading
        /// </summary>
        /// <param name="data"></param>
        /// <param name="afterValue"></param>
        /// <returns></returns>
        public Node<T> Insert(T data, T afterValue)
        {
            var newNode = new Node<T>(data); // create new node
            var currentNode = Find(afterValue); // find 
            if (currentNode != null)
            {
                newNode.next = currentNode.next; // pointer of the new node -> pointer of the current node
                currentNode.next = newNode;
                return newNode;
            }
            return null;
        }

        public Node<T> Insert(T data, Node<T> afterNode)
        {
            var newNode = new Node<T>(data)
            {
                next = afterNode.next
            };
            afterNode.next = newNode;
            return newNode;
        }

        /// <summary>
        /// Add more an node at the end of the linkedlist
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Node<T> Add(T data)
        {
            var currentNode = Header;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }
            var newNode = new Node<T>(data);
            currentNode.next = newNode;
            return newNode;
        }

        /// <summary>
        /// Remove a node of the linkedlist
        /// </summary>
        /// <param name="data"></param>
        public void Remove(T data)
        {
            var previousNode = FindPrevious(data);
            if (previousNode != null) previousNode.next = previousNode.next.next;

        }

        /// <summary>
        /// Traverse linkedlist and act implement anytrhing on once element
        /// </summary>
        /// <param name="action"></param>
        public void Traverse(Action<T> action)
        {
            var currentNode = Header;
            while(currentNode.next != null)
            {
                action?.Invoke(currentNode.next.data);
                currentNode = currentNode.next;
            }
        }
    }
}
