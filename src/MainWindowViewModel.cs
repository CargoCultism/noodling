using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public RelayCommand AsdfCommand { get; set; }

        public MainWindowViewModel()
        {
            MyInt = 6;
            System.Diagnostics.Debug.WriteLine("text2");
            AsdfCommand = new RelayCommand(() => aktion());

            utility.create.createWorld();
        }

        public void aktion()
        {
            Trace.WriteLine("text");

            List<int> list = new List<int>() { 2, 5, 7 };
            var ints = new ObservableCollection<object>() { list };

            foreach ( var i in ints )
            {
                Trace.WriteLine($"{i}");
            }
        }
    }
}
