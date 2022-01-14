using AbbreviationGuesser.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AbbreviationGuesser.Commands
{
    public class UpdateViewCommands : ICommand
    {
        private HandleViewModel _viewModel;

        public UpdateViewCommands(HandleViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            if(parameter.ToString() == "Main")
            {
                _viewModel.SelectedViewModel = new MainViewModel();
            }
            else if(parameter.ToString() == "Config")
            {
                _viewModel.SelectedViewModel = new ConfigViewModel();
            }
        }
    }
}
