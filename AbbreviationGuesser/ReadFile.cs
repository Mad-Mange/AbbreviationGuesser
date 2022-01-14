using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbreviationGuesser
{
    public class ReadFile
    {
        public static Dictionary<string, string> ReadOutAbbrevations()
        {
            var myAbbList = new Dictionary<string, string>();

            // Check out Ellies way to handle Json readout with model

            myAbbList = File.ReadAllLines(@"c:\Users\magnus.eriksson\Dropbox\Abbreviations.txt")
                .Select(x => x.Split(':'))
                .ToDictionary(x => x[0], x => x[1]);

            foreach (KeyValuePair<string, string> item in myAbbList)
            {
                Debug.WriteLine("Value1: {0}, Value2: {1}", item.Key, item.Value);
            }

            return myAbbList;
        }
    }
}
