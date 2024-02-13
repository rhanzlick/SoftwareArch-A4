using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application
{
    public class BusinessIntelligence
    {
        private BusinessIntelligence()
        {
            CCore.fnCore();
        }
        public static BusinessIntelligence theBusinessIntelligence { get; set; }
        public static BusinessIntelligence GetBusinessIntelligence()
        {
            if(theBusinessIntelligence == null) theBusinessIntelligence = new BusinessIntelligence();
            return theBusinessIntelligence;
        }

        public void LogSomething(string something)
        {
            Console.WriteLine($"BusinessIntelligence LogSomething {something}");
        }

        
    }
}
