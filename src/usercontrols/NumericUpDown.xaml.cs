using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace noodling.usercontrols
{
    /// <summary>
    /// Interaction logic for NumericUpDown.xaml
    /// </summary>
    public partial class NumericUpDown : UserControl
    {
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register("Number", typeof(int), typeof(NumericUpDown));

        public int Number
        {
            get => (int)GetValue(NumberProperty);
            set => SetValue(NumberProperty, value);
        }

        public static readonly DependencyProperty IsNonNegativeProperty = DependencyProperty.Register("IsNonNegative", typeof(bool), typeof(NumericUpDown));

        public bool IsNonNegative
        {
            get => (bool)GetValue(IsNonNegativeProperty);
            set => SetValue(NumberProperty, value);
        }

        public NumericUpDown()
        {
            this.DataContext = this;
            InitializeComponent();
        }

        private void Button_UpClick(object sender, RoutedEventArgs e)
        {
            Number++;
        }

        private void Button_DownClick(object sender, RoutedEventArgs e)
        {
            if(!IsNonNegative || Number>0)
                Number--;
        }

        private static readonly Regex regex = new Regex("[^0-9]+");

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(regex.IsMatch(e.Text))
                e.Handled = true;
        }
    }
}
