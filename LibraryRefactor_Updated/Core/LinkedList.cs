using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Core
{
    public abstract class ILinkedList
    {
        protected int m_count { get; set; } = 0;

        /// <summary>
        /// Adds a value to the LinkedList. Return True if able to, otherwise false.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public abstract bool add(int val);

        /// <summary>
        /// Remove all elements from LinkedList
        /// </summary>
        public abstract void clear();

        /// <summary>
        /// returns true if list is empty, otherwise true.
        /// </summary>
        /// <returns></returns>
        public abstract bool isEmpty();

        /// <summary>
        /// Remove a value to the LinkedList. Return true if able to, otherwise false.
        /// Will only remove one entry if there are multiple entries with the same value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public abstract bool remove(int val);

        public abstract string toString();

        public void LogSomething(string something)
        {
            //Console.WriteLine($"BusinessIntelligence LogSomething {something}");
            Console.WriteLine($"BusinessIntelligence->LinkedList LogSomething {something}");
        }

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
            Console.WriteLine($"Deleting node with value {m_value}\n");
            //TODO - hint, you can recursively handle this
        }
    }

    public class PointerBasedLinkedList : ILinkedList, IDisposable
    {
        private Node m_head { get; set; }

        public PointerBasedLinkedList() { }

        public override bool isEmpty()
        {
            return false;
            //TODO
        }

        public override bool add(int val)
        {
            return false;
            //TODO
        }

        public override void clear()
        {
            m_head = null;
        }

        public override bool remove(int val)
        {
            //TODO
            return false;
        }

        public override string toString()
        {
            string str = "";
            return str;
        }

        public void Dispose()
        {
            return;
        }
    }

    public class ArrayBasedLinkedList : ILinkedList, IDisposable
    {
        public int[] m_values { get; set; } = new int[10];

        public ArrayBasedLinkedList()
        {
            
        }

        public override bool isEmpty()
        {
            return true;
            //TODO
        }

        public override bool add(int val)
        {
            //TODO
            return false;
        }

        public override bool remove(int val)
        {
            //TODO
            return false;
        }

        public override void clear()
        {
            //BusinessIntelligence.GetBusinessIntelligence().LogSomething("Something");
            LogSomething("Something");
            //TODO
        }

        public override string toString()
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

    
}
