using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application
{
    public class MyApplication1 : IDisposable
    {
        private ArrayBasedLinkedList m_arrayBasedLinkedList { get; set; }

        /// <summary>
        /// This class does something entirely different than <see cref="MyApplication2"/>
        /// </summary>
        public MyApplication1()
        {
            
        }

        public void DoWork()
        {
            BusinessIntelligence.GetBusinessIntelligence().LogSomething("MyApp1");
            m_arrayBasedLinkedList = new ArrayBasedLinkedList();
            m_arrayBasedLinkedList.add(11);
        }

        public void Dispose()
        {
            m_arrayBasedLinkedList?.clear();
            m_arrayBasedLinkedList?.Dispose();
        }
    }
}
