using System;
using System.Windows.Input;

namespace noodling{
    public class ActionCommand: ICommand
    {
        private readonly Action action;

        public event EventHandler CanExecuteChanged;

        public ActionCommand(Action action){
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute()
        {
            this.action();

        }
        public void Execute(object parameter)
        {
            this.action();
        }

    }
}