using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace noodling
{

    public class RelayCommand : ICommand
    {
        private Action execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action execute)
        {
            this.execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public virtual void Execute(object parameter)
        {
            this.execute();
        }
    }

    public class RelayCommand<T> : RelayCommand where T : class
    {
        private readonly Action<T> execute;

        public RelayCommand(Action<T> execute) : base(null)
        {
            this.execute = execute;
        }

        public override void Execute(object parameter)
        {
            if(execute != null)
            {
                execute(parameter as T);
            }
        }
    }
}
