using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobLibrary
{
    public class MyApplication2 : IDisposable
    {
        private PointerBasedLinkedList m_PointerBasedLinkedList { get; set; }

        /// <summary>
        /// This class does something entirely different than <see cref="MyApplication1"/>
        /// </summary>
        public MyApplication2()
        {
            
        }

        public void DoWork()
        {
            BusinessIntelligence.GetBusinessIntelligence().LogSomething("MyApp2");
            m_PointerBasedLinkedList = new PointerBasedLinkedList();
            m_PointerBasedLinkedList.add(22);

        }

        public void Dispose()
        {
            m_PointerBasedLinkedList?.clear();
            m_PointerBasedLinkedList?.Dispose();
        }
    }
}
