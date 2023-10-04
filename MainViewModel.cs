using System;
using System.Diagnostics;
using System.Windows.Input;


namespace noodling
{    
   public class MainViewModel
   {
      public int MyInt { get; set; } //In reality this should utilize INotifyPropertyChanged!

      public ICommand AsdfCommand{get;set;}

      public MainViewModel()
      {
         MyInt = 6;
         System.Diagnostics.Debug.WriteLine("text2");
         AsdfCommand = new ActionCommand(() => aktion());
      }

      public void aktion(){
         Trace.WriteLine("text");
      }
   }
}