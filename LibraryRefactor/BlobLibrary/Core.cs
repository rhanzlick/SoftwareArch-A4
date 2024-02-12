using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlobLibrary
{
    public class Core
    {
        /// <summary>
        /// This is an example of an exported variable
        /// </summary>
        public int nCore { get; set; } = 0;

        /// <summary>
        /// This is an example of an exported function.
        /// </summary>
        /// <returns></returns>
        public int fnCore()
        {
            return 0;
        }

        /// <summary>
        /// This is the constructor of a class that has been exported.
        /// </summary>
        public Core()
        {

        }

        /// <summary>
        /// Case Sensitive Implementation of startsWith()
        /// It checks if the string 'mainStr' starts with given string 'toMatch'</summary>
        /// https://thispointer.com/c-check-if-a-string-starts-with-an-another-given-string/<param name="stringOne"></param>
        /// <param name="stringTwo"></param>
        /// <returns></returns>
        public string combineString(string stringOne, string stringTwo)
        {
            if (stringOne == "") return stringTwo;
            else if (stringTwo == "") return stringOne;
            else return stringOne + stringTwo;
        }


    }
}
