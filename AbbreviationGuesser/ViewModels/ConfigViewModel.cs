using AbbreviationGuesser.Commands;
using AbbreviationGuesser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AbbreviationGuesser.ViewModels
{
    public class ConfigViewModel : NotifyEventModel
    {
        public ICommand ConfigViewCommand { get; set; }

        public ConfigViewModel()
        {
            ConfigViewCommand = new ConfigViewCommands();
        }
    }
}
