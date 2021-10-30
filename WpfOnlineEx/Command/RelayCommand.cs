using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfOnlineEx
{
    public class RelayCommand : ICommand
    {
        Action<object> executeAction;
        Func<object, bool> canExecute;
        bool canExecuteCashe;

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute, bool canExecuteCashe)
        {
            this.executeAction = executeAction;
            this.canExecute = canExecute;
            this.canExecuteCashe = canExecuteCashe;
        }
        
        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }


    }
}
