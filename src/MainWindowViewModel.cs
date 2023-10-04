using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        }

        public void aktion()
        {
            Trace.WriteLine("text");
        }
    }
}
