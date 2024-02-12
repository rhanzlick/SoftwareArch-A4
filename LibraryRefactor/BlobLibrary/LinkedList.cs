using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlobLibrary
{
    public class LinkedList : ILinkedList
    {
        protected int m_count { get; set; } = 0;

        public bool add(int val)
        {
            throw new NotImplementedException();
        }

        public void clear()
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public bool remote(int val)
        {
            throw new NotImplementedException();
        }

        public string toString()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This class is exported from the LinkedList
        /// </summary>



    }

    public interface ILinkedList
    {
        /// <summary>
        /// returns true if list is empty, otherwise true.
        /// </summary>
        /// <returns></returns>
        abstract bool isEmpty();

        /// <summary>
        /// Adds a value to the LinkedList. Return True if able to, otherwise false.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        abstract bool add(int val);

        /// <summary>
        /// Remove a value to the LinkedList. Return true if able to, otherwise false.
        /// Will only remove one entry if there are multiple entries with the same value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        abstract bool remote(int val);

        /// <summary>
        /// Remove all elements from LinkedList
        /// </summary>
        abstract void clear();


        abstract string toString();

    }

    public class Node : IDisposable
    {
        private int m_value;
        private Node m_next { get; set; }

        public Node()
        {
            m_value = -1;
        }

        public Node(int val)
        {
            m_value = val;
        }

        public Node(int val, Node nextNode)
        {
            //hello
            m_value = val;
            m_next = nextNode;
        }

        public void setItem(int val)
        {
            m_value = val;
        }

        public void setNext(Node nextNodePtr)
        {
            m_next = nextNodePtr;
        }

        int getItem()
        {
            return m_value;
        }

        Node getNext()
        {
            return m_next;
        }

        public void Dispose()
        {
            Console.WriteLine($"Deleting node with value {m_value}");
            //TODO - hint, you can recursively handle this
        }
    }

    public class ArrayBasedLinkedList : LinkedList, IDisposable
    {
        public int[] m_values { get; set; } = new int[10];

        public bool add(int val)
        {
            //TODO
            return false;
        }

        public void clear()
        {
            BusinessIntelligence.GetBusinessIntelligence().LogSomething("Something");
            //TODO
        }

        public bool isEmpty()
        {
            return true;
            //TODO
        }

        public bool remote(int val)
        {
            //TODO
            return false;
        }

        public string toString()
        {
            string str = "";

            //TODO

            return str;
        }

        public void Dispose()
        {
            return;
        }
    }

    public class PointerBasedLinkedList : LinkedList, IDisposable
    {
        private Node m_head { get; set; }

        public bool add(int val)
        {
            return false;
            //TODO
        }

        public void clear()
        {
            m_head = null;
        }

        public bool isEmpty()
        {
            return false;
            //TODO
        }

        public bool remote(int val)
        {
            //TODO
            return false;
        }

        public string toString()
        {
            string str = "";
            return str;
        }

        public void Dispose()
        {
            return;
        }
    }
}
