using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace noodling.src
{
    internal class MainWindowViewModel
    {
        public int MyInt { get; set; } //In reality this should utilize INotifyPropertyChanged!

        public ICommand AsdfCommand { get; set; }

        public MainWindowViewModel()
        {
            MyInt = 6;
            System.Diagnostics.Debug.WriteLine("text2");
            AsdfCommand = new ActionCommand(() => aktion());

            utility.create.createWorld();
        }

        public void aktion()
        {
            Trace.WriteLine("text");
        }
    }
}
