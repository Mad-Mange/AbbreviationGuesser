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
    public class HandleViewModel : NotifyEventModel
    {
        private NotifyEventModel _selectedViewModel = new MainViewModel();
        public NotifyEventModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateViewCommand { get; set; }

        public HandleViewModel()
        {
            UpdateViewCommand = new UpdateViewCommands(this);
        }
    }
}
