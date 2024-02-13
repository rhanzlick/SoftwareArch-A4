using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;

namespace LibraryRefactor.Core
{
    [TestFixture]
    public class CCoreTests
    {
        
        private CCore core { get; set; }

        [SetUp]
        public void Setup()
        {
            core = new CCore();
        }

        //[Test]
        [TestCase("", "", ExpectedResult = "")]
        [TestCase("s1", "", ExpectedResult = "s1")]
        [TestCase("", "s2", ExpectedResult = "s2")]
        [TestCase("s1", "s2", ExpectedResult = "s1s2")]
        [TestCase(null, "s2", ExpectedResult = "s2")]
        [TestCase("s1", null, ExpectedResult = "s1")]
        public string TestCombineStringMethod(string inputVal1, string inputVal2)
        {

            return core.combineString(inputVal1, inputVal2);

        }

        [TearDown]
        public void CombineStringTeardown()
        {
            core = null;
        }
    }
}
