using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbreviationGuesser.Models
{
    public class SettingsModel : NotifyEventModel
    {
        public string PathToFile { get; set; }
        public Dictionary<string, string> MyAbbrevationDictonary { get; set; }
    }
}
