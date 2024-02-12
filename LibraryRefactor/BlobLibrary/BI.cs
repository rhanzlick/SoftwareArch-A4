using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobLibrary
{
    public class BusinessIntelligence
    {
        private BusinessIntelligence() { }
        public static BusinessIntelligence theBusinessIntelligence { get; set; }

        public void LogSomething(string something)
        {
            Console.WriteLine($"BusinessIntelligence LogSomething {something}\n");
        }

        public static BusinessIntelligence GetBusinessIntelligence()
        {
            return theBusinessIntelligence;
        }
    }
}
