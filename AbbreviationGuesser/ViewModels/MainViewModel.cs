using AbbreviationGuesser.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbbreviationGuesser.ViewModels
{
    public class MainViewModel : NotifyEventModel
    {
        public MainViewModel()
        {
            var LoadConfigSettings = new SettingsControl();
        }
    }
}
